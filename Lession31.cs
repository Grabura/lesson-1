using System;

namespace lession31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random ran = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int a = 0; a < array.GetLength(1); a++)
                {
                    array[i, a] = ran.Next(1, 9);
                    Console.WriteLine(/*Array elements diagonally*/);
                }
            }

            Console.ReadKey();
                

        }
    }
}
