using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class GetCharCallable: Callable {
        public GetCharCallable() : base("getchar", new List<TypeField>(), "string") {}
    }
}