﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class RecordLiteralNode : NonAtomicLiteralNode
    {
        /// <summary>
        /// Valores de los campos del record que se asignaran
        /// </summary>
        public IList<FieldAssignmentNode> Fields { get; set; }

        public RecordLiteralNode(string name, IList<FieldAssignmentNode> fields) : base(name) {
            Fields = fields;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}