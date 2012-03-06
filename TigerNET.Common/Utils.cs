using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common.Types;

namespace TigerNET.Common
{
    public static class Utils
    {
        public static string ToCleanString(this Guid guid) {
            return guid.ToString().Replace("-", "");
        }
    }
}
