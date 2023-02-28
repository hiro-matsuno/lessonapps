using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample504{
    class Sub : Super{
        public Sub(){
            Console.WriteLine("Subクラスのコンストラクタ（引数なし）");
        }

        public Sub(int param) :base(param){
            Console.WriteLine("Subクラスのコンストラクタ（param = {0}）",param);
        }

        ~Sub(){
            Console.WriteLine("Subクラスのデストラクタ");
        }
    }
}