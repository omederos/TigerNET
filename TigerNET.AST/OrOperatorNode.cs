using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class OrOperatorNode : LogicalBinaryOperatorNode
    {
        public OrOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, "|") {}
        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            // Declarando la etiqueta.
            Label end = generator.DefineLabel();

            //Generamos el codigo de la izquierda
            Left.GenerateCode(generator, typeBuilder);

            //Devuelve '1' en la pila si el valor de Left es distinto de cero.
            CheckIfEqualToZero(generator);
            //Guardamos el resultado en una variable, por si se salta no perderlo
            var result = generator.DeclareLocal(typeof (int));
            GetValueFromStack(generator, result);

            //Si fue igual a 1 (true), saltamos hacia el final
            generator.Emit(OpCodes.Brtrue, end);

            //Sino, Generamos el codigo de la derecha
            Right.GenerateCode(generator, typeBuilder);

            //Si llegamos aqui, entonces el resultado sera el del operador derecho (si es 1 => 1)
            CheckIfEqualToZero(generator);
            //Guardamos el resultado en la variable
            GetValueFromStack(generator, result);

            //Haciendo 'backpatch'
            generator.MarkLabel(end);

            //Guardamos el resultado en la pila
            generator.Emit(OpCodes.Ldloc, result);
        }
    }
}
