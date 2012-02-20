namespace TigerNET.Common.Errors {
    public class AlreadyDefinedError : Error {
        public string Name { get; set; }

        public AlreadyDefinedError(int line, int column, string name) : base(line, column) {
            Name = name;
        }

        public override string ToString() {
            return string.Format("A member with the name '{0}' already exists", Name);
        }
    }
}