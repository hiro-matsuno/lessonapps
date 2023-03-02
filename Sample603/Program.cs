﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample603
{
    class Program{
        static void Main(string[] args){
            Dictionary<String ,String> capital = new Dictionary<String, String>();
            capital["日本"] = "東京";
            capital["イギリス"] = "ロンドン";
            capital["フランス"] = "パリ";
            capital["中国"] = "北京";
            foreach(String s in capital.Keys){
                Console.WriteLine("{0}の首都は{1}です。", s, capital[s]);
            }
        }
    }
}