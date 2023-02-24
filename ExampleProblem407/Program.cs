// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem407{
    class Program{
        static void Main(string[] args){
            Student[] students = new Student[3];
            students[0] = new Student();
            students[0].SetInformation("高喜", 3, 18);
            students[1] = new Student();
            students[1].SetInformation("勇一", 2, 17);
            students[2] = new Student();
            students[2].SetInformation("花子", 1, 16);

            foreach(Student s in students){
                s.ShowInformation();
            }
        }
    }
}