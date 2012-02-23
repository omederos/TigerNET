namespace TigerNET.Common.Errors {
    public class CyclicAliasesError : Error {
        public CyclicAliasesError(int line, int column) : base(line, column) {

        }
        public override string ToString() {
            return "Existe un ciclo en las declaraciones de varios alias";
        }
    }
}