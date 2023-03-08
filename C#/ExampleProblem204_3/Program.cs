// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem204_3{
    class program{
        static void Main(string[] args){
            Console.Write("月(1～12)を入力してください。");
            int m = int.Parse(Console.ReadLine());
            string d = null;
            switch(m){
                case 2:
                    d = "28か29";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    d = "30";
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    d = "31";
                    break;
                default:
                    Console.WriteLine("適切な値を入れてください。");
                    return;
            }
            Console.WriteLine("{0}月の長さは{1}日です。", m, d);
        }
    }
}
