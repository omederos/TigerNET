namespace TigerNET.Common.Errors {
    public class NonValueAssignmentError : Error {
        public string MemberName { get; set; }

        public NonValueAssignmentError(int line, int column, string member) : base(line, column) {
            MemberName = member;
        }
        public override string ToString() {
            return string.Format("The expression that was assigned to '{0}' does not return any value", MemberName);
        }
    }
}