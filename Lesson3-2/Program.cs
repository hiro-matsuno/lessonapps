// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_2{
    class Program{
        static void Main(string[] args){
            Console.Write("Forループ:");
            for (int i=1; i <= 5;i++){
                Console.Write("★ ");
            }
            Console.WriteLine();

            Console.Write("whileループ");
            int Count = 0;
            while(Count < 5){
                Console.Write("★ ");
                Count++;
            }
            Console.WriteLine();

            Console.Write("do～whileループ");
            int Count2 = 0;
            do{
                Console.Write("★ ");
                Count2++;
            }while(Count2 < 5);
            Console.WriteLine();
        }
    }
}