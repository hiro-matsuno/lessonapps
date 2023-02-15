// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample301{
    class program{
        static void Main(string[] args)
        {
            for (int i = 12; i > 0; i-=3){
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}