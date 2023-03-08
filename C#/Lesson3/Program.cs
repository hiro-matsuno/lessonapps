// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3{
    class Program{
        static void Main(string[] args){
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("C = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("a + b + c = {0}" , a + b + c);
            Console.WriteLine("a,b,cの平均値={0}", a + b + c / 3.0);
        }
    }
}