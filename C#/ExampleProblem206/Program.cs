// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem206{
    class program{
        static void Main(string[] args)
        {
            Console.Write("H2Oの温度");
            double temperature = double.Parse(Console.ReadLine());
            /*if(temperature >= 100){
                Console.WriteLine("気体");
            }else if(temperature > 0.0){
                Console.WriteLine("液体");
            }else{
                Console.WriteLine("固体");
            }*/
            if(temperature <= 0.0){
                Console.WriteLine("固体");
            }else if(temperature < 100.0){
                Console.WriteLine("液体");
            }else{
                Console.WriteLine("気体");
            }
        }
    }
}