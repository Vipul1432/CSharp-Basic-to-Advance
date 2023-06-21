using System;
using Calculator;

namespace ExtensionMethodDemo
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string str = "This is a string";
            Console.WriteLine(str.WordCount());
        }

        //! Extension Method of Calculator Class Libary
       public static int WordCount(this string str)
        {
            return str.Split(" ").Length;

        }
    }
}