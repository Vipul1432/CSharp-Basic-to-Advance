using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Practical_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int YourChoice;
            Student student = new Student();
            do
            {
                Console.Write("Enter Student Name : ");
                student.Name = Console.ReadLine();
            } while ((!Regex.IsMatch(student.Name, @"^[\p{L} \.\-]+$")));
            for(int i = 0; i <5; i++)
            {
                do
                {
                    Console.Write($"Enter {i+1} Subject Marks : ");
                } while(!(decimal.TryParse(Console.ReadLine(), out student.Marks[i]) && student.Marks[i] <=100 && student.Marks[i] >= 0));
            }
            Console.WriteLine("Select 1,2,3,4");
            Console.WriteLine("1 - Aggregate");
            Console.WriteLine("2 - MinMark");
            Console.WriteLine("3 - MaximumMark");
            Console.WriteLine("4 - Grade");
            do
            {
                Console.Write($"Enter Your Choice : ");
            } while (!(int.TryParse(Console.ReadLine(), out YourChoice) && YourChoice <= 4 && YourChoice >= 0));
         
            if(YourChoice == (int)Options.Aggregate)
            {
                student.CalculateAverageMarks();
                Console.WriteLine($"{student.Name} : {Student.AverageMarks}");
            }
            if (YourChoice == (int)Options.MinMark)
            {
                Console.WriteLine(student.Marks.Min());
            }
            if (YourChoice == (int)Options.MinMark)
            {
                Console.WriteLine(student.Marks.Max());
            }
            if (YourChoice == (int)Options.Grade)
            {
                //Console.WriteLine(student.Marks.Max());
            }
        }
    }
}