// C# program to illustrate the
// initialization of readonly
// variables twice
using System;
class readOnly_variable
{

    // instance variable
    int a = 80;

    // static variable
    static int b = 40;

    // Constant variables
    const float max = 50;

    // readonly variables
    readonly int k;

    // constructor
    public readOnly_variable()
    {

        // first time initializing
        // readonly variable k
        this.k = 90;
    }

    // Main Method
    public static void Main()
    {

        // Creating object
        readOnly_variable obj = new readOnly_variable();

        Console.WriteLine("The value of a is = " + obj.a);
        Console.WriteLine("The value of b is = " + readOnly_variable.b);
        Console.WriteLine("The value of max is = " + readOnly_variable.max);

        // initializing readonly variable again
        // will compile time error
       // obj.k = 55;

        Console.WriteLine("The value of k is = " + obj.k);
    }
}