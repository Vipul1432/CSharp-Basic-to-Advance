using System;

namespace Object
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName +" " +lastName);
            Console.WriteLine("I am "+ age + "years old");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new Person();
            obj.firstName = "Vipul";
            obj.lastName = "Kumar";
            obj.age = 21;
            obj.Introduce();
        }
    }
}
