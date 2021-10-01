using System;

namespace Lession21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter minimum temperature");
            string mint = Console.ReadLine();
            int a = int.Parse(mint);

            Console.WriteLine("Please, enter maximum temperature");
            string maxt = Console.ReadLine();
            int b = int.Parse(maxt);

            int c = (a + b)/2;

            Console.WriteLine($"Average daily temperature is {c}");

            Console.ReadLine();

        }
    }
}
