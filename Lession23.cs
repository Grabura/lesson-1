using System;

namespace Lession23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int x = int.Parse(Console.ReadLine());
            if ((x & 1) == 0) Console.WriteLine("Even...");
            else Console.WriteLine("odd...");
        }
    }
}
