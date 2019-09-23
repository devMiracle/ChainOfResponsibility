using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandlerRequest(string text);
        public void Connect(Handler Successor)
        {
            this.Successor = Successor;
        }
    }
}
