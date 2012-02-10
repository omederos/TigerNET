using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class ArrayLiteralNode : NonAtomicLiteralNode
    {
        /// <summary>
        /// Cantidad de elementos del array
        /// </summary>
        public ExpressionNode Count { get; set; }
        /// <summary>
        /// Valor inicial que tendran todas las posiciones del array
        /// </summary>
        public ExpressionNode InitialValue { get; set; }

        public ArrayLiteralNode(string name,  ExpressionNode index, ExpressionNode initialValue) : base(name) {
            Count = index;
            InitialValue = initialValue;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
