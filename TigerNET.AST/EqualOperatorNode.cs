﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;

namespace TigerNET.AST
{
    public class EqualOperatorNode : RelationalBinaryOperatorNode
    {
        public EqualOperatorNode(ExpressionNode left, ExpressionNode right) : base(left, right) {}
        public EqualOperatorNode() : this(null, null) {}
        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            throw new NotImplementedException();
        }
    }
}
