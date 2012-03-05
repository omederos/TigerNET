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
    public class AliasDeclarationNode : TypeDeclarationNode
    {
        /// <summary>
        /// Tipo al que se esta haciendo referencia. En el siguiente ejemplo, AliasType seria 'b' y Name 'a'
        /// type a = b
        /// </summary>
        public string AliasType { get; set; }

        public AliasDeclarationNode(string name, string aliasType) : base(name) {
            AliasType = aliasType;
        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Este metodo no hace nada
            //El chequeo semantico de este nodo se realizara desde fuera)
        }

        public override void UpdateDefinition(Scope scope) {
            scope.DefinedTypes[Name] = scope.GetType(AliasType);
        }
    }
}
