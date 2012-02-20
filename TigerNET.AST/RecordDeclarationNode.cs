using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class RecordDeclarationNode : TypeDeclarationNode
    {
        /// <summary>
        /// Indica los campos del record declarado. Ver clase TypeField
        /// </summary>
        public IList<TypeField> Fields { get; set; }

        public RecordDeclarationNode(string name, IList<TypeField> fields) : base(name) {
            Fields = fields;
        }
        public RecordDeclarationNode(string name) : this(name, new List<TypeField>()) {}

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}
