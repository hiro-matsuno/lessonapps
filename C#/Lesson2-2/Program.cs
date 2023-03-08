// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("整数値を入力してください。");
            int i = int.Parse(Console.ReadLine());
            if(i == 0){
                Console.WriteLine("{0}です。",i);
            }else{
                Console.WriteLine("0ではありません。");
            }
        }
    }
}