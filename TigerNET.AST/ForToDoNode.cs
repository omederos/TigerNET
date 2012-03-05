using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST {
    public class ForToDoNode : LoopNode
    {
        public string VariableName { get; set; }
        public ExpressionNode ExpressionInitial { get; set; }
        public ExpressionNode ExpressionFinal { get; set; }
        public ExpressionNode Body { get; set; }

        public ForToDoNode(string variableName, ExpressionNode expressionInitial, ExpressionNode expressionFinal, ExpressionNode body) {
            VariableName = variableName;
            ExpressionInitial = expressionInitial;
            ExpressionFinal = expressionFinal;
            Body = body;
            ExpressionInitial.Parent = this;
            ExpressionFinal.Parent = this;
            Body.Parent = this;

        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder)
        {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //El 'for' define un nuevo scope
            var scopeFor = new Scope(scope);
            //Anadimos una variable de tipo entero de solo lectura al scope del 'for'
            scopeFor.Add(VariableName, IntegerType.Create(), true);

            //Evaluamos la expresion de inicio y la de fin.
            //OJO: Con el Scope que veniamos usando hasta ahora, pues la variable del 'for' no es visible para estas expresiones
            int errorsCount = errors.Count;
            ExpressionInitial.CheckSemantic(scope, errors);
            ExpressionFinal.CheckSemantic(scope, errors);
            //Si ocurrio algun error, lo mas probable es que no se haya asignado un tipo de retorno a estas expresiones, por lo que terminamos
            if (errorsCount != errors.Count) {
                return;
            }

            //Comprobamos que retornen valores las expresiones anteriores y que sea entero
            ErrorsHelper.CheckIfReturnTypeIsInt(ExpressionInitial, errors, "The expression that defines the first value in the 'for' must return a value", "The expression that defines the first value in the 'for' must return an integer");
            ErrorsHelper.CheckIfReturnTypeIsInt(ExpressionFinal, errors, "The expression that defines the last value in the 'for' must return a value", "The expression that defines the last value in the 'for' must return an integer");

            //Comprobamos el cuerpo
            Body.CheckSemantic(scopeFor, errors);
            
            //Comprobamos que retorne algun valor
            if (Body.ReturnsValue()) {
                errors.Add(new MessageError(Line, Column, "Expression body of 'for' must not return a value"));
            }
        }
    }
}