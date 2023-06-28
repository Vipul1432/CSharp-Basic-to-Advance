using System;

namespace PartialClass_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass partial = new PartialClass();
            partial.FirstName = "Vipul";
            partial.LastName = "Kumar";
            partial.FullName();

            Console.ReadLine();
        }
    }
}