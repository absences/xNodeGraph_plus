using Cysharp.Threading.Tasks;
using Game.Graph;

namespace Generated.Graph.GGame.Lib.CommonLib_ {
    [CreateNodeMenuAttribute("通用-设置物体名称")]
    public class SetNameNode : FlowNode {
        public override string Title {
            get {
                return "通用-设置物体名称";
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
        public Game.Graph.Obj obj;
        private BaseNode objNode;
        
		[Input(connectionType = ConnectionType.Override)]
        public System.String named;
        private BaseNode namedNode;
        


        protected override void Init() {
            base.Init();
            
			this.objNode = this.GetPortNode("obj");
			this.namedNode = this.GetPortNode("named");

        }

        public override object Run(Runtime runtime, int id) {
			var obj = this.GetObject(this.objNode, runtime);
			var named = this.GetValue<System.String>(this.named, this.namedNode, runtime);
			Game.Lib.CommonLib.SetName(obj, named);

            return null;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
			var obj = await this.GetObjectAsync(this.objNode, runtime);
			var named = await this.GetValueAsync<System.String>(this.named, this.namedNode, runtime);
			Game.Lib.CommonLib.SetName(obj, named);
			await UniTask.CompletedTask;

            return null;
        }
    }
}
        