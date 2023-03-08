// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_3{
    class Program{
        static void Main(string[] args){
            string[] str = new String[5]; 
            for(int i = 0; i < 5; i++){
                Console.WriteLine("{0}つ目の文字列を入力:",i);
                str[i] = Console.ReadLine();
            }

            for(int m=0; m < 5; m++){
                Console.Write("{0} ", str[m]);
            }
            Console.WriteLine();
        }
    }
}