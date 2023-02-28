using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample507{
    class Crow{
        private string name = "カラス";
        
        public void Sing(){
            Console.WriteLine("カーカー");
        }

        public String Name{
            get{return name;}
        }
    }    
}