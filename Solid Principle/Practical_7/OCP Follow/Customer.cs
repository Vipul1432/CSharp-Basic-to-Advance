namespace Practical_7.OCP_Follow
{
    public enum CustomerType
    {
        Gold,
        Silver,
        Bronze,
        Normal
    }
    public interface ICustomerDiscount
    {
        decimal CustomerTotal(decimal subTotal);
    }
    public class GoldCustomer : ICustomerDiscount
    {
        public decimal CustomerTotal(decimal subTotal)
        {
            return subTotal - (subTotal * .50M);
        }
    }
    public class SilverCustomer : ICustomerDiscount
    {
        public decimal CustomerTotal(decimal subTotal)
        {
            return subTotal - (subTotal * .40M);
        }
    }
    public class BronzeCustomer : ICustomerDiscount
    {
        public decimal CustomerTotal(decimal subTotal)
        {
            return subTotal - (subTotal * .30M);
        }
    }
    internal class Customer
    {
        public decimal CustomerTotal(decimal subTotal)
        {
            return subTotal - (subTotal * .20M);
        }
    }
}
