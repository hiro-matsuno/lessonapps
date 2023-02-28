// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample508{
    class Program{
        static void Main(string[] args){
            /*Crow c = new Crow();
            Sparrow s = new Sparrow();
            Console.Write(c.Name + " : ");
            c.Sing();
            Console.Write(s.Name + " : ");
            s.Sing();*/
            Bird[] b = new Bird[2];
            b[0] = new Crow();
            b[1] = new Sparrow();
            for (int i=0; i < b.Length; i++){
                Console.Write(b[i].Name + " : ");
                b[i].Sing();
            }
        }
    }
}