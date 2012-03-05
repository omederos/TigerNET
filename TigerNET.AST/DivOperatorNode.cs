using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class DivOperatorNode : ArithmeticalBinaryOperatorNode
    {
        public DivOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, "/") {}
        public DivOperatorNode() : this(null, null) {}
        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            SpecificCodeGenerator = ilGenerator => ilGenerator.Emit(OpCodes.Div);
            base.GenerateCode(generator, typeBuilder);
        }
    }
}
