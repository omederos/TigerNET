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
        /// Chequea si ya existe un tipo con ese nombre en este scope
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="errors"></param>
        protected void CheckIfTypeAlreadyExists(Scope scope, IList<Error> errors) {
            if (scope.ExistsType(Name)) {
                errors.Add(new AlreadyDefinedError(Line, Column, Name));
            }
        }
    }
}
