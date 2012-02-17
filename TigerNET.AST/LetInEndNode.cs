using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class LetInEndNode : InstructionNode
    {
        /// <summary>
        /// Declaraciones dentro del LET - IN
        /// </summary>
        public IList<DeclarationNode> Declarations { get; set; }
        /// <summary>
        /// Expresiones a ejecutar dentro del IN - END
        /// </summary>
        public ExpressionSequenceNode Expressions { get; set; }

        public LetInEndNode(IList<DeclarationNode> declarations, ExpressionSequenceNode expressions) {
            Declarations = declarations;
            Expressions = expressions;
        }
        public LetInEndNode(IList<DeclarationNode> declarations) : this(declarations, new ExpressionSequenceNode()) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
