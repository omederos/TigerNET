﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class NilLiteralNode : AtomicLiteralNode
    {
        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}