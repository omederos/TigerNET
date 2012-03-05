using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class MinusOperatorNode : ArithmeticalBinaryOperatorNode
    {
        public MinusOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, "-") {}
        public MinusOperatorNode() : this(null, null) {}
        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            SpecificCodeGenerator = ilGenerator => ilGenerator.Emit(OpCodes.Sub);
            base.GenerateCode(generator, typeBuilder);
        }
    }
}
