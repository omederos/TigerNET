namespace TigerNET.AST.Types {
    public class IntegerType : TigerType {
        public IntegerType() : base("int") {}

        public override bool Equals(object obj) {
            return obj.GetType() == typeof (IntegerType);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}