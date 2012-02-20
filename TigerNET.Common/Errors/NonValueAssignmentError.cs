namespace TigerNET.Common.Errors {
    public class NonValueAssignmentError : Error {
        public string VariableName { get; set; }

        public NonValueAssignmentError(int line, int column, string variableName) : base(line, column) {
            VariableName = variableName;
        }
        public override string ToString() {
            return string.Format("The expression that was assigned to '{0}' does not return any value", VariableName);
        }
    }
}