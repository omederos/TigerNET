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
    public class EqualOperatorNode : RelationalBinaryOperatorNode
    {
        public EqualOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, "=") {
            //Este nodo tambien admite la comparacion de Records y Arrays
            AllowedTypes.Add(typeof(RecordType));
            AllowedTypes.Add(typeof(ArrayType));
        }
        public EqualOperatorNode() : this(null, null) {}
        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            throw new NotImplementedException();
        }
    }
}
