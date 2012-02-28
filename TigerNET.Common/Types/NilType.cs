using System;

namespace TigerNET.Common.Types {
    public class NilType  : TigerType {
        private static NilType _instance;
        private NilType() : base("nil", Guid.NewGuid()) {
        }
        public static NilType Create() {
            return _instance ?? (_instance = new NilType());
        }

        public static bool CanBeAssignedTo(TigerType type) {
            return type is RecordType || type is ArrayType || type is StringType;
        }

        public override string ToString() {
            return "nil";
        }
    }
}