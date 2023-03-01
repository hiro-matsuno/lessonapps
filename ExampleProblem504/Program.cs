// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem504{
    class Program{
        static void Main(string[] args){
            Ship ship = new Ship();
            BattleShip battleShip = new BattleShip();
            ship.Sail();
            battleShip.Sail();
            battleShip.Fight();
        }
    }
}