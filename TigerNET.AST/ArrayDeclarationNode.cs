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
    public class ArrayDeclarationNode : TypeDeclarationNode
    {
        /// <summary>
        /// Indica de que tipo es el array (de los definidos en la aplicacion actual, no de Tiger)
        /// Por ejemplo, puede existir un tipo "pepe" que sea un record. Entonces el array podria ser de tipo "pepe"
        /// </summary>
        public string TypeName { get; set; }

        public ArrayDeclarationNode(string name, string typeName) : base(name) {
            TypeName = typeName;
        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
//            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            int errorsCount = errors.Count;

            //Chequear que el tipo que almacenara el array exista en el scope
            if (!scope.ExistsType(TypeName)) {
                errors.Add(new UndefinedTypeError(Line, Column, TypeName));
            }

            //Si ocurrio algun error
            if (errorsCount != errors.Count) {
                return;
            }

            //Anadimos el nuevo tipo definido al scope
            scope.Add(new ArrayType(Name, scope.GetType(TypeName)), updateIfExists: true);
        }

        public override void UpdateDefinition(Scope scope) {
            //Cogemos el tipo de este 
            var array = (ArrayType) scope.GetType(Name, false);
            array.ElementsType = scope.GetType(TypeName);
        }
    }
}
