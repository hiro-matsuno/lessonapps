// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_8{
    class Program{
        static void Main(string[] args){
            for(int i=2; i<=100 ; i++){
                int Count = 0;
                for (int j=1; j <= i;j++){
                    if(i % j == 0){
                        Count++;
                    }
                }
                if(Count == 2){
                    Console.Write("{0} ", i);
                }
                
                
            }
            Console.WriteLine();
        }
    }
}