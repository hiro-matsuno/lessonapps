// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_5{
    class Program{
        static void Main(string[] args){
            Random rnd = new Random();
            int Max = -1,Min = 101;
            for(int i = 0; i <= 5; i++ ){
                int n = rnd.Next(1,101);
                Console.Write("{0} ", n);
                if(n > Max){
                    Max = n;
                }
                if(n < Min){
                    Min = n;
                }
            }
            Console.WriteLine();
            Console.WriteLine("最大値:{0}",Max);
            Console.WriteLine("最小値:{0}",Min);
        }
    }
}