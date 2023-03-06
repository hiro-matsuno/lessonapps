// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4{
    class Program{
        static void Main(string[] args){
            Console.Write("幅(cm) =");
            double haba = double.Parse(Console.ReadLine());
            Console.Write("奥行(cm) = ");
            double okuiki = double.Parse(Console.ReadLine());
            Console.Write("高さ(cm) = ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("立方体の面積 = {0}cm3" ,Math.Round(haba * okuiki * height,3));
        }
    }
}