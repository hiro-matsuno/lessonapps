// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem204{
    class program{
        static void Main(string[] args){
            double num1,num2,avg;
            Console.Write("num1=");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("num2=");
            num2 = double.Parse(Console.ReadLine());

            avg = (num1 + num2) / 2.0;
            Console.WriteLine("{0}と{1}の平均値は：{2}",num1,num2,avg);
        }
    }
}
