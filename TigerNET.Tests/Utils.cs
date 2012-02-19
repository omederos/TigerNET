using System.Collections.Generic;
using Antlr.Runtime;
using TigerNET.AST;

namespace TigerNET.Tests {
    internal static class Utils {
        public static ExpressionNode BuildAST(string code) {
            var input = new ANTLRStringStream(code);
            var lexer = new TigerLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new TigerParser(tokens);
            return parser.prog();
        }

        public static T GetProperty<T>(ExpressionNode expr, string propName) where T : class {
            return expr.GetType().GetProperty(propName).GetValue(expr, null) as T;
        }

        public static string GetName(ExpressionNode expr) {
            return GetProperty<string>(expr, "Name");
        }

        public static string GetFieldName(ExpressionNode expr) {
            return GetProperty<string>(expr, "FieldName");
        }

        public static ExpressionNode GetLeft(ExpressionNode expr) {
            return GetProperty<ExpressionNode>(expr, "Left");
        }

        public static ExpressionNode GetIndex(ExpressionNode expr) {
            return GetProperty<ExpressionNode>(expr, "Index");
        }

        public static ExpressionNode GetRight(ExpressionNode expr) {
            return GetProperty<ExpressionNode>(expr, "Right");
        }

        public static ExpressionNode GetInitialExpression(ExpressionNode expr) {
            return GetProperty<ExpressionNode>(expr, "InitialValue");
        }

        public static ExpressionNode GetCountExpression(ExpressionNode expr) {
            return GetProperty<ExpressionNode>(expr, "Count");
        }

        public static IList<ExpressionNode> GetParameters(ExpressionNode expr) {
            return GetProperty<IList<ExpressionNode>>(expr, "Parameters");
        }

        public static ExpressionNode GetFirstDeclaration(ExpressionNode expr) {
            return ((LetInEndNode) expr).Declarations[0];
        }

        public static string GetType(ExpressionNode expr) {
            return GetProperty<string>(expr, "Type");
        }

        public static ExpressionNode GetBody(ExpressionNode expr) {
            return GetProperty<ExpressionNode>(expr, "Body");
        }

        public static IList<TypeField> GetFields(ExpressionNode expr) {
            return GetProperty<IList<TypeField>>(expr, "Fields");
        }

        public static IList<ExpressionNode> GetSequence(ExpressionNode expr) {
            return GetProperty<IList<ExpressionNode>>(expr, "Sequence");
        }

        public static string GetVariableName(ExpressionNode expr) {
            return GetProperty<string>(expr, "VariableName");
        }

        public static ExpressionNode GetExpressionInitial(ExpressionNode expr) {
            return GetProperty<ExpressionNode>(expr, "ExpressionInitial");
        }

        public static ExpressionNode GetExpressionFinal(ExpressionNode expr) {
            return GetProperty<ExpressionNode>(expr, "ExpressionFinal");
        }

        public static ExpressionNode GetCondition(ExpressionNode expr) {
            return GetProperty<ExpressionNode>(expr, "Condition");
        }

        public static ExpressionNode GetThen(ExpressionNode expr) {
            return GetProperty<ExpressionNode>(expr, "ThenBody");
        }

        public static ExpressionNode GetElse(ExpressionNode expr) {
            return GetProperty<ExpressionNode>(expr, "ElseBody");
        }

        public static int GetIntValue(ExpressionNode expr) {
            return int.Parse(GetProperty<object>(expr, "Value").ToString());
        }

        public static IList<DeclarationNode> GetDeclarations(ExpressionNode expr) {
            return GetProperty<IList<DeclarationNode>>(expr, "Declarations");
        }

        public static ExpressionSequenceNode GetExpressions(ExpressionNode expr) {
            return GetProperty<ExpressionSequenceNode>(expr, "Expressions");
        }

        public static IList<FieldAssignmentNode> GetFieldAssignments(ExpressionNode expr) {
            return GetProperty<IList<FieldAssignmentNode>>(expr, "Fields");
        }

        public static string GetValue(ExpressionNode expr) {
            return GetProperty<object>(expr, "Value").ToString();
        }
    }
}