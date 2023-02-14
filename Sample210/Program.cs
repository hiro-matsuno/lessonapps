// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample210{
    class program{
        static void Main(string[] args){
            Console.Write("サイコロの目(1～6):");
            int dice = int.Parse(Console.ReadLine());
            if(dice >= 1 && dice <= 6){
                if(dice == 2 || dice == 4 || dice == 6){
                    Console.WriteLine("丁（チョウ）です。");
                }else if(dice == 1 || dice == 3 || dice == 5){
                    Console.WriteLine("半（ハン）です。");
                }
            }else{
                Console.WriteLine("範囲外の数値です。");
            }
        }
    }
}