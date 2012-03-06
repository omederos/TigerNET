using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST {
    public class GreatherEqualOperatorNode : RelationalBinaryOperatorNode {
        public GreatherEqualOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, ">=") {}
        public GreatherEqualOperatorNode() : this(null, null) {}

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            Left.GenerateCode(generator, typeBuilder);
            Right.GenerateCode(generator, typeBuilder);

            //Si estamos comparando enteros, comparamos por valor
            if (Left.ReturnType is IntegerType)
            {
                //Si es mayor o igual => no es menor
                generator.Emit(OpCodes.Clt);
                Negate(generator);
            }
            //Sino, llamamos al metodo 'String.Compare(string, string)'
            else
            {
                //Devuelve 0 si iguales, 1/-1 si diferentes
                generator.Emit(OpCodes.Call, typeof(string).GetMethod("Compare", new Type[] { typeof(string), typeof(string) }));
                //Cuando hacemos 'x >= y', solo debemos retornar '1' si el valor del Compare fue 0 o 1, y '0' en otro caso
                //Lo que hacemos es comparar que el valor sea mayor que -1
                generator.Emit(OpCodes.Ldc_I4, -1);
                generator.Emit(OpCodes.Cgt);
            }
        }
    }
}