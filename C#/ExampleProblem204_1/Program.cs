// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem204_1{
    class program{
        static void Main(string[] args){
            Console.Write("月(1～12)を入力してください。");
            int m = int.Parse(Console.ReadLine());
            String d = null;
            if(m >= 1 && m <= 12){
                if(m == 2){
                    d = "28か29";
                }else if(m == 4 || m == 6 || m == 9 || m == 11){
                    d = "30";
                }else{
                    d = "31";
                }
                Console.WriteLine("{0}月の長さは{1}日です。", m , d);
            }else{
                Console.WriteLine("適切な値を入れてください。");
            }
        }
    }
}