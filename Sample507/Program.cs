// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample507{
    class Program{
        static void Main(string[] args){
            Crow c = new Crow();
            Sparrow s = new Sparrow();
            Console.WriteLine(c.Name + " : ");
            c.sing();
            Console.WriteLine(s.Name + " : ");
            s.sing();
        }
    }
}