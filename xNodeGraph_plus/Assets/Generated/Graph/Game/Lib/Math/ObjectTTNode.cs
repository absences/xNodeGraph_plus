using Cysharp.Threading.Tasks;
using Game.Graph;

namespace Generated.Graph.GGame.Lib.Math_ {
    [CreateNodeMenuAttribute("数学-对象")]
    public class ObjectTTNode : FlowNode {
        public override string Title {
            get {
                return "数学-对象";
            }
        }

        public override string Note {
            get {
                return "";
            }
        }

        public override bool Async {
            get {
                return false;
            }
        }

		[Input(connectionType = ConnectionType.Override)]
        public Game.Graph.Obj p;
        private BaseNode pNode;
        
		[Output]public Game.Graph.Obj ret;

        protected override void Init() {
            base.Init();
            
			this.pNode = this.GetPortNode("p");

        }

        public override object Run(Runtime runtime, int id) {
			var p = this.GetObject(this.pNode, runtime);
			this.ret.value = Game.Lib.Math.ObjectTT(p);
			runtime.CacheValue(this, this.ret);

            return this.ret.value;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
			var p = await this.GetObjectAsync(this.pNode, runtime);
			this.ret.value = Game.Lib.Math.ObjectTT(p);
			runtime.CacheValue(this, this.ret);
			await UniTask.CompletedTask;

            return this.ret.value;
        }
    }
}
        