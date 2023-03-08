// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Sample404{
    class program{
        static void Main(string[] args){
            Access a = new Access();
            a.Data2 = 2;
            a.ShowDatas();
            Console.WriteLine("a.data1 = {0}",a.Data1);
        }
    }
}