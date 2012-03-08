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

        protected Scope Scope { get; set; }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            //La idea es:
            //Buscar el FieldBuilder (variable de la clase definida en algun scope)
            //Poner su valor en la pila
            //Si no esta en el scope actual, ir subiendo...

            //Cargamos la instancia actual
            generator.Emit(OpCodes.Ldarg_0);

            var parent = Parent;
            //Voy a ir subiendo de Scopes en Scopes
            while (true) {
                //Mientras el padre no sea de los que define un nuevo scope, sigo subiendo...
                while (!(parent is IScopeDefiner)) {
                    parent = parent.Parent;
                }

                //Ya sabemos que el nodo 'node' define un Scope (es un for, funcion o let-in-end)
                var node = ((IScopeDefiner) parent);
                //Si el scope actual tiene la variable, ya encontramos la instancia que queremos
                if (node.Scope.ExistsVariable(Name, false)) {
                    break;
                }
                
                //Sino, Hacemos una asignacion a la instancia de la clase del padre, para poder seguir subiendo
                generator.Emit(OpCodes.Ldfld, node.ParentInstance);

                parent = parent.Parent;
            }

            //Buscamos el nombre de la variable
            var variable = ((IScopeDefiner)parent).Scope.GetVariable(Name, false);
            //Ponemos su valor en la pila
            generator.Emit(OpCodes.Ldfld, variable.ILVariable);

            //TODO: Ver bien el GetGenerateCodeWhenLeftValue
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            Scope = scope;
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
