// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem303{
    class program{
        static void Main(string[] args){
            Console.WriteLine("数あてゲーム");
            Console.WriteLine("0から10までの数値を入力してください。:");
            Random rnd = new Random();
            int n = rnd.Next(11);
            int i = 1;
            while(i <= 3){
                Console.Write("{0}回目:",i);
                int ans = int.Parse(Console.ReadLine());
                if(ans < n){
                    Console.WriteLine("小さすぎます。");
                }else if(ans > n){
                    Console.WriteLine("大きすぎます。");
                }else{
                    Console.WriteLine("正解です。");
                    break;
                }
                i++;

                if(i==4){
                    Console.WriteLine("ゲームオーバー!");
                    Console.WriteLine("正解は{0}です。",n);
                }
            }
        }
    }
}