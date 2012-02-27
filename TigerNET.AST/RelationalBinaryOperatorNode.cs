using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public abstract class RelationalBinaryOperatorNode : BinaryOperatorNode
    {
        protected RelationalBinaryOperatorNode(ExpressionNode left, ExpressionNode right, string operatorName) : base(left, right, operatorName) {
            AllowedTypes.Add(typeof(IntegerType));
            AllowedTypes.Add(typeof(StringType));
        }
    }
}
