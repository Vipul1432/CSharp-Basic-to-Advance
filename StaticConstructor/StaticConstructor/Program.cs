using System;
namespace StaticConstructor
{
    public class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor Executed!");
        }

        StaticConstructor()
        {
            Console.WriteLine("This is Non Static Constructor");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Exceution Started...");
            StaticConstructor obj = new();
            Console.ReadKey();
        }
    }
}