﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class EqualOperatorNode : RelationalBinaryOperatorNode
    {
        public EqualOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}
        public EqualOperatorNode() : this(null, null) {}
        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
