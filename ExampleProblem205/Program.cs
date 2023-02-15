// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem205{
    class program{
        static void Main(string[] args){
            Console.Write("文字列を入力:");
            String s = Console.ReadLine();
            if(s == "Hello"){
                Console.WriteLine("Helloが入力されました。");
            }else{
                Console.WriteLine("Helloと入力してください");  
            }
        }
    }
}