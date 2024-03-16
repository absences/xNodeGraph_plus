using Cysharp.Threading.Tasks;
using Game.Graph;

namespace Generated.Graph.GGame.Lib.CommonLib_ {
    [CreateNodeMenuAttribute("通用-获取结果")]
    public class GetBoolenNode : BaseNode {
        public override string Title {
            get {
                return "通用-获取结果";
            }
        }

        public override string Note {
            get {
                return "等待";
            }
        }

        public override bool Async {
            get {
                return true;
            }
        }

		[Output]public Game.Graph.Boolen ret;

        protected override void Init() {
            base.Init();
            

        }

        public override object Run(Runtime runtime, int id) {

            return this.ret;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
			this.ret.value = await Game.Lib.CommonLib.GetBoolen();

            return this.ret;
        }
    }
}
        