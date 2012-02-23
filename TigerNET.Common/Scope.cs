using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common.Types;

namespace TigerNET.Common
{
    public class Scope {
        public Scope(Scope parent) {
            DefinedTypes = new Dictionary<string, TigerType>();
            DefinedVariables = new Dictionary<string, TigerType>();
            DefinedCallables = new Dictionary<string, Callable>();
            Parent = parent;
        }

        public Scope() : this(null) {}

        /// <summary>
        /// Scope padre
        /// </summary>
        public Scope Parent { get; set; }

        public IDictionary<string, TigerType> DefinedTypes { get; set; }
        public IDictionary<string, TigerType> DefinedVariables { get; set; }
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
        public void Add(string variable, TigerType type) {
            if (DefinedVariables.ContainsKey(variable)) {
                throw new Exception("La variable ya existe");
            }
            DefinedVariables.Add(variable, type);
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
        /// <returns></returns>
        public bool ExistsDeclaration(string name, bool lookInAncestors = true) {
            return Exists(name,
                          (x, scope) =>
                          scope.DefinedVariables.ContainsKey(x) || scope.DefinedCallables.ContainsKey(x), lookInAncestors);
        }
    }
}
