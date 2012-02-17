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
        public string FieldName { get; set; }

        public FieldAssignmentNode(string fieldName, ExpressionNode body) : base(body) {
            FieldName = fieldName;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
