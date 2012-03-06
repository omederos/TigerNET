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
    public class NilLiteralNode : AtomicLiteralNode
    {
        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            generator.Emit(OpCodes.Ldnull);
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            ReturnType = NilType.Create();
        }
    }
}
