using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common.Types;

namespace TigerNET.Common
{
    public class Scope {
        /// <summary>
        /// Comprueba si el nombre de la funcion/parametro especificado es invalido o no
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsCallableNameInvalid(string name) {
            return Exists(name, (x, scope) => scope.InvalidCallableNames.Contains(x));
        }/// <summary>
        
        /// Comprueba si el nombre del tipo especificado es invalido o no
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsTypeNameInvalid(string name) {
            return Exists(name, (x, scope) => scope.InvalidTypeNames.Contains(x));
        }

        internal IList<string> InvalidCallableNames { get; set; }
        internal IList<string> InvalidTypeNames { get; set; }

        public Scope(Scope parent) {
            DefinedTypes = new Dictionary<string, TigerType>();
            DefinedVariables = new Dictionary<string, Variable>();
            DefinedCallables = new Dictionary<string, Callable>();
            Parent = parent;

            InvalidCallableNames = new List<string>();
            //TODO: Eliminar, y subirlo para el scope padre
            InvalidTypeNames = new List<string> {"string", "int"};

            
        }

        public Scope() : this(null) {}

        /// <summary>
        /// Scope padre
        /// </summary>
        public Scope Parent { get; set; }

        public IDictionary<string, TigerType> DefinedTypes { get; set; }
        public IDictionary<string, Variable> DefinedVariables { get; set; }
        public IDictionary<string, Callable> DefinedCallables { get; set; }

        /// <summary>
        /// Devuelve el tipo dado el identificador
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lookInAncestors">Indica si se debe buscar en los scopes padres</param>
        /// <returns></returns>
        public TigerType GetType(string name, bool lookInAncestors = true) {
            if (!ExistsType(name, lookInAncestors)) {
                throw new Exception(string.Format("El tipo {0} no existe", name));
            }
            var s = this;
            while (s != null) {
                if (s.DefinedTypes.ContainsKey(name)) {
                    return s.DefinedTypes[name];
                }
                if (!lookInAncestors) {
                    break;
                }
                s = s.Parent;
            }

            throw new Exception(string.Format("El tipo {0} no existe", name));
        }

        /// <summary>
        /// Devuelve la funcion/procedimiento dado su nombre
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lookInAncestors">Indica si se debe buscar en los scopes padres</param>
        /// <returns></returns>
        public Callable GetCallable(string name, bool lookInAncestors = true)
        {
            if (!ExistsCallable(name, lookInAncestors))
            {
                throw new Exception(string.Format("La funcion/procedimiento {0} no existe", name));
            }
            var s = this;
            while (s != null)
            {
                if (s.DefinedCallables.ContainsKey(name))
                {
                    return s.DefinedCallables[name];
                }
                if (!lookInAncestors)
                {
                    break;
                }
                s = s.Parent;
            }

            throw new Exception(string.Format("La funcion/procedimiento {0} no existe", name));
        }

        /// <summary>
        /// Comprueba si existe una funcion o procedimiento
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lookInAncestors">Especifica si se debe buscar en el scope padre (recursivamente) o no</param>
        /// <returns></returns>
        public bool ExistsCallable(string name, bool lookInAncestors = true) {
            return Exists(name, (n, scope) => scope.DefinedCallables.ContainsKey(name), lookInAncestors);
        }

        /// <summary>
        /// Adiciona un tipo al scope
        /// </summary>
        /// <param name="type">Tipo que se anadira al scope</param>
        /// <param name="name">Parametro opcional que especifica con que nombre se anadira al scope. Si es null, se utiliza type.Name</param>
        /// <param name="updateIfExists">Especifica si se debe actualizar el tipo en caso de que este exista en el scope</param>
        public void Add(TigerType type, string name = null, bool updateIfExists = false) {
            var nameToAdd = name ?? type.Name;
            if (DefinedTypes.ContainsKey(nameToAdd))
            {
                if (updateIfExists)
                {
                    DefinedTypes[nameToAdd] = type;
                }
                else { throw new Exception("Ya existe un tipo con ese nombre"); }
            }
            else {
                DefinedTypes.Add(nameToAdd, type);
            }
        }

        /// <summary>
        /// Anade una nueva variable al scope
        /// </summary>
        /// <param name="variable">Variable a anadir</param>
        /// <param name="type">Tipo que almacenara esa variable</param>
        /// <param name="readOnly">Especifica si la variable sera de solo lectura o no (eg. la del 'for')</param>
        public void Add(string variable, TigerType type, bool readOnly = false) {
            if (DefinedVariables.ContainsKey(variable)) {
                throw new Exception("La variable ya existe");
            }
            DefinedVariables.Add(variable, new Variable(variable, type, readOnly));
        }

        /// <summary>
        /// Anade una nueva funcion o procedimiento al scope
        /// </summary>
        /// <param name="c"></param>
        public void AddCallable(Callable c) {
            if (DefinedCallables.ContainsKey(c.Name))
            {
                throw new Exception("El procedimiento o funcion ya existe");
            }
            DefinedCallables.Add(c.Name, c);
        }

        /// <summary>
        /// Comprueba si existe un tipo
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lookInAncestors">Especifica si se debe buscar en el scope padre (recursivamente) o no</param>
        /// <returns></returns>
        public bool ExistsType(string name, bool lookInAncestors = true) {
            return Exists(name, (x, scope) => scope.DefinedTypes.ContainsKey(x), lookInAncestors);
        }

        private bool Exists(string name, Func<string, Scope, bool> findFunc, bool lookInAncestors = true) {
            if (!lookInAncestors) {
                return findFunc(name, this);
            }
            var s = this;
            do {
                if (findFunc(name, s)) {
                    return true;
                }
                s = s.Parent;
            } while (s != null);

            return false;
        }

        /// <summary>
        /// Comprueba si el nombre especificado ha sido definido
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lookInAncestors"></param>
        /// <returns></returns>
        public bool ExistsVariableOrCallable(string name, bool lookInAncestors = true) {
            return Exists(name,
                          (x, scope) =>
                          scope.DefinedVariables.ContainsKey(x) || scope.DefinedCallables.ContainsKey(x), lookInAncestors);
        }

        /// <summary>
        /// Comprueba si existe una variable definida con el nombre especificado
        /// </summary>
        /// <param name="variableName"></param>
        /// <param name="lookInAncestors"></param>
        /// <returns></returns>
        public bool ExistsVariable(string variableName, bool lookInAncestors = true) {
            return Exists(variableName, (x, scope) => scope.DefinedVariables.ContainsKey(x), lookInAncestors);
        }

        public Variable GetVariable(string name, bool lookInAncestors = true) {
            if (!ExistsVariable(name, lookInAncestors))
            {
                throw new Exception(string.Format("La variable {0} no existe", name));
            }
            var s = this;
            while (s != null)
            {
                if (s.DefinedVariables.ContainsKey(name))
                {
                    return s.DefinedVariables[name];
                }
                if (!lookInAncestors)
                {
                    break;
                }
                s = s.Parent;
            }

            throw new Exception(string.Format("La variable {0} no existe", name));
        }
    }
}
