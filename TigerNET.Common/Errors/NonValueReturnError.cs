namespace TigerNET.Common.Errors {
    public class NonValueReturnError : Error {
        public string ReturnMessage { get; set; }

        public NonValueReturnError(int line, int column, string returnMessage = null) : base(line, column) {
            ReturnMessage = returnMessage;
        }

        public override string ToString() {
            return ReturnMessage ?? "A return value was expected, but the expression does not return any";
        }
    }
}