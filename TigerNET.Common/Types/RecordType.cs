using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TigerNET.AST;

namespace TigerNET.Common.Types {
    public class RecordType : TigerType
    {
        public RecordType(string name, Fields fields) : base(name, Guid.NewGuid()) {
            Fields = fields;
        }

        public Fields Fields { get; set; }
        
        /// <summary>
        /// Representa la clase equivalente en IL a este record
        /// </summary>
        public TypeBuilder ILRecord { get; set; }


        /// <summary>
        /// Listado de campos que fueron asignado a la clase 'ILRecord'
        /// Llaves: nombre
        /// Valor: FieldBuilder (tipo del campo en la clase)
        /// </summary>
        public IDictionary<string, FieldBuilder> FieldsInClass { get; set; }

        /// <summary>
        /// Constructor de la clase de este record
        /// </summary>
        public ConstructorBuilder Constructor { get; set; }

        public override string ToString() {
            return string.Format("[Record] ({0}) ({1})", Name, Id);
        }

        public override Type GetILType() {
            throw new NotImplementedException();
        }
    }
}