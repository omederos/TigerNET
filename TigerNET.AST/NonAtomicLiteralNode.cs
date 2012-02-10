using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public abstract class NonAtomicLiteralNode : LiteralNode
    {
        /// <summary>
        /// Name of the record/array we are creating the instance
        /// </summary>
        public string Name { get; set; }
        protected NonAtomicLiteralNode(string name) {
            Name = name;
        }
    }
}
