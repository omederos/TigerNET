using System;

namespace TigerNET.Common.Types
{
    public abstract class TigerType : IUniqueNamed {
        protected TigerType(string name, Guid guid) {
            Name = name;
            Id = guid.ToCleanString();
        }

        public string Name { get; set; }
        
        /// <summary>
        /// Hash que identifica al tipo (para ser usado en Arrays/Records principalmente)
        /// </summary>
        public string Id { get; set; }

        public static bool operator ==(TigerType type, object x) {
            //Si ambos son null, entonces son iguales
            //Casteamos a object para evitar un StackOverflowException
            if (((object)type) == null) {
                return x == null;
            }

            var xx = x as TigerType;
            if (xx == null) {
                return false;
            }

            //Comparamos por los Id de ambos tipos
            return xx.Id == type.Id;
        }

        public static bool operator !=(TigerType type, object x) {
            return !(type == x);
        }

        public abstract Type GetILType();
        
        public string GetName() {
            return Id;
        }
    }
}
