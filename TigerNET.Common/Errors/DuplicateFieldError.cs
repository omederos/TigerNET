namespace TigerNET.Common.Errors {
    public class DuplicateFieldError : Error {
        public string FieldName { get; set; }

        public DuplicateFieldError(int line, int column, string fieldName) : base(line, column) {
            FieldName = fieldName;
        }
        
        public override string ToString() {
            return string.Format("Duplicate field: {0}", FieldName);
        }
    }
}