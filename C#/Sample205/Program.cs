// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample205{
    class program{
        static void Main(string[] args){
            string str1,str2;
            Console.Write("str1=");
            str1 = Console.ReadLine();
            Console.Write("str2=");
            str2 = Console.ReadLine();
            Console.WriteLine("str1 + str2 = {0}",str1 + str2);
        }
    }
}