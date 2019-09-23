using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class HandlerTelephone : Handler
    {
        public override void HandlerRequest(string text)
        {
            string pattern = @"^(\+38)?((\([0-9]{3}\))?[0-9]{7,10})|((\([0-9]{3}\))([0-9]{3}-[0-9]{2}-[0-9]{2})|([0-9]{3}\s[0-9]{2}\s[0-9]{2}))$";
            if (Regex.IsMatch(text, pattern))
                Console.WriteLine("Обработка телефонного номера успешна!");
            else if (Successor != null)
                Successor.HandlerRequest(text);
        }
    }
}
