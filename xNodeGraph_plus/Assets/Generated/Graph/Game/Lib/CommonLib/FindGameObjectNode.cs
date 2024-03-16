using Cysharp.Threading.Tasks;
using Game.Graph;

namespace Generated.Graph.GGame.Lib.CommonLib_ {
    [CreateNodeMenuAttribute("通用-查找物体")]
    public class FindGameObjectNode : FlowNode {
        public override string Title {
            get {
                return "通用-查找物体";
            }
        }

        public override string Note {
            get {
                return "根据名称获取物体对象";
            }
        }

        public override bool Async {
            get {
                return true;
            }
        }

		[Input(connectionType = ConnectionType.Override)]
        public System.String name;
        private BaseNode nameNode;
        
		[Output]public UnityEngine.GameObject ret;

        protected override void Init() {
            base.Init();
            
			this.nameNode = this.GetPortNode("name");

        }

        public override object Run(Runtime runtime, int id) {

            return this.ret;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
			var name = await this.GetValueAsync<System.String>(this.name, this.nameNode, runtime);
			this.ret = await Game.Lib.CommonLib.FindGameObject(name);
			runtime.CacheValue(this, this.ret);

            return this.ret;
        }
    }
}
        