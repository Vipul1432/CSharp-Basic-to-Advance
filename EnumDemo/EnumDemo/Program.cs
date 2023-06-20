using System;
using System.ComponentModel;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine((int)WeekDays.Sunday);
            Console.WriteLine((int)WeekDays.Tuesday);
            Console.WriteLine((int)WeekDays.Wednesday);
            Console.WriteLine(WeekDays.Thursday);
            Console.WriteLine((int)WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Saturday);

            Console.ReadKey();
        }
    }

    public enum WeekDays
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}