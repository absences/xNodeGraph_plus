using Cysharp.Threading.Tasks;

using UnityEngine;
using XNode;

namespace Game.Graph {
    [CreateNodeMenuAttribute("类型-资源对象")]
    public class ObjectNode : BaseNode {
        public override string Title {
            get {
                return "类型-资源对象";
            }
        }

        public Object value;

        [Output]
        public Object Ret;

        public override object Run(Runtime runtime, int id) {
            return this.value;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
            await UniTask.CompletedTask;
            
            return this.value;
        }
    }
}