// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample202{
    class program{
        static void Main(string[] args){
            int a;
            int b = 3;
            int add, sub;
            double avg;
            a = 6;
            add = a + b;
            sub = a - b;
            avg = (a + b) / 2.0;
            //Console.WriteLine("変数num1は{0}、変数num2は{1}", a, b);
            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0}と{1}の平均値は{2}", a, b, avg);
           

        }
    }
}