using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TigerNET.AST;

namespace TigerNET.Common {
    public class Callable : IUniqueNamed {
        private string _id;
        public string Name { get; set; }
        public IList<TypeField> Fields { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// Representa la clase en IL asociada a esta funcion/procedimiento
        /// </summary>
        public TypeBuilder ILCallable { get; set; }
        /// <summary>
        /// Campos que tendra la clase asociada a esta funcion
        /// </summary>
        public IDictionary<string, FieldBuilder> FieldsInClass { get; set; }
        /// <summary>
        /// Constructor de la clase asociada a esta funcion
        /// </summary>
        public ConstructorBuilder Constructor { get; set; }
        /// <summary>
        /// Metodo principal de la funcion
        /// </summary>
        public MethodBuilder Method { get; set; }

        public Callable(string name, IList<TypeField> fields, string type = null) {
            Name = name;
            Fields = fields;
            Type = type;
            _id = Guid.NewGuid().ToCleanString();
        }

        public bool IsFunction() {
            return Type != null;
        }

        public string GetName() {
            return _id;
        }
    }
}