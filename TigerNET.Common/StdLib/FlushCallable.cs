using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class FlushCallable: Callable {
        public FlushCallable() : base("flush", new List<TypeField>()) {}
    }
}