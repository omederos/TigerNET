namespace TigerNET.Common.Types {
    public class NilType  : TigerType {
        private static NilType _instance;
        private NilType() : base("nil") {}
        public static NilType Create() {
            return _instance ?? (_instance = new NilType());
        }
    }
}