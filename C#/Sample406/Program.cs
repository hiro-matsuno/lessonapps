﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample406{
    class program{
        static void Main(string[] args){
            Person p1,p2;
            p1 = new Person();
            p2 = new Person("太田隆",29);
            p1.Name = "斉藤花子";
            p1.Age = 18;
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}