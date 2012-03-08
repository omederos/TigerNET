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
    public class RecordAccessNode : AccessNode
    {
        /// <summary>
        /// Indica a quien se esta accediendo. Siempre conoceremos a quien se esta accediendo debido a la estructura
        /// de la gramatica, es decir, para llegar a instanciar esta clase (RecordAccessNode), es porque ya fue instanciada de antemano 'Left', lo que puede
        /// ser una variable (VariableAccessNode), un record (RecordAccessNode), una expresion cualquiera (segun los cambios hechos en las especificaciones del proyecto), etc.
        /// </summary>
        public ExpressionNode Left { get; set; }
        /// <summary>
        /// Campo al que se esta accediendo
        /// </summary>
        public string FieldName { get; set; }

        public RecordAccessNode(ExpressionNode left, string fieldName) {
            Left = left;
            FieldName = fieldName;
            Left.Parent = this;
        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            //Generamos el codigo de la expresion de la izquierda. Me dejara una referencia a un record en la pila
            Left.GenerateCode(generator, typeBuilder);

            //Cogemos el FieldBuilder al que queremos acceder (buscandolo en el objeto de tipo RecordType que es donde guardamos la info de cada record)
            var fieldToAccessBuilder = ((RecordType) (Left.ReturnType)).FieldsInClass[FieldName];
            generator.Emit(OpCodes.Ldfld, fieldToAccessBuilder); //Dejamos en el tope de la pila el valor resultante de acceder al record

            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Comprobamos que lo de la izquierda sea un record
            //Luego que exista el campo al que estamos accediendo
            int errorsCount = errors.Count;
            //Chequeamos semanticamente la expresion a la que estamos accediendo
            Left.CheckSemantic(scope, errors);
            if (errorsCount != errors.Count) {
                return;
            }

            //Si no retorna valor la expresion
            ErrorsHelper.CheckIfReturnsValue(Left, errors, "The expression being accessed must return a value");
            if (errorsCount != errors.Count) {
                return;
            }

            //Si no es un record
            if (!(Left.ReturnType is RecordType)) {
                errors.Add(new UnexpectedTypeError(Line, Column, Left.ReturnType, "record"));
                return;
            }

            //Si es un record, comprobamos que exista ese campo...
            var record = (RecordType) Left.ReturnType;
            if (!record.Fields.ContainsKey(FieldName))
            {
                errors.Add(new FieldNotFoundError(Line, Column, record.Name, FieldName));
            }
            else {
                //El tipo de retorno sera el mismo que el del campo del record
                ReturnType = record.Fields[FieldName];
            }
        }
    }
}
