using System;

namespace DictionaryDemo2
{
    internal class DemoClass
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(1, "Vipul");
            names.Add(2, "Bhavin");
            names.Add(3, "Jil");
            foreach (KeyValuePair<int, string> kvp in names)
            {
                Console.WriteLine($"Id : {kvp.Key} \nName : {kvp.Value}");
            }
            SecondClass sc = new();
            sc.MyDictionaryMethod();
        }
    }

    class SecondClass
    {
        public void MyDictionaryMethod()
        {
        Customer customer1 = new Customer()
        {
            ID = 153,
            Name = "Vipul",
            Salary = 5000
        };
        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "Bhavin",
            Salary = 5500
        };
        Customer customer3 = new Customer()
        {
            ID = 43,
            Name = "Jil",
            Salary = 6000
        };
        Customer[] customer = new Customer[3];
        customer[0] = customer1;
        customer[1] = customer2;
        customer[2] = customer3;
        Dictionary<int, Customer> dict = customer.ToDictionary(customer => customer.ID, customer => customer);
            foreach (KeyValuePair<int, Customer> kvp in dict)
            {
                Customer cust = kvp.Value;
                Console.WriteLine($"ID : {cust.ID} \nName : {cust.Name} \nSalary : {cust.Salary}");
            }
        }
    }
    internal class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
