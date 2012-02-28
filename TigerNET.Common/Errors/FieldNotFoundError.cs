using System;

namespace TigerNET.Common.Errors {
    public class FieldNotFoundError : Error {
        public string RecordName { get; set; }
        public string FieldName { get; set; }

        public FieldNotFoundError(int line, int column, string recordName, string fieldName) : base(line, column) {
            RecordName = recordName;
            FieldName = fieldName;
        }

        public override string ToString() {
            return string.Format("Record '{0}' does not have the field '{1}'", RecordName, FieldName);
        }
    }
}