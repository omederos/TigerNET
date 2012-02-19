namespace TigerNET.AST.Types {
    public class StringType : TigerType {
        public StringType() : base("string") {}

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(StringType);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}