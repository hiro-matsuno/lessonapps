// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_6{
    class Program{
        static void Main(string[] args){
            while(true){
                Console.Write("文字を入力:");
                string Moji = Console.ReadLine();
                if(Moji == null || Moji == ""){
                    break;
                }
                Console.WriteLine(Moji);
            }
        }
    }
}