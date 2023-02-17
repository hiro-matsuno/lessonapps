// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem308{
    class program{
         static void Main(string[] args){
            Random rnd = new Random();
            int[] start = new int[10];
            for (int i = 0; i < start.Length; i++){
                start[i] = rnd.Next(1,101);
                Console.Write("{0} ",start[i]);
            }
            Console.WriteLine();

            for(int i = 0; i < start.Length; i++){
                int max = 0;
                int pos = 0;

                for (int j = 0;j < start.Length; j++){
                    if(max < start[i]){
                        max = start[j];
                        pos = j; 
                    }
                    Console.Write("{0} ",max);
                    start[pos] = 0;
                }
                Console.WriteLine();
            }
         }
    }
}
