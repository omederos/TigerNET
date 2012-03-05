using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class ProdOperatorNode : ArithmeticalBinaryOperatorNode
    {
        public ProdOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, "*") {}
        public ProdOperatorNode() : this(null, null) {}
        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            SpecificCodeGenerator = ilGenerator => ilGenerator.Emit(OpCodes.Mul);
            base.GenerateCode(generator, typeBuilder);
        }
    }
}
