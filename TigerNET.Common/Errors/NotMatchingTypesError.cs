using TigerNET.Common.Types;

namespace TigerNET.Common.Errors {
    public class NotMatchingTypesError : Error {
        public TigerType ExplicitType { get; set; }
        public TigerType ExpressionType { get; set; }

        public NotMatchingTypesError(int line, int column, TigerType explicitType, TigerType expressionType) : base(line, column) {
            ExplicitType = explicitType;
            ExpressionType = expressionType;
        }

        public override string ToString() {
            return string.Format("Types {0} and {1} are not the same", ExplicitType.Name, ExpressionType.Name);
        }
    }
}