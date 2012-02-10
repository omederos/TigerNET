using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.AST.Types;

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
    }
}
