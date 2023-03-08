// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample506{
    class Program{
        public void Foo(){
            Console.WriteLine("Foo");
        }
        static void Main(string[] args){
            Program s = new Program();
            Console.WriteLine(s.ToString());
        }
    }
}