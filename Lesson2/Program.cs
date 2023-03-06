// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2{
    class Program{
        static void Main(string[] args) {
            Console.Write("半径を入力(cm):");
            double hankei = double.Parse(Console.ReadLine());
            double menseki = Math.Round(hankei * hankei *3.14,3);
            double enshu = Math.Round(2 * 3.14 * hankei,1);
            Console.WriteLine("円の面積は(cm2):{0}cm2",menseki);
            Console.WriteLine("円周の長さは(cm):{0}cm",enshu);
        }
    }
}