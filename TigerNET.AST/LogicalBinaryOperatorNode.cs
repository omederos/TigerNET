namespace TigerNET.AST
{
    public abstract class LogicalBinaryOperatorNode : BinaryOperatorNode
    {
        protected LogicalBinaryOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}
    }
}
