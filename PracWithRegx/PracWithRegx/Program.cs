using System.Text.RegularExpressions;

namespace PracWithRegx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? Input_1 = string.Empty;
            string? Input_2 = string.Empty;
            do
            {
                Console.Write("Enter number : ");
                Input_1 = Console.ReadLine();
            }
            while (!Regex.IsMatch(Input_1, @"^[+-]?\d+(\.\d+)?$"));
            do
            {
                Console.Write("Enter number : ");
                Input_2 = Console.ReadLine();
            }
            while (!Regex.IsMatch(Input_1, @"^[+-]?\d+(\.\d+)?$"));
            double Number_1 = Convert.ToDouble(Input_1);
            double Number_2 = Convert.ToDouble(Input_2);
            if (Number_2 != 0)
            {
                Console.WriteLine($"The sum of {Number_1} and {Number_2} is {Number_1 + Number_2}");
                Console.WriteLine($"The substraction of {Number_1} and {Number_2} is {Number_1 - Number_2}");
                Console.WriteLine($"The multiplication of {Number_1} and {Number_2} is {Number_1 * Number_2}");
                Console.WriteLine($"The division of {Number_1} and {Number_2} is {Number_1 / Number_2}");
            }
            else
            {
                Console.WriteLine($"The Number {Input_1} Can't Divide by 0");
            }
        }
    }
}