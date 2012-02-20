using System;

namespace TigerNET.Common.Errors
{
    public abstract class Error
    {
        public int Line { get; protected set; }
        public int Column { get; protected set; }
        protected Error(int line, int column) {
            if (line < 0) {
                throw new ArgumentOutOfRangeException("La linea debe ser mayor o igual que cero");
            }
            if (column < 0) {
                throw new ArgumentOutOfRangeException("La columna debe ser mayor que cero");
            }
            
            Line = line;
            Column = column;
        }
    }
}
