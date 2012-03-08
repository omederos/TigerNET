using System.Collections.Generic;
using TigerNET.AST;

namespace TigerNET.Common.StdLib {
    internal class GetLineCallable: Callable {
        public GetLineCallable() : base("getline", new List<TypeField>(), "string") {}
    }
}