using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class AndOperatorNode : LogicalBinaryOperatorNode
    {
        public AndOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right, "&") {}
        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            // Declarando la etiqueta.
            Label end = generator.DefineLabel();

            //Generamos el codigo de la izquierda
            Left.GenerateCode(generator, typeBuilder);

            //Devuelve '0' en la pila si el valor de Left es igual a cero.
            CheckIfEqualToZero(generator); 
            //Guardamos el resultado en una variable, por si se salta no perderlo
            var result = GetValueFromStack(generator, typeof (int));
            
            //Si fue igual a cero (falso), saltamos hacia el final
            generator.Emit(OpCodes.Brfalse, end);

            //Sino, Generamos el codigo de la derecha
            Right.GenerateCode(generator, typeBuilder);
            //Guardamos el resultado en la variable
            result = GetValueFromStack(generator, typeof (int));

            //Si llegamos aqui, entonces el resultado sera el del operador derecho (si es 0 => 0)
            CheckIfEqualToZero(generator);

            //Haciendo 'backpatch'
            generator.MarkLabel(end);

            //Guardamos el resultado en la pila
            generator.Emit(OpCodes.Ldloc, result);
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Comprueba si el elemento que esta en el tope de la pila es igual a cero
        /// Deja en la pila 0 si es igual a 0, y un numero mayor que cero si es diferente
        /// </summary>
        /// <param name="generator"></param>
        private void CheckIfEqualToZero(ILGenerator generator) {
            //Metemos el '0' para la pila
            generator.Emit(OpCodes.Ldc_I4_0);
            //Comparamos, y guardamos el resultado en la pila. Si el valor inicial era igual a cero, entonces habra un 1 ahora, sino un 0
            generator.Emit(OpCodes.Ceq);
            //Negamos el valor que esta en la pila, para que si era igual a cero el valor inicial, quede un cero...
            Negate(generator);
        }

        private LocalBuilder GetValueFromStack(ILGenerator generator, Type type, bool peek = true) {
            var result = generator.DeclareLocal(type);
            generator.Emit(OpCodes.Stloc, result);
            if (peek) {
                generator.Emit(OpCodes.Ldloc, result);
            }
            return result;
        }

        private void Negate(ILGenerator generator) {
            generator.Emit(OpCodes.Ldc_I4_0);
            generator.Emit(OpCodes.Ceq);
        }
    }
}
