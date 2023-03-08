using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem404{
    class Rectangle{
        private double height;
        private double width;

        public double GetArea(){
            return width * height;
        }

        public double GetPerimeter(){
            return width * 2 + height * 2;
        }

        public double Width{
            set{width = value;} 
            get{return width;}
        }

        public double Height{
            set{height = value;}
            get{return height;}
        }
    }
}