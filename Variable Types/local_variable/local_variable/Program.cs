using System;
using System.IO;

namespace local_variable
{
    internal class Program
    {
        public void StudentAge()
        {

            // local variable age
            int age;

            age = 23;
            Console.WriteLine("Student age is : " + age);
        }

        // Main Method
        public static void Main(String[] args)
        {

            // Creating object
            Program obj = new Program();

            // calling the function
            obj.StudentAge();

            // using local variable age outside it's scope
            //Console.WriteLine("Student age is : " + age);       // It's give an error
        }
    }
}
