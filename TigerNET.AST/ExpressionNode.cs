using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.AST.Types;

namespace TigerNET.AST {
    public abstract class ExpressionNode {
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
        public TigerType ReturnType { get; protected set; }

        /// <summary>
        /// Comprueba si el nodo actual retorna algun tipo
        /// </summary>
        /// <returns>True si retorna algun tipo. False en otro caso</returns>
        public bool ReturnsValue() {
            return !(ReturnType is VoidType);
        }

        /// <summary>
        /// Genera el codigo asociado a este nodo
        /// </summary>
        public abstract void GenerateCode();
        /// <summary>
        /// Chequea la semantica de este nodo
        /// </summary>
        public abstract void CheckSemantic();
    }
}