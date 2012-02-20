using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class ArrayDeclarationNode : TypeDeclarationNode
    {
        /// <summary>
        /// Indica de que tipo es el array (de los definidos en la aplicacion actual, no de Tiger)
        /// Por ejemplo, puede existir un tipo "pepe" que sea un record. Entonces el array podria ser de tipo "pepe"
        /// </summary>
        public string TypeName { get; set; }

        public ArrayDeclarationNode(string name, string typeName) : base(name) {
            TypeName = typeName;
            //TODO: En el chequeo semantico, darle valor a Type en dependencia del tipo de 'typeName'
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}
