// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample308{
    class program{
        static void Main(string[] args){
            int[] n = {5, 4, 3, 2, 1};
            foreach(int i in n){
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}