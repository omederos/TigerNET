using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common.Types;

namespace TigerNET.Common
{
    public class Variable : IUniqueNamed
    {
        public string Name { get; set; }
        public TigerType Type { get; set; }
        public bool ReadOnly { get; set; }
        private string _id;
        /// <summary>
        /// Hace referencia a la variable declarada como instancia de cierta clase en IL (campo de la clase)
        /// </summary>
        public FieldBuilder ILVariable { get; set; }

        public Variable(string name, TigerType type, bool readOnly = false) {
            Name = name;
            Type = type;
            ReadOnly = readOnly;
            _id = Guid.NewGuid().ToCleanString();
        }

        public override string ToString() {
            var toString = string.Format("{0} [{1}]", Name, Type);
            if (ReadOnly) {
                toString = "[R] " + toString;
            }
            return toString;
        }

        public string GetName() {
            return _id;
        }
    }
}
