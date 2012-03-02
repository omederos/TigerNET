using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class BreakNode : InstructionNode
    {
        public BreakNode() {
            IsBreakable = true;
        }
        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {

            IList<ExpressionNode> ancestors = new List<ExpressionNode>();
            var parent = Parent;

            bool found = false;

            while (parent != null) {
                //Vamos guardando el camino...
                ancestors.Add(parent);

                //Si encontramos a un ciclo, paramos
                if (parent is LoopNode) {
                    found = true;
                    break;
                }
                
                //Si encontramos una declaracion de funcion/procedimiento, sin haber encontrado un ciclo, no es valido...
                if (parent is CallableDeclarationNode) {
                    var dec = (CallableDeclarationNode) parent;
                    errors.Add(new MessageError(Line, Column, string.Format("'break' expression is inside inside the function/procedure '{0}'", dec.Name)));
                    return;
                }

                parent = parent.Parent;
            }

            //Si llegamos al nodo raiz y no encontramos un ciclo...
            if (!found) {
                errors.Add(new MessageError(Line, Column, string.Format("'break' expression must be inside either a 'while' or 'for' expression")));
                return;
            }

            //Marcamos todos los nodos del camino como 'rompibles'
            foreach (var expr in ancestors) {
                expr.IsBreakable = true;
            }
        }
    }
}
