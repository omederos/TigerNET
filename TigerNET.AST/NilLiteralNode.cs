using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public class NilLiteralNode : AtomicLiteralNode
    {
        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            ReturnType = NilType.Create();
        }
    }
}
