using Cysharp.Threading.Tasks;

using XNode;

namespace Game.Graph {
    [CreateNodeMenuAttribute("逻辑判断")]
    public class LogicNode : BaseNode {
        public override string Title {
            get {
                return "逻辑判断";
            }
        }

        public override string Note {
            get {
                return "通过与/或/非，结合两个逻辑值得出结果\n如果使用Not（取反）的时候，只需要填写参数a即可";
            }
        }

        public enum Method {
            And,
            Or,
            Not
        }

        [Input(connectionType = ConnectionType.Override)]
        public Boolen a;
        private BaseNode aNode;

        [Input(connectionType = ConnectionType.Override)]
        public Boolen b;
        private BaseNode bNode;

        public Method method;

        [Output]
        public Boolen ret;

        protected override void Init() {
            base.Init();
            this.aNode = this.GetPortNode("a");
            this.bNode = this.GetPortNode("b");
        }

        public override object Run(Runtime runtime, int id) {
            var a = this.GetValue<Boolen>(this.a, this.aNode, runtime);
            var b = this.GetValue<Boolen>(this.b, this.bNode, runtime);
            this.ret.value = this.Calculate(a.value, b.value);
            
            return this.ret;
        }

        public async override UniTask<object> RunAsync(Runtime runtime, int id) {
            var a = await this.GetValueAsync<Boolen>(this.a, this.aNode, runtime);
            var b = await this.GetValueAsync<Boolen>(this.b, this.bNode, runtime);
            this.ret.value = this.Calculate(a.value, b.value);
            
            return this.ret;
        }

        private bool Calculate(bool a, bool b) {
            if (this.method == Method.And) {
                return a && b;
            }
            else if (this.method == Method.Or) {
                return a || b;
            }
            
            return !a;
        }
    }
}