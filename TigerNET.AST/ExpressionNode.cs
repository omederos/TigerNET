using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST {
    public abstract class ExpressionNode {
        /// <summary>
        /// Indica si este nodo tiene como ancestro a un 'while/for' y como descendiente a un 'break'
        /// </summary>
        public bool IsBreakable { get; set; }

        /// <summary>
        /// Linea del fichero donde aparece este nodo
        /// </summary>
        public int Line { get; set; }
        /// <summary>
        /// Columna del fichero donde aparece este nodo
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// Indica el tipo de retorno del nodo
        /// </summary>
        public TigerType ReturnType { get; set; }

        public ExpressionNode Parent { get; set; }

        /// <summary>
        /// Comprueba si el nodo actual retorna algun tipo
        /// </summary>
        /// <returns>True si retorna algun tipo. False en otro caso</returns>
        public bool ReturnsValue() {
            return ReturnType != null && !IsBreakable;
        }

        /// <summary>
        /// Genera el codigo asociado a este nodo
        /// </summary>
        /// <param name="generator">El ILGenerator del metodo donde se debe generar el codigo del nodo actual</param>
        /// <param name="typeBuilder">El tipo (clase) al que pertenece el codigo que se estara generando</param>
        public abstract void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder);

        /// <summary>
        /// Chequea la semantica de este nodo
        /// </summary>
        /// <param name="scope"> </param>
        /// <param name="errors"> </param>
        public abstract void CheckSemantic(Scope scope, IList<Error> errors);


        #region Metodos utiles para la generacion de codigo
        
        /// <summary>
        /// Comprueba si el elemento que esta en el tope de la pila es igual a cero
        /// Deja en la pila 0 si es igual a 0, y un numero mayor que cero si es diferente
        /// </summary>
        /// <param name="generator"></param>
        protected void CheckIfEqualToZero(ILGenerator generator)
        {
            //Metemos el '0' para la pila
            generator.Emit(OpCodes.Ldc_I4_0);
            //Comparamos, y guardamos el resultado en la pila. Si el valor inicial era igual a cero, entonces habra un 1 ahora, sino un 0
            generator.Emit(OpCodes.Ceq);
            //Negamos el valor que esta en la pila, para que si era igual a cero el valor inicial, quede un cero...
            Negate(generator);
        }

        /// <summary>
        /// Guarda el valor en el tope de la pila en una variable y devuelve esa variable. Si se especifica, lo vuelve a meter en la pila (hace un 'peek')
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="type"></param>
        /// <param name="peek"></param>
        /// <returns></returns>
        protected LocalBuilder GetValueFromStack(ILGenerator generator, Type type, bool peek = true)
        {
            var result = generator.DeclareLocal(type);
            generator.Emit(OpCodes.Stloc, result);
            if (peek)
            {
                generator.Emit(OpCodes.Ldloc, result);
            }
            return result;
        }

        /// <summary>
        /// Niega el valor que esta en el tope de la pila.
        /// Si era 0 => Un numero mayor que 0
        /// Si era 1 => 0
        /// </summary>
        /// <param name="generator"></param>
        protected void Negate(ILGenerator generator)
        {
            generator.Emit(OpCodes.Ldc_I4_0);
            generator.Emit(OpCodes.Ceq);
        }
        #endregion
    }
}