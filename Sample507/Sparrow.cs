using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample507{
    class Sparrow{
        private string name = "すずめ";

        public void Sing(){
            Console.WriteLine("チュンチュン");
        }

        public String Name{
            get{ return name; }
        }
    }
}