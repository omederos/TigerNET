using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public abstract class RelationalBinaryOperatorNode : BinaryOperatorNode
    {
        protected RelationalBinaryOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}
    }
}
