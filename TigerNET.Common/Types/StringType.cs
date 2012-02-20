namespace TigerNET.Common.Types {
    public class StringType : TigerType {
        private static StringType _instance;
        private StringType() : base("string") {}

        public static StringType Create() {
            return _instance ?? (_instance = new StringType());
        }

        public override bool Equals(object obj)
        {
            return obj is StringType;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}