using System;
using System.Linq;
using System.Text;

namespace TigerNET.AST.Types
{
    public abstract class TigerType {
        protected TigerType(string name) {
            Name = name;
        }
        protected string Name { get; set; }

        public static bool operator ==(TigerType type, object x) {
            //Si ambos son null, entonces son iguales
            if (type == null) {
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
