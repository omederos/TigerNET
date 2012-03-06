using System;
using System.Collections.Generic;
using System.Reflection.Emit;
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

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            var lblElse = generator.DefineLabel();
            var lblEnd = generator.DefineLabel();

            bool returnsValue = false;

            //Generamos la condicion
            Condition.GenerateCode(generator, typeBuilder);
            //Comprueba si el resultado es igual a cero (0 => 0)
            CheckIfEqualToZero(generator);
            //Si la condicion no se cumple, saltamos para el 'else'
            generator.Emit(OpCodes.Brfalse, lblElse);
            
            //Si la condicion es verdadera, estamos en el 'then'
            ThenBody.GenerateCode(generator, typeBuilder);

            //TODO: Cambiar por cualquier tipo. Hacer un mapeo de tipos de tiger a tipos de IL
            var result = generator.DeclareLocal(typeof (int));

            //Comprobamos que la expresion retorne algun valor (si tiene tanto 'then' como 'else' y retornan valor)
            if (ElseBody != null && ThenBody.ReturnsValue()) {
                returnsValue = true;
                //Guardamos el valor de retorno en la variable
                GetValueFromStack(generator, result, false);
            }

            //Saltamos al final
            generator.Emit(OpCodes.Br, lblEnd);

            //Empezamos el 'else'
            generator.MarkLabel(lblElse);

            //Si hay un 'else' para generar
            if (ElseBody != null) {
                ElseBody.GenerateCode(generator, typeBuilder);
                if (returnsValue) {
                    GetValueFromStack(generator, result, false);
                }
            }

            generator.MarkLabel(lblEnd);
            //Si debe retornar algun valor
            if (returnsValue) {
                generator.Emit(OpCodes.Ldloc, result);
            }
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
                    if (ThenBody.ReturnType is NilType || ElseBody.ReturnType is NilType)
                    {
                        var nonNilType = ThenBody.ReturnType is NilType ? ElseBody.ReturnType : ThenBody.ReturnType;
                        //Si no pasa que el tipo es 'nil' y puede ser asignado (es decir, si el tipo no es 'nil', o si el tipo es 'nil' y no puede ser asignado)
                        if (!(NilType.CanBeAssignedTo(nonNilType)))
                        {
                            errors.Add(new MessageError(Line, Column,
                                                        "In if-then-else expressions, both 'then' and 'else' expressions must either return no value or be of the same type"));
                        }
                    }
                    else {
                        errors.Add(new MessageError(Line, Column,
                                                    "In if-then-else expressions, both 'then' and 'else' expressions must either return no value or be of the same type"));
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