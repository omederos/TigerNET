using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common.Types;

namespace TigerNET.Common
{
    public class Scope {

        public Scope() {
            DefinedTypes = new Dictionary<string, TigerType>();
            DefinedVariables = new Dictionary<string, TigerType>();
            DefinedCallables = new Dictionary<string, Callable>();
        }

        /// <summary>
        /// Scope padre
        /// </summary>
        public Scope Parent;

        public IDictionary<string, TigerType> DefinedTypes { get; set; }
        public IDictionary<string, TigerType> DefinedVariables { get; set; }
        public IDictionary<string, Callable> DefinedCallables { get; set; }

        /// <summary>
        /// Adiciona un tipo al scope
        /// </summary>
        /// <param name="type"></param>
        public void Add(TigerType type) {
            if (DefinedTypes.ContainsKey(type.Name)) {
                throw new Exception("Ya existe un tipo con ese nombre");
            }
            DefinedTypes.Add(type.Name, type);
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
        /// <returns></returns>
        public bool ExistsType(string name) {
            return DefinedTypes.ContainsKey(name);
        }

        /// <summary>
        /// Comprueba si el nombre especificado ha sido definido
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ExistsDeclaration(string name) {
            //Comprobamos en las variables
            if (DefinedVariables.ContainsKey(name)) {
                return true;
            }
            if (DefinedCallables.ContainsKey(name)) {
                return true;
            }
            //TODO: Hay que comprobar esto?
            return DefinedTypes.ContainsKey(name);
        }
    }
}
