using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST {
    public class WhileNode : LoopNode
    {
        public ExpressionNode Condition { get; set; }
        public ExpressionNode Body { get; set; }

        public WhileNode(ExpressionNode condition, ExpressionNode body) {
            Condition = condition;
            Body = body;
            Condition.Parent = this;
            Body.Parent = this;
        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder)
        {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors)
        {
            //La condicion debe retornar entero
            //El cuerpo no puede retornar valor
            //No retorna nada

            int errorsCount = errors.Count;
            Condition.CheckSemantic(scope, errors);
            Body.CheckSemantic(scope, errors);

            //La condicion debe retornar un entero
            ErrorsHelper.CheckIfReturnTypeIsInt(Condition, errors, "The condition must return a value", "The condition must return an integer");

            //El cuerpo no puede retornar valor
            if (Body.ReturnsValue()) {
                errors.Add(new MessageError(Line, Column, "Expression body of 'while' must not return a value"));
            }
        }
    }
}