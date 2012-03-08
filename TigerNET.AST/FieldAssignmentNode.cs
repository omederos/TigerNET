using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// nombre="Oscar" (FieldName: nombre) (Body: "Oscar")
    /// asignatura="Compilacion" (FieldName: asignatura) (Body: "Compilacion")
    /// </summary>
    public class FieldAssignmentNode : AssignmentBaseNode
    {
        public string FieldName { get; set; }

        public FieldAssignmentNode(string fieldName, ExpressionNode body) : base(body) {
            FieldName = fieldName;
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Chequeamos la semantica del cuerpo de la asignacion
            //Otro nodo se encargara de comprobar que el nombre del campo sea correcto, el tipo, etc
            Body.CheckSemantic(scope, errors);

            ErrorsHelper.CheckIfReturnsValue(Body, errors,
                                                 string.Format(
                                                     "The expression to be assigned to the field '{0}' must return a value",
                                                     FieldName));
            ReturnType = Body.ReturnType;
        }
    }
}
