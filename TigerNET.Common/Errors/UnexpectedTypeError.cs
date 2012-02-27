using TigerNET.Common.Types;

namespace TigerNET.Common.Errors {
    public class UnexpectedTypeError : Error {
        public TigerType Type { get; set; }
        public string ExpectedType { get; set; }

        public UnexpectedTypeError(int line, int column, TigerType type, TigerType expectedType) : base(line, column) {
            Type = type;
            ExpectedType = expectedType.ToString();
        }
        public UnexpectedTypeError(int line, int column, TigerType type, string expectedTypeString) : base(line, column) {
            Type = type;
            ExpectedType = expectedTypeString;
        }

        public override string ToString() {
            return string.Format("Expected type '{0}' but found '{1}'", ExpectedType, Type);
        }
    }
}