using System;
namespace ConstructorValueTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
            obj1.Display();
            ParameterizedConstructor obj2 = new ParameterizedConstructor(20);
            obj2.Display();
            Console.ReadKey();
        }
    }

    public class ParameterizedConstructor
    {
        int x;
        public ParameterizedConstructor(int i)
        {
            //Initializing the variable
            x = i;
            Console.WriteLine($"Parameterized Constructor is Called : {i}");
        }
        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
}