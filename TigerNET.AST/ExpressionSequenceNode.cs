﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

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

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Si no hay expresiones, no se hace nada. El tipo de retorno sigue siendo Null
            if (Sequence.Count == 0) {
                return;
            }

            //Chequeamos semanticamente cada expresion
            foreach (var expr in Sequence) {
                expr.CheckSemantic(scope, errors);
            }

            //El tipo de retorno sera el de la ultima expresion
            ReturnType = Sequence[Sequence.Count - 1].ReturnType;
        }
    }
}
