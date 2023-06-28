// Note: This program will not work on
// online compiler
// Error: Unsafe code requires the `unsafe'
// command line option to be specified
// For its solution:
// Go to your project properties page and
// check under Build the checkbox Allow
// unsafe code.
using System;
namespace Pointer_DataType
{

    class Program
    {

        // Main function
        static void Main()
        {
            unsafe
            {

                // declare variable
                int n = 10;

                // store variable n address
                // location in pointer variable p
                int* p = &n;
                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)p);
            }
        }
    }
}