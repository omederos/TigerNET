using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TigerNET.Common.Errors
{
    public class MessageError : Error
    {
        public string Message { get; set; }

        public MessageError(int line, int column, string msg) : base(line, column) {
            Message = msg;
        }

        public override string ToString() {
            return Message;
        }
    }
}
