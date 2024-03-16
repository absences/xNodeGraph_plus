using Cysharp.Threading.Tasks;
using Game.Graph;

namespace Generated.Graph.GGame.Lib.CommonLib_ {
    [CreateNodeMenuAttribute("通用-打开界面")]
    public class OpenViewNode : FlowNode {
        public override string Title {
            get {
                return "通用-打开界面";
            }
        }

        public override string Note {
            get {
                return "等待打开界面";
            }
        }

        public override bool Async {
            get {
                return true;
            }
        }

		[Input(connectionType = ConnectionType.Override)]
        public System.String viewName;
        private BaseNode viewNameNode;
        


        protected override void Init() {
            base.Init();
            
			this.viewNameNode = this.GetPortNode("viewName");

        }

        public override object Run(Runtime runtime, int id) {

            return null;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
			var viewName = await this.GetValueAsync<System.String>(this.viewName, this.viewNameNode, runtime);
			await Game.Lib.CommonLib.OpenView(viewName);

            return null;
        }
    }
}
        