﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    /// <summary>
    /// Nodo que se usa para asignarle el valor de una expression a un campo de un record, valor de array, o variable ya existente
    /// </summary>
    public class AssignmentNode : AssignmentBaseNode
    {
        /// <summary>
        /// Nodo al que le estamos asignando el valor. Puede ser una variable, posicion de array, campo de un record..
        /// </summary>
        public AccessNode Left { get; set; }

        public AssignmentNode(AccessNode left, ExpressionNode body) : base(body) {
            Left = left;
            Left.Parent = this;
        }

        public override void GenerateCode(
            ILGenerator generator, TypeBuilder typeBuilder) {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            int errorsCount = errors.Count;
            //Comprobamos que este correctamente Left
            Left.CheckSemantic(scope, errors);
            //Comprobamos que este correctamente Body
            Body.CheckSemantic(scope, errors);

            //Si ocurrio algun error, paramos
            if (errorsCount != errors.Count) {
                return;
            }

            //Comprobamos que ambas expresiones retornen valor...
            ErrorsHelper.CheckIfReturnsValue(Left, errors,
                                             "The expression that is being assigned a value must return a value");
            ErrorsHelper.CheckIfReturnsValue(Body, errors,
                                 "The expression to be assigned must return a value");
            if (errorsCount != errors.Count) {
                return;
            }

            //Si 'Left' es una variable, y es de solo lectura => Error!
            if (Left is VariableAccessNode) {
                var varAccessNode = (VariableAccessNode) Left;
                //Buscamos la variable a la que estamos accediendo en el scope
                var variable = scope.GetVariable(varAccessNode.Name);
                if (variable.ReadOnly) {
                    errors.Add(new MessageError(Line, Column, string.Format("Cannot assign value to read-only variable '{0}'", variable.Name)));
                }
            }
            
            //Si el tipo de retorno es diferente
            if (Body.ReturnType != Left.ReturnType) {
                //Si se esta asignando nil, comprobar que el tipo lo permita
                if (!(Body.ReturnType is NilType) || !NilType.CanBeAssignedTo(Left.ReturnType))
                {
                    errors.Add(new UnexpectedTypeError(Line, Column, Body.ReturnType, Left.ReturnType));
                }
            }

            //Esta expresion no retorna valor
        }
    }
}
