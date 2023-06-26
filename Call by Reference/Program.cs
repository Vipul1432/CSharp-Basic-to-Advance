using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            System.Console.Write("Enter a number : ");
            int num = Convert.ToInt32(System.Console.ReadLine());
            int result = 1;
            Factorial(ref num, ref result);
            System.Console.WriteLine("Factorial of {0} is {1}", num, result);
        }

        public static void Factorial(ref int num, ref int result)
        {
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
        }
    }
}