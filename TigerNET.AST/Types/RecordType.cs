using System.Collections.Generic;

namespace TigerNET.AST.Types {
    public class RecordType : TigerType
    {
        public RecordType(string name, IDictionary<string, TigerType> fields) : base(name) {
            Fields = fields;
        }

        protected IDictionary<string, TigerType> Fields { get; set; }
    }
}