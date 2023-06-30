// C# program to illustrate
// the static variables
using System;
class static_variable
{

    // static variable salary
    static double salary;
    static String name = "Vipul";

    // Main Method
    public static void Main(String[] args)
    {

        // accessing static variable
        // without object
        static_variable.salary = 100000;

        Console.WriteLine(static_variable.name + "'s average salary : "
                                               + static_variable.salary);
    }
}