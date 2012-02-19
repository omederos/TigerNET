using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.AST.Types;

namespace TigerNET.AST
{
    public class IntegerLiteralNode : AtomicLiteralNode
    {
        public int Value { get; set; }

        public IntegerLiteralNode(int value) {
            Value = value;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
