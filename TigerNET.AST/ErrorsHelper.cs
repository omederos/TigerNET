using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    /// <summary>
    /// Clase donde estara varios chequeos de errores que son comunes y se repiten en varios nodos
    /// </summary>
    public static class ErrorsHelper
    {
        /// <summary>
        /// Chequea:
        /// - Que la expresion retorne algun tipo
        /// - Que el tipo de retorno de la expresion sea entero
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="errors"></param>
        /// <param name="nonValueMessage">Mensaje a anadir en caso de que no retorne valor la expresion</param>
        /// <param name="nonIntegerMessage">Mensaje a anadir en caso de que no retorne un entero la expresion</param>
        public static void CheckIfReturnTypeIsInt(ExpressionNode expression, IList<Error> errors, string nonValueMessage = null, string nonIntegerMessage = null) {
            int errorsCount = errors.Count;
            //Comprobamos que retorne valor
            CheckIfReturnsValue(expression, errors, nonValueMessage);
            
            if (errorsCount != errors.Count) {
                return;
            }
            //Comprobamos que la expresion retorne un entero
            CheckIfReturnsSpecifiedType(expression, errors, IntegerType.Create());
        }

        private static void CheckIfReturnsSpecifiedType(ExpressionNode expression, IList<Error> errors, TigerType type) {
            if (!(expression.ReturnType == type)) {
                errors.Add(new UnexpectedTypeError(expression.Line, expression.Column, expression.ReturnType,
                                                   IntegerType.Create()));
            }
        }

        public static void CheckIfReturnsValue(ExpressionNode expression, IList<Error> errors, string nonValueMessage = null) {
            //Comprobamos que la expresion retorne algun valor
            if (!expression.ReturnsValue())
            {
                errors.Add(new NonValueReturnError(expression.Line, expression.Column, nonValueMessage));
            }
        }
    }
}
