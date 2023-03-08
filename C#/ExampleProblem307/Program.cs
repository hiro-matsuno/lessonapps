// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem307{
    class program{
        static void Main(string[] args){
            int i = 0;
            int j = 0;

            Random rnd = new Random();
            int[] n = new int[10];
        
            for(i = 0; i < n.Length; i++){
                int num = rnd.Next(1, 101);
                n[i] = num;
                Console.Write("{0} ",num);
            }
            Console.WriteLine();
            string[] names= {"奇数","偶数"};
            for (i = 0; i <= 1; i++){
                Console.Write(names[i]);
                for(j = 0; j < n.Length; j++){
                    if(n[j] % 2 == i){
                        Console.Write("{0} ", n[j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
