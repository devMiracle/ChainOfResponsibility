using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //список доступных номеров:
            //"+380981111111",
            //"+38 098 111 11 11",
            //"+38(098)1111111",
            //"+38(098)111-11-11",
            //"0981111111",
            //"098 111 11 11",
            //"(098)1111111",
            //"(098)111-11-11"

            //список доступных мейл адресов:
            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format

            //Valid: david.jones@proseware.com
            //Valid: d.j@server1.proseware.com
            //Valid: jones@ms1.proseware.com
            //Valid: j@proseware.com9
            //Valid: js#internal@proseware.com
            //Valid: j_9@[129.126.118.1]
            //Valid: js@proseware.com9
            //Valid: j.s@server1.proseware.com
            //Valid: "j\"s\""@proseware.com
            //Valid: js@contoso.中国
            //Invalid: j.@server1.proseware.com
            //Invalid: j..s@proseware.com
            //Invalid: js*@proseware.com
            //Invalid: js@proseware..com


            //первое звено обрабатывает телефоны
            Handler main = new HandlerTelephone();
            //второе звено обрабатывает мейлы
            Handler h2 = new HandlerEmail();
            //подвязываем первое звено со вторым
            main.Successor = h2;
            //вызываем первое звено цепочки с аргументом
            main.HandlerRequest("+38(097)111-11-11");//подаем на вход либо телефон, либо мейл


        }
    }
}
