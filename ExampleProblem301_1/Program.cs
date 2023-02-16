// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
namespace ExampleProblem301_1{
    class program{
        static void Main(string[] args){
            Console.Write("★の数を入力:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++){
                Console.Write("★");
            }
            Console.WriteLine();
        }
    }
}