using System;
using System.Reflection.Emit;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public abstract class LogicalBinaryOperatorNode : BinaryOperatorNode
    {
        protected LogicalBinaryOperatorNode(ExpressionNode left, ExpressionNode right, string operatorName) : base(left, right, operatorName) {
            AllowedTypes.Add(typeof(IntegerType));
        }
    }
}
