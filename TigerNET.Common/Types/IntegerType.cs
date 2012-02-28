using System;

namespace TigerNET.Common.Types {
    public class IntegerType : TigerType {
        private static IntegerType _instance;
        
        private IntegerType() : base("int", Guid.NewGuid()) {}

        public override bool Equals(object obj) {
            return obj is IntegerType;
        }

        public static IntegerType Create() {
            return _instance ?? (_instance = new IntegerType());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString() {
            return "int";
        }
    }
}