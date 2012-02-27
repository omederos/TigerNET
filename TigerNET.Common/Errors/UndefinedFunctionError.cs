using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.Common.Errors
{
    public class UndefinedFunctionError : Error
    {
        public string FunctionName { get; private set; }
        public UndefinedFunctionError(int line, int column, string functionName) : base(line, column) {
            FunctionName = functionName;
        }

        public override string ToString() {
            return string.Format("The function/procedure {0} does not exist", FunctionName);
        }
    }
}
