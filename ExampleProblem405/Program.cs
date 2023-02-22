// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem405{
    class program{
        static void Main(string[] args){
            Console.Write("文字列を入力してください。");
            string str = Console.ReadLine();
            Console.WriteLine("文字の長さ:{0}",str.Length);
        }
    }
}