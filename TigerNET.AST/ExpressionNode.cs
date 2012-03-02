using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST {
    public abstract class ExpressionNode {
        /// <summary>
        /// Indica si este nodo tiene como ancestro a un 'while/for' y como descendiente a un 'break'
        /// </summary>
        public bool IsBreakable { get; set; }

        /// <summary>
        /// Linea del fichero donde aparece este nodo
        /// </summary>
        public int Line { get; set; }
        /// <summary>
        /// Columna del fichero donde aparece este nodo
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// Indica el tipo de retorno del nodo
        /// </summary>
        public TigerType ReturnType { get; set; }

        public ExpressionNode Parent { get; set; }

        /// <summary>
        /// Comprueba si el nodo actual retorna algun tipo
        /// </summary>
        /// <returns>True si retorna algun tipo. False en otro caso</returns>
        public bool ReturnsValue() {
            return ReturnType != null && !IsBreakable;
        }

        /// <summary>
        /// Genera el codigo asociado a este nodo
        /// </summary>
        public abstract void GenerateCode();

        /// <summary>
        /// Chequea la semantica de este nodo
        /// </summary>
        /// <param name="scope"> </param>
        /// <param name="errors"> </param>
        public abstract void CheckSemantic(Scope scope, IList<Error> errors);
    }
}