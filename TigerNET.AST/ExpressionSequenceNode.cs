using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class ExpressionSequenceNode : ExpressionNode
    {
        public IList<ExpressionNode> Sequence { get; set; }

        public ExpressionSequenceNode(IList<ExpressionNode> sequence) {
            Sequence = sequence;
        }
        public ExpressionSequenceNode() : this(new List<ExpressionNode>())
        {
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
