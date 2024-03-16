using Cysharp.Threading.Tasks;

namespace Game.Graph {
    [CreateNodeMenuAttribute("类型-三维向量")]
    public class Vec3Node : BaseNode {
        public override string Title {
            get {
                return "类型-三维向量";
            }
        }

        public Vec3 value;

        [Output]
        public Vec3 Ret;

        public override object Run(Runtime runtime, int id) {
            return this.value;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
            await UniTask.CompletedTask;
            
            return this.value;
        }
    }
}