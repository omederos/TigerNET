using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using TigerNET.Common;
using TigerNET.Common.Errors;
using TigerNET.Common.Types;

namespace TigerNET.AST {
    public class VariableDeclarationNode : DeclarationNode {

        public ExpressionNode Body { get; set; }
        public string Type { get; set; }
        public Variable Variable { get; set; }

        public VariableDeclarationNode(string name, ExpressionNode body, string type = null) : base(name) {
            Body = body;
            Type = type;
            Body.Parent = this;
        }

        public override void GenerateCode(ILGenerator generator, TypeBuilder typeBuilder) {
            //Como nuestros scopes son representados por clases, las variables son declaradas como variables de instancia en la clase (campos)

            //Guardamos la variable que definimos en IL (para poder mapearla luego sin problemas)
            Variable.ILVariable = typeBuilder.DefineField(Variable.GetName(), Variable.Type.GetILType(), FieldAttributes.Public);

            generator.Emit(OpCodes.Ldarg_0); //Cargamos el parametro 0 (la instancia de la clase)

            //Generamos el codigo del cuerpo de la asignacion
            Body.GenerateCode(generator, typeBuilder);

            //Le asignamos ese valor que se quedo en la pila a la variable
            generator.Emit(OpCodes.Stfld, Variable.ILVariable); //Asignamos el valor que esta en la pila a la variable

            //TODO: Si es un record, dejar guardados los valores de los parametros/argumentos del record en el RecordLiteralNode!?
        }

        public override void CheckSemantic(Scope scope, IList<Error> errors) {
            //Si ya se definio ese nombre anteriormente (en este scope solamente)
            if (scope.ExistsVariableOrCallable(Name, false)) {
                errors.Add(new AlreadyDefinedError(Line, Column, Name));
                return;
            }

            int errorsCount = errors.Count;
            
            //Chequeamos la semantica de la expresion que estamos asignando
            Body.CheckSemantic(scope, errors);

            //Si hubo errores en el chequeo semantico...
            if (errorsCount != errors.Count) {
                return;
            }

            errorsCount = errors.Count;

            //Si me especificaron el tipo
            TigerType resultType = null;
            
            if (Type != null) {
                //Si el tipo no existe
                if (!scope.ExistsType(Type)) {
                    errors.Add(new UndefinedTypeError(Line, Column, Type));
                }
                
                //Guardamos el tipo que debe almacenar esta variable (segun su definicion)
                resultType = scope.GetType(Type);

                //Si el tipo de retorno de la expresion es diferente al del especificado explicitamente
                if (Body.ReturnType != resultType) {
                    //Debemos chequear el caso se este asignando Nil a un tipo que lo permita
                    if (!(Body.ReturnType is NilType) || !NilType.CanBeAssignedTo(resultType)) {
                        errors.Add(new UnexpectedTypeError(Line, Column, resultType, Body.ReturnType));
                    }
                    
                }
            }
            //Si no me especificaron el tipo
            else {
                //Si no tiene tipo de retorno
                if (!Body.ReturnsValue()) {
                    errors.Add(new NonValueAssignmentError(Line, Column, Name));
                }
                //Si el tipo de retorno es Nil, no es valido pues no se puede inferir el tipo de la variable que estamos declarando
                else if (Body.ReturnType is NilType) {
                    errors.Add(new NilAssignmentError(Line, Column, Name));
                }
            }

            //Si no hubo ningun error...
            if (errorsCount == errors.Count) {
                //Finalmente anadimos la variable declarada al scope
                scope.Add(Name, Body.ReturnType is NilType ? resultType : Body.ReturnType);
                //Guardamos la variable en el nodo para poder usarla en la generacion de codigo
                Variable = scope.GetVariable(Name, false);
            }
        }
    }
}