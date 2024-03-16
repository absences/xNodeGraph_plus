using Cysharp.Threading.Tasks;
using Game.Graph;

namespace Generated.Graph.GGame.Lib.CommonLib_ {
    [CreateNodeMenuAttribute("通用-取(object)名称")]
    public class GetNameNode : BaseNode {
        public override string Title {
            get {
                return "通用-取(object)名称";
            }
        }

        public override string Note {
            get {
                return "获取obj.Tostring()";
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
        
		[Output]public System.String ret;

        protected override void Init() {
            base.Init();
            
			this.pNode = this.GetPortNode("p");

        }

        public override object Run(Runtime runtime, int id) {
			var p = this.GetObject(this.pNode, runtime);
			this.ret = Game.Lib.CommonLib.GetName(p);

            return this.ret;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
			var p = await this.GetObjectAsync(this.pNode, runtime);
			this.ret = Game.Lib.CommonLib.GetName(p);
			await UniTask.CompletedTask;

            return this.ret;
        }
    }
}
        