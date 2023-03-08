// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample501{
    class Program{
        static void Main(string[] args){
            Data[] d = new Data[2];
            Data.ShowNumber();
            for (int i=0; i< d.Length; i++){
                d[i] = new Data(1*100);
                Data.ShowNumber();
            }
        }
    }
}