﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample511{
    class Program{
        static void Main(string[] args){
            Dummy d = new Dummy();
            IFuncs1 i1 = (IFuncs1)d;
            IFuncs2 i2 = (IFuncs2)d;
            i1.Func1();
            i1.Func2();

            i2.Func2();
            i2.Func3();
        }
    }
}