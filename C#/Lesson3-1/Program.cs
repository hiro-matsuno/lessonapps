// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_1{
    class Program{
        static void Main(string[] args){
            Console.Write("回数を入力");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++){
                Console.WriteLine("Hello C#!");
            }
            Console.WriteLine();
        }
    }
}