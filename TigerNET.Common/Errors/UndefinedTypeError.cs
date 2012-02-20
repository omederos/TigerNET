using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.Common.Errors
{
    public class UndefinedTypeError : Error
    {
        public string TypeName { get; private set; }
        public UndefinedTypeError(int line, int column, string type) : base(line, column) {
            TypeName = type;
        }

        public override string ToString() {
            return string.Format("The type {0} does not exist", TypeName);
        }
    }
}
