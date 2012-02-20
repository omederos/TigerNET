namespace TigerNET.Common.Errors {
    public class DuplicateParameterError : Error {
        public string ParameterName { get; set; }

        public DuplicateParameterError(int line, int column, string parameterName) : base(line, column) {
            ParameterName = parameterName;
        }

        public override string ToString() {
            return string.Format("Duplicate parameter '{0}'", ParameterName);
        }
    }
}