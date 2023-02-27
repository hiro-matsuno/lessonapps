// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample503{
    class Program{
        static void Main(string[] args){
            Calculatar c1 = new Calculatar();
            c1.Num1 = 10;
            c1.Num2 = 3;
            c1.Add();
            c1.Sub();
            ExCalculator c2 = new ExCalculator();
            c2.Num1 = 10;
            c2.Num2 = 3;
            c2.Add();
            c2.Sub();
            c2.Mul();
            c2.Div();
        }
    }
}