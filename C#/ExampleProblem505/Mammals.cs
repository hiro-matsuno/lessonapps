using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem505{
    abstract class Mammals{
        protected string name = "";

        public abstract void Bark();

        public void ShowName(){
            Console.WriteLine("名前:{0}", name);
        }
    }
}