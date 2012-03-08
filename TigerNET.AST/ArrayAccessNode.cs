using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public class ArrayAccessNode : AccessNode
    {
        /// <summary>
        /// Indica a quien se esta accediendo
        /// </summary>
        public ExpressionNode Left { get; set; }
        /// <summary>
        /// Expression con tipo de retorno entero que indica al indice del array que se accedera
        /// </summary>
        public ExpressionNode Index { get; set; }

        public ArrayAccessNode(ExpressionNode left, ExpressionNode index) {
            Left = left;
            Index = index;
            Left.Parent = this;
            Index.Parent = this;
        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            //Generamos la expresion izquierda, que debe retornarnos un array en el tope de la pila
            Left.GenerateCode(generator, typeBuilder);

            //Generamos el codigo del index
            Index.GenerateCode(generator, typeBuilder);

            //Accedemos al array
            generator.Emit(OpCodes.Ldelem, ((ArrayType)(Left.ReturnType)).ElementsType.GetILType());
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Comprobamos que lo de la izquierda sea un record
            //Luego que exista el campo al que estamos accediendo
            int errorsCount = errors.Count;
            //Chequeamos semanticamente la expresion a la que estamos accediendo
            Left.CheckSemantic(scope, errors);
            
            if (errorsCount != errors.Count)
            {
                return;
            }

            //Chequeamos que el indice sea entero
            Index.CheckSemantic(scope, errors);
            ErrorsHelper.CheckIfReturnsValue(Index, errors, "The index expression must return a value");

            if (!(Index.ReturnType is IntegerType)) {
                errors.Add(new UnexpectedTypeError(Line, Column, Index.ReturnType, "int"));
            }

            if (errorsCount != errors.Count) {
                return;
            }

            //Si no retorna valor la expresion
            ErrorsHelper.CheckIfReturnsValue(Left, errors, "The expression being accessed must return a value");
            if (errorsCount != errors.Count)
            {
                return;
            }

            //Si no es un record
            if (!(Left.ReturnType is ArrayType))
            {
                errors.Add(new UnexpectedTypeError(Line, Column, Left.ReturnType, "record"));
                return;
            }

            //Si es un record, comprobamos que exista ese campo...
            var array = (ArrayType)Left.ReturnType;
            //El tipo de retorno, sera el tipo de retorno de los elementos que almacena el array
            ReturnType = array.ElementsType;
        }
    }
}
