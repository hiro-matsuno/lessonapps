// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem204_2{
    class program{
        static void Main(string[] args){
            Console.Write("月(1～12)を入力してください。");
            int m = int.Parse(Console.ReadLine());
            string d = null;
            if(m == 2){
                d = "28か29";
            }else if(m == 4 || m == 6 || m == 9 || m == 11){
                d = "30";
            }else if(m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12){
                d = "31";
            }else{
                Console.WriteLine("適切な値を入れてください。");
                return;
            }
            Console.WriteLine("{0}月の長さは{1}日です。", m, d);
        }
    }
}