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

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            //Generamos la expresion del valor inicial que tendran los elementos del array
            InitialValue.GenerateCode(generator, typeBuilder);
            //Guardamos el valor en una variable para poder sacarlo de la pila
            var initialValue = generator.DeclareLocal(InitialValue.ReturnType.GetILType());
            generator.Emit(OpCodes.Stloc, initialValue);

            //Generamos la expresion de la cantidad de elementos del array
            Count.GenerateCode(generator, typeBuilder);

            //Guardamos el 'count' en la variable
            var count = generator.DeclareLocal(typeof (int));
            generator.Emit(OpCodes.Stloc, count);

            //Creamos una instancia del array del tipo de 'InitialValue'
            generator.Emit(OpCodes.Ldloc, count); //La cantidad de elementos que tendra el array
            generator.Emit(OpCodes.Newarr, InitialValue.ReturnType.GetILType()); //Creamos la instancia

            //Guardamos el array en esta variable
            var array = generator.DeclareLocal(ReturnType.GetILType());
            generator.Emit(OpCodes.Stloc, array);

            Label lblStart = generator.DefineLabel();
            Label lblEnd = generator.DefineLabel();

            //Declaramos la variable 'i' que se usara como indice y le asignamos el valor '0'
            var index = generator.DeclareLocal(typeof (int));
            generator.Emit(OpCodes.Ldc_I4, 0);
            generator.Emit(OpCodes.Stloc, index);

            //Comienzo del ciclo
            generator.MarkLabel(lblStart);

            //Si 'index' ya es igual al 'count' => Saltar al final
            generator.Emit(OpCodes.Ldloc, index);
            generator.Emit(OpCodes.Ldloc, count);
            generator.Emit(OpCodes.Beq, lblEnd);

            //Si 'index' aun es menor que 'count', ponemos el valor en esa posicion del array
            generator.Emit(OpCodes.Ldloc, array); //Ponemos al array en la pila
            generator.Emit(OpCodes.Ldloc, index); //Ponemos el index
            generator.Emit(OpCodes.Ldloc, initialValue); //Ponemos el valor a asignar
            generator.Emit(OpCodes.Stelem, InitialValue.ReturnType.GetILType()); //Hacemos la asignacion

            //Incrementamos 'index'
            generator.Emit(OpCodes.Ldc_I4, 1); //Anadimos '1'
            generator.Emit(OpCodes.Ldloc, index); //Anadimos a la pila a 'index'
            generator.Emit(OpCodes.Add); //Efectuamos la suma
            generator.Emit(OpCodes.Stloc, index); //Se la asignamos a 'index'

            //Saltamos al inicio
            generator.Emit(OpCodes.Br, lblStart);

            //Ponemos la etiqueta 'end'
            generator.MarkLabel(lblEnd);

            //Guardamos el array en la pila
            generator.Emit(OpCodes.Ldloc, array);
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
                //Si no pasa que el tipo es 'nil' y puede ser asignado (es decir, si el tipo no es 'nil', o si el tipo es 'nil' y no puede ser asignado
                if (!(InitialValue.ReturnType is NilType && NilType.CanBeAssignedTo(array.ElementsType))) {
                    errors.Add(new UnexpectedTypeError(Line, Column, InitialValue.ReturnType, array.ElementsType));
                }
            }
        }
    }
}
