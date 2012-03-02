using System;
using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST {
    public class IfThenElseNode : ControlNode{
        public ExpressionNode ElseBody { get; set; }
        public ExpressionNode ThenBody { get; set; }
        public ExpressionNode Condition { get; set; }

        public IfThenElseNode(ExpressionNode condition, ExpressionNode thenBody, ExpressionNode elseBody) {
            Condition = condition;
            ThenBody = thenBody;
            ElseBody = elseBody;
            Condition.Parent = this;
            ThenBody.Parent = this;
            if (ElseBody != null) {
                ElseBody.Parent = this;
            }
        }

        public override void GenerateCode() {

            
            ReturnType = null;
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //ReturnType = Else.ReturnType
            Condition.CheckSemantic(scope, errors);
            //Comprobamos que Condition retorne un entero
            ErrorsHelper.CheckIfReturnTypeIsInt(Condition, errors, "The condition must return a value", "The condition must return an integer");

            int errorsCount = errors.Count;
            ThenBody.CheckSemantic(scope, errors);
            
            if (errorsCount != errors.Count) {
                return;
            }
            
            //Si no existe Else...
            if (ElseBody == null) {
                //Si retorna valor...
                if (ThenBody.ReturnsValue()) {
                    errors.Add(new MessageError(Line, Column, "'then' expression must not return a value"));
                }
            }
            //Si existe el else...
            else {
                //Ambas expresiones deben, o retornar el mismo tipo, o no retornar valor
                ElseBody.CheckSemantic(scope, errors);

                //Comprobamos si ambos no retornan tipo
                if (!ThenBody.ReturnsValue() && !ElseBody.ReturnsValue())
                {
                    //Entonces esta expresion no retorna nada
                    ReturnType = null;
                    return;
                }
                //Si retornan tipos diferentes...
                if (ThenBody.ReturnType != ElseBody.ReturnType)
                {
                    //Si alguno de los dos es nil...
                    if (ThenBody.ReturnType is NilType || ElseBody.ReturnType is NilType) {
                        var nonNilType = ThenBody.ReturnType is NilType ? ElseBody.ReturnType : ThenBody.ReturnType;
                        //Si no pasa que el tipo es 'nil' y puede ser asignado (es decir, si el tipo no es 'nil', o si el tipo es 'nil' y no puede ser asignado)
                        if (!(NilType.CanBeAssignedTo(nonNilType))) {
                            errors.Add(new MessageError(Line, Column,
                                                        "In if-then-else expressions, both 'then' and 'else' expressions must either return no value or be of the same type"));
                        }
                    }
                }
                //Si retornan el mismo tipo
                else {
                    ReturnType = ThenBody.ReturnType;
                }
            }
        }
    }
}