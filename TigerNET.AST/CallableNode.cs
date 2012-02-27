using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class CallableNode : InstructionNode
    {
        public string Name { get; set; }
        public IList<ExpressionNode> Parameters { get; set; }

        public CallableNode(string name, IList<ExpressionNode> parameters) {
            Name = name;
            Parameters = parameters;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Comprobamos que la funcion exista
            if (!scope.ExistsCallable(Name)) {
                errors.Add(new UndefinedFunctionError(Line, Column, Name));
                return;
            }

            //Obtenemos la funcion que llamaremos
            var callable = scope.GetCallable(Name);

            if (callable.Fields.Count != Parameters.Count) {
                errors.Add(new MessageError(Line, Column, "The arguments of the call do not match with the parameters of the defined function"));
                //Para poder continuar el chequeo semantico y detectar mas errores en el programa...
                AssignReturnType(scope, callable);
                return;
            }

            for (int i = 0; i < Parameters.Count; i++) {
                var parameter = Parameters[i];
                var field = callable.Fields[i];

                //Chequeamos la semantica del argumento
                parameter.CheckSemantic(scope, errors);

                bool returnsValue = ErrorsHelper.CheckIfReturnsValue(parameter, errors, string.Format("The argument '{0}' must return a value", i));
                if (returnsValue) {
                    //Comprobamos que el tipo de retorno coincida con la definicion de la funcion
                    var definedType = scope.GetType(field.TypeId);
                    var returnType = parameter.ReturnType;
                
                    //Si el tipo de retorno es diferente...
                    if (definedType != returnType) {
                        errors.Add(new MessageError(Line, Column, string.Format("Argument '{0}' is not assignable to parameter type '{1}'", returnType, definedType)));
                    }
                }
            }

            //El tipo de retorno es el tipo de retorno de la funcion al definirse (si es funcion)
            AssignReturnType(scope, callable);

        }

        private void AssignReturnType(Scope scope, Callable callable) {
            if (callable.IsFunction()) {
                ReturnType = scope.GetType(callable.Type);
            }
        }
    }
}
