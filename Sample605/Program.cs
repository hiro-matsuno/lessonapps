// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample605{
    delegate void Oparation(int a, int b);

    class Calc{
        public void Sub(int a, int b){
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
    }

    class Program{
        static void Add(int a, int b){
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        static void Main(string[] args){
            Calc c = new Calc();
            Oparation o1 = new Oparation(Add);
            Oparation o2 = new Oparation(c.Sub);

            o1(2,1);
            o2(2,1);
        }
    }
}