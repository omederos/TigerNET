using System;
using System.Collections.Generic;
using System.Linq;
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

            //Comprobamos que ambas expresiones sean del tipo permitido por este nodo
            CheckIfAreTypesAllowed(errors);

            if (errorsCount != errors.Count) {
                return;
            }

            //Chequeamos que ambas expresiones retornen el mismo tipo (en Tiger)
            if (Left.ReturnType != Right.ReturnType) {
                //Si no retornan el mismo tipo, pero si un tipo es nil
                if (Left.ReturnType is NilType || Right.ReturnType is NilType) {
                    //Comprobamos que el otro tipo sea 'compatible' con nil
                    var nonNilType = Left.ReturnType is NilType ? Right.ReturnType : Left.ReturnType;
                    if (!NilType.CanBeAssignedTo(nonNilType)) {
                        errors.Add(new OperatorError(Line, Column, OperatorName, Left.ReturnType, Right.ReturnType));
                    }
                }
                else {
                    errors.Add(new OperatorError(Line, Column, OperatorName, Left.ReturnType, Right.ReturnType));
                }
            }
            //Si ambos tipos son nil
            else if (Left.ReturnType is NilType && Right.ReturnType is NilType) {
                errors.Add(new MessageError(Line, Column, "The type of the two expressions cannot be inferred because 'nil' was used"));
            }
            //El tipo de retorno de esta expresion sera entero
            ReturnType = IntegerType.Create();
        }

        protected void CheckIfAreTypesAllowed(IList<Error> errors) {
            bool foundLeft = false;
            bool foundRight = false;

            foreach (var allowedType in AllowedTypes) {
                //Comparamos si son del mismo tipo (TigerType)
                if (Left.ReturnType.GetType() == allowedType)
                {
                    foundLeft = true;
                }
                //Sino, comprobamos que sea 'nil', y en caso de serlo, vemos si alguno de los tipos que acepta este nodo como operandos permite 'nil'
                else if (Left.ReturnType is NilType && IsNilAccepted()) {
                    foundLeft = true;
                }
                if (Right.ReturnType.GetType() == allowedType) {
                    foundRight = true;
                }
                else if (Right.ReturnType is NilType && IsNilAccepted())
                {
                    foundRight = true;
                }
            }

            //Si alguno de los dos tipos no esta permitido...
            if (!foundLeft || !foundRight) {
                errors.Add(new OperatorError(Line, Column, OperatorName, Left.ReturnType, Right.ReturnType));
            }
        }

        private bool IsNilAccepted() {
            return AllowedTypes.Any(allowedType => NilType.CanBeAssignedTo(allowedType));
        }

        protected string GetNoTypeMessage(string expressionName, string typeName) {
            return string.Format(NoTypeMessage, expressionName, typeName);
        }

        protected string GetNoValueMessage(string expressionName) {
            return string.Format(NoValueMessage, expressionName);
        }
    }
}