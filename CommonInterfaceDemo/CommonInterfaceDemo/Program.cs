// C# Program to show the use of
// Explicit interface implementation
using System;

interface I1
{
    void printMethod();
}

interface I2
{
    void printMethod();
}

// class C implements two interfaces
class C : I1, I2
{

    // Explicitly implements method of I1
    void I1.printMethod()
    {
        Console.WriteLine("I1 printMethod");
    }

    // Explicitly implements method of I2
    void I2.printMethod()
    {
        Console.WriteLine("I2 printMethod");
    }
}

class Program
{
    static void Main(string[] args)
    {
        I1 i1 = new C();
        I2 i2 = new C();

        // call to method of I1 interface
        i1.printMethod();

        // call to method of I2 interface
        i2.printMethod();
    }
}
