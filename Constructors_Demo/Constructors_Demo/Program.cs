using System;
namespace Constructors_Demo
{
    class Customer
    {
        // Member Variables
        public string Name;

        //Constructor for initializing fields
        public Customer(string fname, string lname)
        {
            Name = fname + " " + lname;
        }
        //method for displaying customer records
        public void AppendData()
        {
            Console.WriteLine(Name);
        }
        //Entry point
        static void Main(string[] args)
        {
            // object instantiation
            Customer obj = new Customer("Vipul", "Kumar");

            //Method calling
            obj.AppendData();
        }
    }
}