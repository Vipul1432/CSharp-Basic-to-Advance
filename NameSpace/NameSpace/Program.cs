using System;
using First;
using NameSpace;
namespace First
{
    public class Hello
    {
        public void SayHello() { Console.WriteLine("Hello First Namespace"); }
    }
}
namespace Second
{
    public static class Hello
    {
        public static void SayHello() { Console.WriteLine("Hello Second Namespace"); }
    }
}
namespace TestNameSpace
{
    public static class Program
    {
        public static void Main()
        {
            // Create instance and access it
            Hello h1 = new();
            NamespaceClass nc = new();

            // Calling method using object instance
            h1.SayHello();
            nc.NamespaceMethod();

            // Accessing static method in static class using class name
            Second.Hello.SayHello();
        }
    }
}