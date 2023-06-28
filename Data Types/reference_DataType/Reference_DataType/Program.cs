// C# program to demonstrate
// the Reference data types
using System;
namespace Reference_DataType
{

    class Program
    {

        // Main Function
        static void Main()
        {

            // declaring string
            string a = "Vipul";

            //append in a
            a += " ";
            a = a + "Kumar";
            Console.WriteLine(a);

            // declare object obj
            object obj;
            obj = 23;
            Console.WriteLine(obj);

            // to show type of object
            // using GetType()
            Console.WriteLine(obj.GetType());
        }
    }
}