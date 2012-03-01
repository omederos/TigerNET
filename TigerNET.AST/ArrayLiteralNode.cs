using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public class ArrayLiteralNode : NonAtomicLiteralNode
    {
        /// <summary>
        /// Cantidad de elementos del array
        /// </summary>
        public ExpressionNode Count { get; set; }
        /// <summary>
        /// Valor inicial que tendran todas las posiciones del array
        /// </summary>
        public ExpressionNode InitialValue { get; set; }

        public ArrayLiteralNode(string name,  ExpressionNode count, ExpressionNode initialValue) : base(name) {
            Count = count;
            InitialValue = initialValue;
            Count.Parent = this;
            InitialValue.Parent = this;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Comprobando que exista el record
            if (!scope.ExistsType(Name))
            {
                errors.Add(new UndefinedTypeError(Line, Column, Name));
                return;
            }

            var type = scope.GetType(Name);
            var array = type as ArrayType;

            //Si el tipo que obtuvimos no es un record...
            if (array == null)
            {
                errors.Add(new UnexpectedTypeError(Line, Column, type, Name));
                return;
            }

            //El tipo de retorno sera el de la definicion del array
            ReturnType = array;

            int errorsCount = errors.Count;
            Count.CheckSemantic(scope, errors);
            //Si hubo errores
            if (errorsCount != errors.Count) {
                return;
            }

            //Si la expresion que da la cantidad de elementos del array no es entera
            ErrorsHelper.CheckIfReturnTypeIsInt(Count, errors, string.Format("The size expression of the array '{0}' must return a value", Name), string.Format("The size expression of the array '{0}' must be an integer", Name));

            errorsCount = errors.Count;
            InitialValue.CheckSemantic(scope, errors);
            if (errorsCount != errors.Count) {
                return;
            }

            //Que el tipo de InitialValue sea igual al tipo definido en el array
            if (array.ElementsType != InitialValue.ReturnType) {
                errors.Add(new UnexpectedTypeError(Line, Column, InitialValue.ReturnType, array.ElementsType));
            }
        }
    }
}
