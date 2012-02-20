using System;

namespace TigerNET.Common.Types
{
    public abstract class TigerType {
        protected TigerType(string name) {
            Name = name;
        }

        public string Name { get; set; }

        public static bool operator ==(TigerType type, object x) {
            //Si ambos son null, entonces son iguales
            //Casteamos a object para evitar un StackOverflowException
            if (((object)type) == null) {
                return x == null;
            }
            //Dejamos que cada tipo decida cuando es igual a otro tipo
            return type.Equals(x);
        }

        public static bool operator !=(TigerType type, object x) {
            return !(type == x);
        }
    }
}
