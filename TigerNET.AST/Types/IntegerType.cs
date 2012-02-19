namespace TigerNET.AST.Types {
    public class IntegerType : TigerType {
        private static IntegerType _instance;
        
        private IntegerType() : base("int") {}

        public override bool Equals(object obj) {
            return obj.GetType() == typeof (IntegerType);
        }

        public static IntegerType Create() {
            return _instance ?? (_instance = new IntegerType());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}