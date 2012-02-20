namespace TigerNET.Common.Errors {
    public class NilAssignmentError : Error {
        public string VariableName { get; set; }

        public NilAssignmentError(int line, int column, string variableName) : base(line, column) {
            VariableName = variableName;
        }
        public override string ToString() {
            return string.Format("The type of the variable '{0}' cannot be determined because the expression returns 'nil'", VariableName);
        }
    }
}