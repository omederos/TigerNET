using System;
using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST {
    public class ForToDoNode : ControlNode
    {
        public string VariableName { get; set; }
        public ExpressionNode ExpressionInitial { get; set; }
        public ExpressionNode ExpressionFinal { get; set; }
        public ExpressionNode Body { get; set; }

        public ForToDoNode(string variableName, ExpressionNode expressionInitial, ExpressionNode expressionFinal, ExpressionNode Body) {
            VariableName = variableName;
            ExpressionInitial = expressionInitial;
            ExpressionFinal = expressionFinal;
            this.Body = Body;
        }

        public override void GenerateCode()
        {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors)
        {
            throw new NotImplementedException();
        }
    }
}