// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample505{
    class Program{
        static void Main(string[] args){
            Parent p = new Parent();
            Child c = new Child();
            p.Foo();
            c.Foo();
        }
    }
}