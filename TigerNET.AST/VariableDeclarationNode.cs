using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST {
    public class VariableDeclarationNode : DeclarationNode {
        public ExpressionNode Body { get; set; }
        public string Type { get; set; }

        public VariableDeclarationNode(string name, ExpressionNode body, string type = null) : base(name) {
            Body = body;
            Type = type;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Si ya se definio ese nombre anteriormente (en este scope solamente)
            if (scope.ExistsDeclaration(Name, false)) {
                errors.Add(new AlreadyDefinedError(Line, Column, Name));
                return;
            }

            int errorsCount = errors.Count;
            
            //Chequeamos la semantica de la expresion que estamos asignando
            Body.CheckSemantic(scope, errors);

            //Si hubo errores en el chequeo semantico...
            if (errorsCount != errors.Count) {
                return;
            }

            errorsCount = errors.Count;

            //Si me especificaron el tipo
            TigerType resultType = null;
            
            if (Type != null) {
                //Si el tipo no existe
                if (!scope.ExistsType(Type)) {
                    errors.Add(new UndefinedTypeError(Line, Column, Type));
                }
                
                //Guardamos el tipo que debe almacenar esta variable (segun su definicion)
                resultType = scope.GetType(Type);

                //Si el tipo de retorno de la expresion es diferente al del especificado explicitamente
                if (Body.ReturnType != resultType) {
                    //Debemos chequear el caso se este asignando Nil a un tipo que lo permita
                    if (!(Body.ReturnType is NilType) || !NilType.CanBeAssignedTo(resultType)) {
                        errors.Add(new NotMatchingTypesError(Line, Column, resultType, Body.ReturnType));
                    }
                    
                }
            }
            //Si no me especificaron el tipo
            else {
                //Si no tiene tipo de retorno
                if (!Body.ReturnsValue()) {
                    errors.Add(new NonValueAssignmentError(Line, Column, Name));
                }
                //Si el tipo de retorno es Nil, no es valido pues no se puede inferir el tipo de la variable que estamos declarando
                else if (Body.ReturnType is NilType) {
                    errors.Add(new NilAssignmentError(Line, Column, Name));
                }
            }

            //Si no hubo ningun error...
            if (errorsCount == errors.Count) {
                //Finalmente anadimos la variable declarada al scope
                scope.Add(Name, Body.ReturnType is NilType ? resultType : Body.ReturnType);
            }

            
        }
    }
}