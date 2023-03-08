// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem403{
    class program{
        static void Main(string[] args){
            Bingo card = new Bingo();
            Console.Write("ビンゴのマスの縦･横のサイズを入力:");
            int size = int.Parse(Console.ReadLine());
            card.Init(size);
            card.Show();
        }
    }
}