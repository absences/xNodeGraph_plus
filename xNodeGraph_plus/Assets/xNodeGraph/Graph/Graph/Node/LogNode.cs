using Cysharp.Threading.Tasks;

using UnityEngine;
using XNode;

namespace Game.Graph {
    [CreateNodeMenuAttribute("调试输出")]
    public class LogNode : FlowNode {
        public override string Title {
            get {
                return "调试输出";
            }
        }

        public override string Note {
            get {
                return @"打印输出结果";
            }
        }

        [Input(connectionType = ConnectionType.Override)]
        public string value;
        private BaseNode valueNode;

        protected override void Init() {
            base.Init();

            this.valueNode = this.GetPortNode("value");
        }

        public override object Run(Runtime runtime, int id) {
            var value = this.GetValue<object>(this.value, this.valueNode, runtime);
            Debug.Log(value.ToString());

            return null;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
            var value = await this.GetValueAsync<object>(this.value, this.valueNode, runtime);
            Debug.Log(value.ToString());

            return null;
        }
    }
}