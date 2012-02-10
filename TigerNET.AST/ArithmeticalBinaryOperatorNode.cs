namespace TigerNET.AST
{
    public abstract class ArithmeticalBinaryOperatorNode : BinaryOperatorNode
    {
        protected ArithmeticalBinaryOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}
    }
}
