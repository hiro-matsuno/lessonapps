// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5{
    class Program{
        static void Main(string[] args){
            Console.Write("あなたの姓を入力してください。");
            String FisrtName = Console.ReadLine();
            Console.Write("あなたの名を入力してください。");
            String SecondName = Console.ReadLine();
            Console.WriteLine("あなたは{0}{1}さんですね。",FisrtName,SecondName);
        }
    }
}