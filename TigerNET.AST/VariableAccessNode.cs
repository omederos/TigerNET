using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class VariableAccessNode : AccessNode
    {
        /// <summary>
        /// Nombre de la variable a la que se esta accediendo
        /// </summary>
        public string Name { get; set; }

        public VariableAccessNode(string name) {
            Name = name;
        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Comprobamos que exista la variable con ese nombre en el scope
            if (!scope.ExistsVariable(Name))
            {
                errors.Add(new UndefinedVariableError(Line, Column, Name));
            }
            else {
                var variable = scope.GetVariable(Name);
                //Asignamos el tipo de retorno
                ReturnType = variable.Type;
            }
        }
    }

    public class UndefinedVariableError : Error {
        public string Name { get; set; }

        public UndefinedVariableError(int line, int column, string name) : base(line, column) {
            Name = name;
        }

        public override string ToString() {
            return string.Format("The variable '{0}' does not exist", Name);
        }
    }
}
