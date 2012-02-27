using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public abstract class ArithmeticalBinaryOperatorNode : BinaryOperatorNode
    {
        protected ArithmeticalBinaryOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}

        public override void CheckSemantic(Scope scope, IList<Error> errors)
        {
            int errorsCount = 0;
            Left.CheckSemantic(scope, errors);
            Right.CheckSemantic(scope, errors);
            
            //Si ocurrio algun error
            if (errorsCount != errors.Count) {
                return;
            }

            string m1 = "{0} expression does not return any value";
            string m2 = "{0} expression must return an integer";

            //Comprobamos que ambas expresiones son enteras
            ErrorsHelper.CheckIfReturnTypeIsInt(Left, errors, string.Format(m1, "Left"), string.Format(m2, "Left"));
            ErrorsHelper.CheckIfReturnTypeIsInt(Right, errors, string.Format(m1, "Right"), string.Format(m2, "Right"));

            //El tipo de retorno de esta expresion sera entero
            ReturnType = IntegerType.Create();
        }
    }
}
