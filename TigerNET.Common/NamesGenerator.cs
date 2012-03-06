using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.Common
{
    public static class NamesGenerator
    {
        /// <summary>
        /// Metodo que genera nombres unicos y validos 
        /// </summary>
        /// <returns></returns>
        public static string GenerateNewName() {
            return "a" + Guid.NewGuid().ToCleanString();
        }
    }
}
