using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace TigerNET.AST
{
    public abstract class AssignmentBaseNode : ExpressionNode
    {
        /// <summary>
        /// Valor que guardaremos
        /// </summary>
        public ExpressionNode Body { get; set; }


        protected AssignmentBaseNode(ExpressionNode body ) {
            Body = body;
            Body.Parent = this;
        }

        /// <summary>
        /// Codigo comun para las asignaciones (tanto de campos en los records como de lvalue := ___)
        /// </summary>
        /// <param name="generator"></param>
        /// <param name="typeBuilder"></param>
        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            //Generamos la expresion que vamos a asignar y dejamos el valor en el tope de la pila
            Body.GenerateCode(generator, typeBuilder);
        }
    }
}
