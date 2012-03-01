using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.Common.Types
{
    public class Variable
    {
        public string Name { get; set; }
        public TigerType Type { get; set; }
        public bool ReadOnly { get; set; }

        public Variable(string name, TigerType type, bool readOnly = false) {
            Name = name;
            Type = type;
            ReadOnly = readOnly;
        }

        public override string ToString() {
            var toString = string.Format("{0} [{1}]", Name, Type);
            if (ReadOnly) {
                toString = "[R] " + toString;
            }
            return toString;
        }
    }
}
