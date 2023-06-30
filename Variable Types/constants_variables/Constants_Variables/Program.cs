// C# program to illustrate the
// constant variable
using System;
class Program
{

    // instance variable
    int a = 10;

    // static variable
    static int b = 20;

    // constant variable
    const float max = 50;
    const int x = 100;

    // Main Method
    public static void Main(String[] args)
    {
        
        // creating object
        Program obj = new Program();

        // displaying result
        Console.WriteLine("The value of a is = " + obj.a);
        Console.WriteLine("The value of b is = " + Program.b);
        Console.WriteLine("The value of max is = " + Program.max);
        Console.WriteLine(max + " " + obj.a + " " + b + " " + x);
    }
}