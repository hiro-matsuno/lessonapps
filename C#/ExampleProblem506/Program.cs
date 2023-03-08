// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem506{
    class Program{
        static void DriveACar(Car car){
            car.Drive();
        }

        static void MaintainACar(Car car){
            car.Maintain();
        }

        static void Main(string[] args){
            Car c = new Car();
            DriveACar(c);
            MaintainACar(c);
        }

    }
}