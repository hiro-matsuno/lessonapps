// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Sample402{
    class Calc{
        public int Add(int a, int b) {
            return a + b;
        }

        public int Add(int a,int b,int c){
            return a + b + c;
        }
    }

    class program{
        static void Main(string[] args){
            Calc calc = new Calc();
            int a = 1, b = 2,c = 3;
            int ans1 = calc.Add(a, b);
            int ans2 = calc.Add(a, b, c);
            Console.WriteLine("{0} + {1} = {2}", a, b, ans1);
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c , ans2); 
        }
    }
}