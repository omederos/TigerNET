namespace TigerNET.Common.Errors {
    public class CyclicAliasesError : Error {
        public CyclicAliasesError(int line, int column) : base(line, column) {

        }
        public override string ToString() {
            return "A cycle exists in the definition of aliases";
        }
    }
}