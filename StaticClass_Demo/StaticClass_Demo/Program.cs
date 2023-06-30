using System;

namespace StaticClass_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Inchs to Centimeters.");
            Console.WriteLine("2. From Centimeters to Inchs.");

            string selection = Console.ReadLine();
            double C, I = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the height in inchs: ");
                    C = HeightConvertor.InchsToCentimeters(Console.ReadLine());
                    Console.WriteLine("Hieght in centimeters: {0:F2}", C);
                    break;

                case "2":
                    Console.Write("Please enter the Height in centimeters: ");
                    I = HeightConvertor.CentimetesToInchs(Console.ReadLine());
                    Console.WriteLine("Height in Inchs: {0:F2}", I);
                    break;

                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}