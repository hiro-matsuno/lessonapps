// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem404{
    class program{
        static void Main(string[] args){
            Rectangle r = new Rectangle();
            Console.Write("幅(cm):");
            r.Width = double.Parse(Console.ReadLine());
            Console.Write("高さ(cm):");
            r.Height = double.Parse(Console.ReadLine());
            
            Console.WriteLine("面積:{0}cm2",r.GetArea());
            Console.WriteLine("周の長さ:{0}cm",r.GetPerimeter());
        }
    }
}