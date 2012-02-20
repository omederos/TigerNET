using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

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

        public ArrayLiteralNode(string name,  ExpressionNode count, ExpressionNode initialValue) : base(name) {
            Count = count;
            InitialValue = initialValue;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}
