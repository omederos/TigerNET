namespace TigerNET.AST
{
    public abstract class BinaryOperatorNode : OperatorNode
    {
        public ExpressionNode Left { get; set; }
        public ExpressionNode Right { get; set; }

        protected BinaryOperatorNode(ExpressionNode left, ExpressionNode right) {
            Left = left;
            Right = right;
        }
    }
}
