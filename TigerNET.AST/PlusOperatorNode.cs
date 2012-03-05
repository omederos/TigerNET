using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class PlusOperatorNode : ArithmeticalBinaryOperatorNode
    {
        public PlusOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, "+") {}
        public PlusOperatorNode() : this(null, null) {}
        
        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            SpecificCodeGenerator = ilGenerator => ilGenerator.Emit(OpCodes.Add);
            base.GenerateCode(generator, typeBuilder);
        }
    }
}
