// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3{
    class Program{
        static void Main(string[] args){
            Console.Write("テストの点数を入力してください。:");
            int point = int.Parse(Console.ReadLine());
            if(point >= 0 && point < 60){
                Console.WriteLine("不可");
            }else if(point >= 60 && point < 70){
                Console.WriteLine("可");
            }else if(point >= 70 && point < 80){
                Console.WriteLine("良");
            }else if(point >= 80 && point <= 100){
                Console.WriteLine("優");
            }else{
                Console.WriteLine("不適切な値です。");
            }
        }
    }
}