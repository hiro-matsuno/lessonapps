// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem402{
    class program{
        static void Main(string[] args){
            Console.Write("英文を入れてください。");
            string str = Console.ReadLine();
            Console.WriteLine("大文字:{0}",str.ToUpper());
            Console.WriteLine("小文字:{0}",str.ToLower());
        }
    }
}