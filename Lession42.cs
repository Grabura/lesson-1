using System;
using System.Collections.Generic;
using System.Text;

namespace Lession42
{
    class Program
    {
        static void Main(string[] args)
        {
           
            {
                Console.OutputEncoding = Encoding.UTF8;

                ShowProgrammFunctionality();

                string data = RecieveData();
                List<string> parts = SplitData(data);
                List<int> numbers = TransformData(parts);
                int result = CalculateData(numbers);
                DisplayResult(result);
            }

            static void ShowProgrammFunctionality()
            {
                Console.WriteLine("Enter numbers, using Space between them.");
            }

             static string RecieveData()
            {
                Console.Write("Enter the string and press Enter ");
                return Console.ReadLine();
            }

             static List<string> SplitData(string data)
            {
                List<string> parts = new List<string>();
                if (string.IsNullOrWhiteSpace(data))
                {
                    return parts;
                }
                parts.AddRange(data.Split(' '));
                return parts;
            }

             static List<int> TransformData(List<string> parts)
            {
                List<int> numbers = new List<int>();
                foreach (var part in parts)
                {
                    if (int.TryParse(part, out int number))
                    {
                        numbers.Add(number);
                    }
                }
                return numbers;
            }

             static int CalculateData(List<int> numbers)
            {
                int result = 0;
                foreach (var number in numbers)
                {
                    result += number;
                }
                return result;
            }

             static void DisplayResult(int result)
            {
                Console.WriteLine("Sum numbers : " + result);
            }
        }
    }

}
  