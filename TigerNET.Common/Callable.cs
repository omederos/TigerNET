using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common {
    public class Callable {
        public string Name { get; set; }
        public IList<TypeField> Fields { get; set; }
        public string Type { get; set; }

        public Callable(string name, IList<TypeField> fields, string type = null) {
            Name = name;
            Fields = fields;
            Type = type;
        }

        public bool IsFunction() {
            return Type != null;
        }
    }
}