using Cysharp.Threading.Tasks;
using Game.Graph;

namespace Generated.Graph.GGame.Lib.CommonLib_ {
    [CreateNodeMenuAttribute("通用-调用Action方法")]
    public class CallFunNode : FlowNode {
        public override string Title {
            get {
                return "通用-调用Action方法";
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
        public Game.Graph.UEFun action;
        private BaseNode actionNode;
        


        protected override void Init() {
            base.Init();
            
			this.actionNode = this.GetPortNode("action");

        }

        public override object Run(Runtime runtime, int id) {
			var action = this.GetValue<Game.Graph.UEFun>(this.action, this.actionNode, runtime);
			Game.Lib.CommonLib.CallFun(action.value);

            return null;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
			var action = await this.GetValueAsync<Game.Graph.UEFun>(this.action, this.actionNode, runtime);
			Game.Lib.CommonLib.CallFun(action.value);
			await UniTask.CompletedTask;

            return null;
        }
    }
}
        