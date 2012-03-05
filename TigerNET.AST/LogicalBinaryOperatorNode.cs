using System;
using System.Reflection.Emit;

namespace TigerNET.AST
{
    public abstract class LogicalBinaryOperatorNode : BinaryOperatorNode
    {
        protected LogicalBinaryOperatorNode(ExpressionNode left, ExpressionNode right, string operatorName) : base(left, right, operatorName) {}
    }
}
