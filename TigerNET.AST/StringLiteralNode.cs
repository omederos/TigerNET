using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace TigerNET.AST
{
    public class StringLiteralNode : LiteralNode
    {
        public string Value { get; set; }

        public StringLiteralNode(string value) {
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
