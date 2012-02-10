using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public abstract class ControlNode : InstructionNode
    {
    }

    public class IfThenElseNode : ControlNode{
        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }

    public class ForNode : ControlNode
    {
        public override void GenerateCode()
        {
            throw new NotImplementedException();
        }

        public override void CheckSemantic()
        {
            throw new NotImplementedException();
        }
    }

    public class WhileNode : ControlNode
    {
        public override void GenerateCode()
        {
            throw new NotImplementedException();
        }

        public override void CheckSemantic()
        {
            throw new NotImplementedException();
        }
    }
}
