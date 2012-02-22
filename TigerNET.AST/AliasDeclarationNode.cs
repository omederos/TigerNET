using System;
using System.Collections.Generic;
using System.Linq;
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

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Comprobar que el tipo exista
            int errorsCount = errors.Count;
            
            //Chequeamos que no exista ningun tipo con el nombre que le vamos a dar al alias
            CheckIfTypeAlreadyExists(scope, errors);

            //Chequeamos que exista el tipo del que vamos a crear el alias
            if (!scope.ExistsType(AliasType)) {
                errors.Add(new UndefinedTypeError(Line, Column, AliasType));
            }

            //Si ocurrio algun error
            if (errorsCount != errors.Count) {
                return;
            }
            
            //Si no hubo errores, anadir este nuevo tipo
            var type = scope.DefinedTypes[AliasType];
            //Anadimos ese mismo tipo al scope pero con otro nombre
            scope.Add(type, Name);

        }

        public override void UpdateDefinition(Scope scope) {
            throw new NotImplementedException();
        }
    }
}
