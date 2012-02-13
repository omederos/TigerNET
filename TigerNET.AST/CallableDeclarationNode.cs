﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class CallableDeclarationNode : DeclarationNode {
        /// <summary>
        /// Campos de la funcion/procedimiento
        /// </summary>
        public IList<TypeField> Fields { get; set; }
        /// <summary>
        /// En caso de ser una funcion, representa el tipo (dentro del programa) de esta
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// El cuerpo de la funcion
        /// </summary>
        public ExpressionNode Body { get; set; }

        public CallableDeclarationNode(string name, IList<TypeField> fields, ExpressionNode body, string type = null) : base(name) {
            Fields = fields;
            Type = type;
            Body = body;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}
