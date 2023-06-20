namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
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
            Dictionary<int, Customer> dictionaryCustomer = new Dictionary<int, Customer>();
            dictionaryCustomer.Add(customer1.ID, customer1);
            dictionaryCustomer.Add(customer2.ID, customer2);
            dictionaryCustomer.Add(customer3.ID, customer3);

            Customer customer153 = dictionaryCustomer[153];
            Console.WriteLine($"ID : {customer1.ID} \nName : {customer1.Name} \nSalary : {customer1.Salary}");
            foreach (KeyValuePair<int, Customer> keyValuePairValue in dictionaryCustomer)
            {
                Customer cust = keyValuePairValue.Value;
                Console.WriteLine($"Id : {cust.ID} \nName : {cust.Name} \nSalary : {cust.Salary}");
                //! Count Property will return the number of key-value pair present in dictionary
                Console.WriteLine(dictionaryCustomer.Count);
                //! Count Method will return count with based on some condition
                Console.WriteLine($"{dictionaryCustomer.Count(kvp => kvp.Value.Salary > 5000)}");
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