namespace Practical_7.OCP_Not_Follow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            decimal Result = customer.GetTotal(5000, CustomerType.Gold);
            Console.WriteLine($"After Discount your bill is {Result}");
        }
    }
}
