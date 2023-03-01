// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample510{
    class Program{
        static void Main(string[] args){
            CellPhone cp = new CellPhone("hoge@email.com","090-1234-5678");
            cp.Call("011-123-4567");
            cp.SendMail("fuga@email.com");
            IPhone phone = (IPhone)cp;
            phone.Call("011-987-6543");
            IEmail mail = (IEmail)cp;
            mail.SendMail("bar@email.com");
        }
    }
}