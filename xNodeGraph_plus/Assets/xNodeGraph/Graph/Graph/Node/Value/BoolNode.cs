using Cysharp.Threading.Tasks;

using UnityEngine;
using XNode;

namespace Game.Graph {
    [CreateNodeMenuAttribute("类型-布尔值")]
    public class BoolNode : BaseNode {
        public override string Title {
            get {
                return "类型-布尔值";
            }
        }

        public Boolen value;

        [Output]
        public Boolen Ret;

        public override object Run(Runtime runtime, int id) {
            return this.value;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
            await UniTask.CompletedTask;
            
            return this.value;
        }
    }
}