using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;

namespace TigerNET.AST
{
    public interface IScopeDefiner
    {
        //Scope asociado al nodo actual
        Scope Scope { get; set; }
        //Instancia del padre del nodo actual (en IL)
        FieldBuilder ParentInstance { get; set; }
    }
}
