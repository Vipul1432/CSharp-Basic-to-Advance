using System;
namespace CopyConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor obj1 = new CopyConstructor(10);
            obj1.Display();
            CopyConstructor obj2 = new CopyConstructor(obj1);
            obj2.Display();
            Console.ReadKey();
        }
    }

    public class CopyConstructor
    {
        int x;

        //Parameterized Constructor
        public CopyConstructor(int i)
        {
            x = i;
        }

        //Copy Constructor
        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
        }

        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
}