using System;

namespace Lession41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Smith", "Whitny", "Djim"));
            Console.WriteLine(GetFullName("Wiliams", "Wiliyam", "Andi"));
            Console.WriteLine(GetFullName("McQuwin", "Aleks", "Glen"));

        }
        static string GetFullName(string LastName, string FirstName, string SecondName)

        {
            return $"{ LastName} {FirstName},{SecondName}";
        }
    }
}


    


