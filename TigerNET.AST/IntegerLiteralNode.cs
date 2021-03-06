﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST
{
    public class IntegerLiteralNode : AtomicLiteralNode
    {
        public int Value { get; set; }

        public IntegerLiteralNode(int value) {
            Value = value;
        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            generator.Emit(OpCodes.Ldc_I4, Value);
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            ReturnType = IntegerType.Create();
        }
    }
}
