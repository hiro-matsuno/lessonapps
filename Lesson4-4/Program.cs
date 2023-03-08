// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_4{
    class Program{
        static void Main(string[] args){
            Console.Write("月（1～12）を入力してください。");
            int month = int.Parse(Console.ReadLine());
            switch(month){
                case 1:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"January");
                    break;
                case 2:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"Febrary");
                    break;
                case 3:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"March");
                    break;
                case 4:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"April");
                    break;
                case 5:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"May");
                    break;
                case 6:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"June");
                    break;
                case 7:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"July");
                    break;
                case 8:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"Augast");
                    break;
                case 9:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"September");
                    break;
                case 10:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"October");
                    break;
                case 11:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"November");
                    break;
                case 12:
                    Console.WriteLine("{0}月は英語で{1}です。",month,"December");
                    break;
                default:
                    break;
            }
            Console.WriteLine();
        }
    }
}