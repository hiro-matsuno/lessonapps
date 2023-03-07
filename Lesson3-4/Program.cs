// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson3_4{
    class Program{
        static void Main (string[] args){
            Console.Write("回数を入力：");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("2の倍数");
            for (int i = 0; i <= n; i+=2){
                if(i != 0){
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine();

            Console.WriteLine("3の倍数");
            for(int j = 0; j <= n; j += 3){
                if(j != 0){
                    Console.Write("{0} ",j);
                }    
            }
            Console.WriteLine();

            Console.WriteLine("5の倍数");
            for(int k = 0; k <= n; k += 5){
                if(k != 0){
                    Console.Write("{0} ",k);
                }
            }
            Console.WriteLine();
        }
    }
}