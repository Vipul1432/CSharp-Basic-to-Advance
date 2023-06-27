using System;
namespace ConstructorDemo
{
    public static class ConstructorsDemo
    {
        public static int x = 5; //It is going to be initialized by static constructor
        
        //Static Constructor
        static ConstructorsDemo()
        {
            //This constructor initialized the static variable x with default value i.e. 0
            Console.WriteLine("Static Constructor is Called");
        }
        static void Main(string[] args)
        {
            //Before Executing the body of Main Method, Static Constructor is executed
            Console.WriteLine("Main Method Body..");
            x = 10;
            Console.WriteLine(NewClass.y);
            Console.WriteLine(x);
            Console.WriteLine(Int64.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.ReadKey();
            
        }

    }
    class NewClass
    {
        static NewClass()
        {
            ConstructorsDemo.x = 15;
        }
        public static int y = 1;
    }
}
