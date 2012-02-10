using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
