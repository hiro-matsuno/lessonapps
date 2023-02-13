// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample201{
    class program{
        static void Main(string[] args){
            Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);
            Console.WriteLine("{0} - {1} = {2}", 5, 2, 5 - 2);
            Console.WriteLine("{0} * {1} = {2}", 5, 2, 5 * 2);
            Console.WriteLine("{0} / {1} = {2} 余り {3}", 5, 2, 5 / 2, 5 % 2);
        }
    }
}
