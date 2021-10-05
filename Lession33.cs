using System;

namespace Lession33
{
    class Program
    {
        static void Main(string[] args)
        {

            string str;

            Console.WriteLine("Enter words: ");
            str = Console.ReadLine();

            if (str != "")
            {
                for (int i = str.Length; i > 0; i--)
                {
                    Console.Write(str[i - 1]);
                }
            }
            Console.ReadKey();

        }
    }
}
           
