namespace TigerNET.AST
{
    public abstract class UnaryOperatorNode : OperatorNode
    {
        public ExpressionNode Body { get; set; }

        protected UnaryOperatorNode(ExpressionNode body) {
            Body = body;
        }
    }
}
