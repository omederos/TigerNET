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

            //Comprobamos que la expresion retorne un entero...
            if (!(Body.ReturnType is IntegerType)) {
                errors.Add(new UnexpectedTypeError(Line, Column, IntegerType.Create(), Body.ReturnType));
            }

            //El tipo de retorno de esta expresion es entero
            ReturnType = IntegerType.Create();
        }
    }
}
