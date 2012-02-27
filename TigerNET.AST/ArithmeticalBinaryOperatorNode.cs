using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public abstract class ArithmeticalBinaryOperatorNode : BinaryOperatorNode
    {
        protected ArithmeticalBinaryOperatorNode(ExpressionNode left, ExpressionNode right, string operatorName) : base(left, right, operatorName) {
            //Esta expresion solamente acepta tipos enteros
            AllowedTypes.Add(typeof(IntegerType));
        }
    }
}
