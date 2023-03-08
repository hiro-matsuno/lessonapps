using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample503{
    class ExCalculator : Calculatar{
        public void Mul(){
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }

        public void Div(){
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        }
    }
}