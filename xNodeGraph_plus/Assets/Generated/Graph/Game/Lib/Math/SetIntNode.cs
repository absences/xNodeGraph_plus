using Cysharp.Threading.Tasks;
using Game.Graph;

namespace Generated.Graph.GGame.Lib.Math_ {
    [CreateNodeMenuAttribute("数学-取整数")]
    public class SetIntNode : FlowNode {
        public override string Title {
            get {
                return "数学-取整数";
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
        public Game.Graph.Obj v;
        private BaseNode vNode;
        
		[Output]public Game.Graph.Obj ret;

        protected override void Init() {
            base.Init();
            
			this.vNode = this.GetPortNode("v");

        }

        public override object Run(Runtime runtime, int id) {
			var v = this.GetObject(this.vNode, runtime);
			this.ret.value = Game.Lib.Math.SetInt(v);
			runtime.CacheValue(this, this.ret);

            return this.ret.value;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
			var v = await this.GetObjectAsync(this.vNode, runtime);
			this.ret.value = Game.Lib.Math.SetInt(v);
			runtime.CacheValue(this, this.ret);
			await UniTask.CompletedTask;

            return this.ret.value;
        }
    }
}
        