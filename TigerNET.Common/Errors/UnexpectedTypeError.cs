using TigerNET.Common.Types;

namespace TigerNET.Common.Errors {
    public class UnexpectedTypeError : Error {
        public TigerType Type { get; set; }
        public TigerType ExpectedType { get; set; }

        public UnexpectedTypeError(int line, int column, TigerType type, TigerType expectedType) : base(line, column) {
            Type = type;
            ExpectedType = expectedType;
        }

        public override string ToString() {
            return string.Format("Se esperaba el tipo {0} en vez de {1}", ExpectedType, Type);
        }
    }
}