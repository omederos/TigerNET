using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    /// <summary>
    /// Clase que representa la asignacion de un campo de un record cuando se inicializa. Ejemplo:
    /// var p := persona {nombre="Oscar", asignatura="Compilacion"}
    /// </summary>
    public class FieldAssignmentNode : AssignmentBaseNode
    {
        public FieldAssignmentNode(AccessNode field, ExpressionNode body) : base(field, body) {
            //Nota: Cuando se le esta dando valor al campo de un record, realmente no es un 'AccessNode', sino un string que identifique el nombre
            //del campo, pero esto lo comprobamos desde el Parser en ANTLR, es decir, garantizamos que lo que haya en 'field' sea un simple identificador
            //Hice esto para poder usar la herencia y subir t odo para AssignmentBaseNode y de esta forma tratar a FieldAssignmentNode y 
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
