// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem304{
    class program{
        static void Main(string[] args){
            Random rnd = new Random();
            int max = 0;
            int min = 101;

            for (int i = 0; i <= 10; i++){
                int n = rnd.Next(1,101);
                Console.Write("{0} ",n);
                if(n > max){
                    max = n;
                }
                
                if(n < min){
                    min = n;
                }
            }
            Console.WriteLine();
            Console.WriteLine("最大値:{0}", max);
            Console.WriteLine("最小値:{0}", min);
        }
    }
}