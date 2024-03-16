using Cysharp.Threading.Tasks;
using Game.Graph;

namespace Generated.Graph.GGame.Lib.Math_ {
    [CreateNodeMenuAttribute("数学-相乘")]
    public class MultiplieNode : BaseNode {
        public override string Title {
            get {
                return "数学-相乘";
            }
        }

        public override string Note {
            get {
                return "a * b";
            }
        }

        public override bool Async {
            get {
                return false;
            }
        }

		[Input(connectionType = ConnectionType.Override)]
        public Game.Graph.Number a;
        private BaseNode aNode;
        
		[Input(connectionType = ConnectionType.Override)]
        public Game.Graph.Number b;
        private BaseNode bNode;
        
		[Output]public Game.Graph.Number ret;

        protected override void Init() {
            base.Init();
            
			this.aNode = this.GetPortNode("a");
			this.bNode = this.GetPortNode("b");

        }

        public override object Run(Runtime runtime, int id) {
			var a = this.GetValue<Game.Graph.Number>(this.a, this.aNode, runtime);
			var b = this.GetValue<Game.Graph.Number>(this.b, this.bNode, runtime);
			this.ret.value = Game.Lib.Math.Multiplie(a.value, b.value);

            return this.ret;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
			var a = await this.GetValueAsync<Game.Graph.Number>(this.a, this.aNode, runtime);
			var b = await this.GetValueAsync<Game.Graph.Number>(this.b, this.bNode, runtime);
			this.ret.value = Game.Lib.Math.Multiplie(a.value, b.value);
			await UniTask.CompletedTask;

            return this.ret;
        }
    }
}
        