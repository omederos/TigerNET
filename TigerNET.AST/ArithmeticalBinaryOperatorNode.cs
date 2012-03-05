using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public abstract class ArithmeticalBinaryOperatorNode : BinaryOperatorNode {
        /// <summary>
        /// Genera el codigo particular de cada operador aritmetico
        /// </summary>
        protected Action<ILGenerator> SpecificCodeGenerator;
        protected ArithmeticalBinaryOperatorNode(ExpressionNode left, ExpressionNode right, string operatorName) : base(left, right, operatorName) {
            //Esta expresion solamente acepta tipos enteros
            AllowedTypes.Add(typeof(IntegerType));
        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            Left.GenerateCode(generator, typeBuilder);
            Right.GenerateCode(generator, typeBuilder);
            SpecificCodeGenerator(generator);
        }
    }
}
