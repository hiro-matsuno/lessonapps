// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample405{
    class program{
        static void Main(string[] args){
            Person2 p = new Person2();
            p.SetAgeAndName("山田太郎",26);
            p.Age = 32;
            //P.Name = 36; is private setter&getter
            Console.WriteLine("名前:{0} 年齢:{1}",p.Name,p.Age);
        }     
    }
}
