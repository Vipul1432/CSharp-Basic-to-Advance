using System;
namespace ParameterizedConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedConstructor obj = new ParameterizedConstructor(153);
            Console.ReadKey();
        }
    }

    public class ParameterizedConstructor
    {
        public ParameterizedConstructor(int i)
        {
            Console.WriteLine($"Parameterized Constructor is Called: {i}");
        }
    }
}