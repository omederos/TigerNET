using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    /// <summary>
    /// Clase que representa la asignacion de un campo de un record cuando se inicializa. Ejemplo:
    /// En
    /// var p := persona {nombre="Oscar", asignatura="Compilacion"}
    /// los FieldAssignmentNodes serian:
    /// nombre="Oscar (FieldName: nombre) (Body: "Oscar")
    /// asignatura="Compilacion" (FieldName: asignatura) (Body: "Compilacion")
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

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}
