using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace TigerNET.Common
{
    public static class Builders
    {
        /// <summary>
        /// Assembly donde se generara el codigo del programa
        /// </summary>
        public static ModuleBuilder Module {
            get;
            set;
        }
        /// <summary>
        /// Modulo donde se generara todo el codigo del programa
        /// </summary>
        public static AssemblyBuilder Assembly {
            get;
            set;
        }
    }
}
