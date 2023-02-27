// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem501{
    class Program{
        static double add(double a, double b){
            return a + b;
        }

        static double sub(double a, double b){
            return a - b; 
        }

        static double Mul(double a, double b){
            return a * b;
        }

        static double Div(double a, double b){
            return a/ b;
        }

        static void Main(string[] args){
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("a + b = " + add(a,b));
            Console.WriteLine("a - b = " + sub(a,b));
            Console.WriteLine("a * b = " + Mul(a,b));
            Console.WriteLine("a / b = " + Div(a,b));
        }
    }
}