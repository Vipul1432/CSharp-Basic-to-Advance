using System;

namespace obect2
{
    public class Calculate
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number : ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number : ");
            var y = Convert.ToInt32(Console.ReadLine());
            Calculate obj = new Calculate();
            var result = obj.Add(x, y);
            Console.WriteLine(result);
        }
    }
}
