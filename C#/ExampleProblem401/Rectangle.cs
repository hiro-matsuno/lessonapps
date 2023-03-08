using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem401{
    class Rectangle{
        public double width;
        public double height;
        public double GetArea(){
            return width * height;
        }

        public double GetPerimeter(){
            return width * 2 + height * 2;
        }
    }
}