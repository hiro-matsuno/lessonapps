// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample207{
    class program{
        static void Main(string[] args){
            Console.Write("整数を入力");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a);
            if(a > 0){
                Console.WriteLine("aは正の数です。");
            // }else if(a < 0){
                // Console.WriteLine("aは負の数です。");
            }
        }
    }
}
