namespace Practical_7.OCP_Follow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomerDiscount obj = new BronzeCustomer();
            decimal Total = obj.CustomerTotal(200);
            Console.WriteLine($"After Discount Amount is : {Total}");
        }
    }
}
