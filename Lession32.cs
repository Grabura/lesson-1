using System;

namespace Lession32
{
    using System;

    namespace PhoneList
    {
        class Program
        {                
                 
            private static int n = 4;
            private static int m = 5;
            private static string[,] phoneList = new string[n, m];

            static void Main()
            { 
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter phone number and e-mail: ");
                    string number = Console.ReadLine();

                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < m; j++)
                            if (phoneList[i, j] == null)
                            {
                                phoneList[i, j] = string.Format("{0} {1}", name, number);
                                Console.WriteLine("Записанно!");
                                Console.WriteLine();
                                return;
                            }
            }
        }
    }
}


    