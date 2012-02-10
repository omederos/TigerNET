using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.AST.Types;

namespace TigerNET.AST {
    public abstract class ExpressionNode {
        public int Line { get; set; }
        public int Column { get; set; }

        public TigerType ReturnType { get; private set; }

        public bool ReturnsValue() {
            return !(ReturnType is VoidType);
        }

        public abstract void GenerateCode();
        public abstract void CheckSemantic();
    }
}