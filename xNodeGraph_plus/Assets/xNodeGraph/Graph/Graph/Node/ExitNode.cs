using Cysharp.Threading.Tasks;

namespace Game.Graph {
    [CreateNodeMenuAttribute("流程-结束")]
    public class ExitNode : FlowNode {
        public override string Title {
            get {
                return "流程-结束";
            }
        }

        public override string Note {
            get {
                return "结束本次执行过程";
            }
        }

        public override object Run(Runtime runtime, int id) {
            runtime.ExitFunc(id);

            return null;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
            await UniTask.CompletedTask;
            runtime.ExitFunc(id);

            return null;
        }
    }
}

