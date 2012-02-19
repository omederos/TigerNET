using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.AST.Types;

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
            ReturnType = StringType.Create();
        }
    }
}
