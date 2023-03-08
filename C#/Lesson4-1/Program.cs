// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_1{
    class Program{
        static void Main(string[] args){
            Random rnd = new Random();
            int[] a = new int[6];
            for (int i = 0; i < 6; i++){
                a[i] = rnd.Next(1,10);
                Console.Write("a[{0}]={1} ",i ,a[i]);
            }
            Console.WriteLine();
        }
    }
}