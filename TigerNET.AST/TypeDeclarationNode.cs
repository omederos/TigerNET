using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public abstract class TypeDeclarationNode : DeclarationNode
    {
        protected TypeDeclarationNode(string name) : base(name) {}

        /// <summary>
        /// Tipo asociado al tipo que estan declarando.
        /// Ejemplo, si me declaran un record, el tipo asociado es RecordType
        /// </summary>
        public TigerType Type { get; set; }

        /// <summary>
        /// Chequea si ya existe una definicion con ese nombre en este scope (y padres)
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="errors"></param>
        protected void CheckIfMemberAlreadyExists(Scope scope, IList<Error> errors) {
            if (scope.ExistsDeclaration(Name)) {
                errors.Add(new AlreadyDefinedError(Line, Column, Name));
            }
        }
    }
}
