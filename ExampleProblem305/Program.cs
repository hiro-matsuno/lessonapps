// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem305{
    class program{
        static void Main(string[] args){
            Console.WriteLine("九九の表示");
            for (int m = 1; m <= 9; m++){
                for(int n = 1;n <= 9; n++){
                    Console.Write("{0} × {1} ={2,2:d} ", m, n, m*n);
                }
                Console.WriteLine();
            }
        }
    }
}