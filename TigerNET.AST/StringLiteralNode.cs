using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public class StringLiteralNode : LiteralNode
    {
        public string Value { get; set; }

        public StringLiteralNode(string value) {
            Value = value;
        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            ReturnType = StringType.Create();
        }
    }
}
