using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem406{
    class Bingo{
        private int[,] data;
        private int size;
        private void Clear(){
            for(int i=0;i < size;i++){
                for(int j=0; j < size; j++){
                    data[i,j] = 0;
                }
            }
        }

        private void Shuffle(){
            Random rnd = new Random();
            int num = 1;
            while(num <= size * size){
                while(true){
                    int m = rnd.Next(size);
                    int n = rnd.Next(size);

                    
                }
            }
        }
    }
}