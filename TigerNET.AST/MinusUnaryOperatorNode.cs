using System;
using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public class MinusUnaryOperatorNode : UnaryOperatorNode
    {
        public MinusUnaryOperatorNode(ExpressionNode body) : base(body) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Chequeamos la semantica del cuerpo
            int errorsCount = errors.Count;
            Body.CheckSemantic(scope, errors);
            if (errorsCount != errors.Count) {
                return;
            }

            //Comprobamos que la expresion retorne algun valor, y que sea entero
            ErrorsHelper.CheckIfReturnTypeIsInt(Body, errors);

            //El tipo de retorno de esta expresion es entero
            ReturnType = IntegerType.Create();
        }
    }
}
