using System;
using System.Collections.Generic;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST {
    public abstract class BinaryOperatorNode : OperatorNode {
        protected string NoValueMessage = "{0} expression does not return any value";
        protected string NoTypeMessage = "{0} expression must return a {1}";
        public ExpressionNode Left { get; set; }
        private ExpressionNode _right;

        public ExpressionNode Right {
            get { return _right; }
            set {
                _right = value;
                if (value != null) {
                    Left.Parent = this;
                    _right.Parent = this;
                }
            }
        }

        public string OperatorName { get; set; }
        public IList<Type> AllowedTypes { get; set; }

        protected BinaryOperatorNode(ExpressionNode left, ExpressionNode right, string operatorName) {
            Left = left;
            Right = right;
            OperatorName = operatorName;
            //El tipo Int esta permitido en todos los operadores
            AllowedTypes = new List<Type>();
        }

        /// <summary>
        /// Chequea que ambos operandos sean enteros y que retornen valor
        /// Importante: Los nodos que difieran en el chequeo semantico, deben sobreescribirlo
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="errors"></param>
        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Se comprueban ambos nodos (izquierda y derecha)
            int errorsCount = errors.Count;
            Left.CheckSemantic(scope, errors);
            Right.CheckSemantic(scope, errors);

            //Si ocurrio algun error
            if (errorsCount != errors.Count) {
                return;
            }

            //Comprobamos que ambas expresiones retornan valor
            ErrorsHelper.CheckIfReturnsValue(Left, errors, GetNoValueMessage("Left"));
            ErrorsHelper.CheckIfReturnsValue(Right, errors, GetNoValueMessage("Right"));

            if (errorsCount != errors.Count) {
                return;
            }

            //Chequeamos que ambas expresiones retornen el mismo tipo (en Tiger)
            if (Left.ReturnType != Right.ReturnType) {
                errors.Add(new OperatorError(Line, Column, OperatorName, Left.ReturnType, Right.ReturnType));
                return;
            }

            //Comprobamos que ambas expresiones sean del tipo permitido por este nodo
            CheckIfAreTypesAllowed(errors);

            //El tipo de retorno de esta expresion sera entero
            ReturnType = IntegerType.Create();
        }

        protected void CheckIfAreTypesAllowed(IList<Error> errors) {
            bool foundLeft = false;
            bool foundRight = false;

            foreach (var allowedType in AllowedTypes) {
                //Comparamos si son del mismo tipo (TigerType)
                if (Left.ReturnType.GetType() == allowedType) {
                    foundLeft = true;
                }
                if (Right.ReturnType.GetType() == allowedType) {
                    foundRight = true;
                }
            }

            if (!foundLeft || !foundRight) {
                errors.Add(new OperatorError(Line, Column, OperatorName, Left.ReturnType, Right.ReturnType));
            }
        }

        protected string GetNoTypeMessage(string expressionName, string typeName) {
            return string.Format(NoTypeMessage, expressionName, typeName);
        }

        protected string GetNoValueMessage(string expressionName) {
            return string.Format(NoValueMessage, expressionName);
        }
    }
}