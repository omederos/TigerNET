using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common.Types;

namespace TigerNET.Common.Errors
{
    public class OperatorError : Error
    {
        public string OperatorName { get; set; }
        public TigerType T1 { get; set; }
        public TigerType T2 { get; set; }

        public OperatorError(int line, int column, string operatorName, TigerType t1, TigerType t2) : base(line, column) {
            OperatorName = operatorName;
            T1 = t1;
            T2 = t2;
        }

        public override string ToString() {
            return string.Format("Cannot apply operator '{0}' to operands of type {1} and {2}", OperatorName, T1, T2);
        }
    }
}
