using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class TypeField
    {
        public string Id { get; set; }
        public string TypeId { get; set; }

        public TypeField(string id, string typeId) {
            Id = id;
            TypeId = typeId;
        }
    }
}
