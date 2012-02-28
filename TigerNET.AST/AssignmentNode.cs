using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        public override void GenerateCode() {
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
            
            //Si el tipo de retorno es diferente
            //TODO: Aceptar nil si es array, record o string!
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
