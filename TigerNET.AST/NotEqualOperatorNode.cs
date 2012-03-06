using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST {
    public class NotEqualOperatorNode : RelationalBinaryOperatorNode {
        public NotEqualOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, "<>") {
            AllowedTypes.Add(typeof(RecordType));
            AllowedTypes.Add(typeof(ArrayType));
        }

        public NotEqualOperatorNode() : this(null, null) {}

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            Left.GenerateCode(generator, typeBuilder);
            Right.GenerateCode(generator, typeBuilder);

            //Si estamos comparando enteros, comparamos por valor
            if (Left.ReturnType is IntegerType)
            {
                generator.Emit(OpCodes.Ceq);
                //Si eran diferentes, dejara un cero en la pila, luego lo unico que tenemos que hacer es negar ese valor
                Negate(generator);
            }
            //Sino, comparamos por referencia
            else
            {
                //Llamamos a 'ReferenceEquals'
                generator.Emit(OpCodes.Call, typeof(Object).GetMethod("ReferenceEquals", new Type[] { typeof(object), typeof(object) }));
                //Si eran diferentes, dejara un cero en la pila, luego lo unico que tenemos que hacer es negar ese valor
                Negate(generator);
            }
        }
    }
}