using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name");

            var userName = Console.ReadLine();           

            Console.WriteLine($"Hello {userName}! today is: ");
            Console.WriteLine(DateTime.Now);




        }
    }
}
