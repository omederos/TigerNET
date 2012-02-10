﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.AST
{
    public class AliasDeclarationNode : TypeDeclarationNode
    {
        /// <summary>
        /// Tipo al que se esta haciendo referencia. En el siguiente ejemplo, AliasType seria 'b' y Name 'a'
        /// type a = b
        /// </summary>
        public string AliasType { get; set; }

        public AliasDeclarationNode(string name, string aliasType) : base(name) {
            AliasType = aliasType;
        }

        public override void GenerateCode() {
            throw new NotImplementedException();
        }

        public override void CheckSemantic() {
            throw new NotImplementedException();
        }
    }
}