using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float price = 14.5f;
            char character = 'V';
            string firstName = "Vipul";
            bool isWorking = false;
            var number2 = 5;
            var count2 = 20;
            var price2 = 7.9f;
            var name = "Vipul Kumar";
            var gender = 'M';
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(price);
            Console.WriteLine(firstName);
            Console.WriteLine(character);
            Console.WriteLine(isWorking);
            Console.WriteLine("----------------------");
            Console.WriteLine(number2);
            Console.WriteLine(count2);
            Console.WriteLine(price2);
            Console.WriteLine(name);
            Console.WriteLine(gender);
            Console.WriteLine("----------------------");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}
