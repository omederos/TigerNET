﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class CallableDeclarationNode : DeclarationNode {
        /// <summary>
        /// Campos de la funcion/procedimiento
        /// </summary>
        public IList<TypeField> Fields { get; set; }
        /// <summary>
        /// En caso de ser una funcion, representa el tipo (dentro del programa) de esta
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// El cuerpo de la funcion
        /// </summary>
        public ExpressionNode Body { get; set; }

        public CallableDeclarationNode(string name, IList<TypeField> fields, ExpressionNode body, string type = null) : base(name) {
            Fields = fields;
            Type = type;
            Body = body;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {

            int errorsCount = errors.Count;
            IList<string> parameters = new List<string>();
            //Creamos el scope de la nueva funcion
            var scopeFunction = new Scope(scope);

            //Chequeamos los parametros...
            foreach (var field in Fields) {
                bool errorInField = false;
                //Comprobar que el tipo exista
                if (!scope.ExistsType(field.TypeId)) {
                    errors.Add(new UndefinedTypeError(Line, Column, field.TypeId));
                    errorInField = true;
                }
                //Si existe un parametro con ese mismo nombre
                if (parameters.Contains(field.Id))
                {
                    errors.Add(new DuplicateParameterError(Line, Column, field.Id));
                    errorInField = true;
                }
                else {
                    parameters.Add(field.Id);
                }

                //Anadimos este parametro al scope de la funcion
                if (!errorInField) {
                    scopeFunction.Add(field.Id, scope.DefinedTypes[field.TypeId]);
                }
            }

            //Si me especificaron un tipo y este no existe
            if (Type != null && !scope.ExistsType(Type)) {
                errors.Add(new UndefinedTypeError(Line, Column, Type));
            }

            //Si hubo errores en los parametros no seguimos o en la definicion explicita del tipo de la funcion...
            if (errorsCount != errors.Count) {
                return;
            }

            //Si estamos aqui es porque no hubo ningun error anteriormente

            //Chequeamos el cuerpo de la funcion/procedimiento (con las nuevas variables anadidas al scope)
            Body.CheckSemantic(scopeFunction, errors);

            //Si hubo algun error, paramos
            if (errorsCount != errors.Count) {
                return;
            }

            errorsCount = errors.Count;
            //Si me especificaron el tipo
            if (Type != null) {
                var type = scope.DefinedTypes[Type];
                
                //Si la expresion no retorna ningun valor
                if (!Body.ReturnsValue()) {
                    errors.Add(new NonValueAssignmentError(Line, Column, Name));
                }
                //Comprobamos que el tipo del cuerpo de la funcion sea igual al especificado
                else if (type != Body.ReturnType) {
                    errors.Add(new NotMatchingTypesError(Line, Column, type, Body.ReturnType));
                }
                //TODO: Es posible retornar Nil aqui?
            }

            //Si no hubo ningun problema...
            if (errorsCount == errors.Count) {
                scope.AddCallable(new Callable(Name, Fields, Type));
            }
        }
    }
}
