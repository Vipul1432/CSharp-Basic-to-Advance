using System.Text.RegularExpressions;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                string? Input_1;
                string? Input_2;
                do {
                    Console.WriteLine();
                    do
                    {
                        Console.Write("Please Enter First number : ");
                        Input_1 = Console.ReadLine();
                    }
                    while (!Regex.IsMatch(Input_1, @"^[+-]?\d+(\.\d+)?$"));
                    do
                    {
                        Console.Write("Please Enter Second number : ");
                        Input_2 = Console.ReadLine();
                    }
                    while (!Regex.IsMatch(Input_1, @"^[+-]?\d+(\.\d+)?$"));
                    double Number_1 = Convert.ToDouble(Input_1);
                    double Number_2 = Convert.ToDouble(Input_2);
                if (Number_2 != 0)
                {
                    Console.WriteLine($"The sum of {Number_1} and {Input_2} is {Math.Round((Number_1 + Number_2), 4)}");
                    Console.WriteLine($"The subtraction  of {Number_1} and {Input_2} is {Math.Round((Number_1 - Number_2), 4)}");
                    Console.WriteLine($"The multiplication of {Number_1} and {Input_2} is {Math.Round((Number_1 * Number_2), 4)}");
                    Console.WriteLine($"The division  of {Number_1} and {Input_2} is {Math.Round((Number_1 / Number_2), 4)}");
                }
                else
                {
                    Console.WriteLine($"The {Input_1} can't Divide by 0");
                }
                    Console.Write("Do you want to continue : y/n => ");
                }
            while (Console.ReadKey().KeyChar.ToString().ToLower() == "y");
            }
        }
    }
}