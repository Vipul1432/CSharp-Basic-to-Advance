namespace Practical_7.OCP_Not_Follow
{
    internal class Customer
    {
            public decimal GetTotal(decimal subtotal, CustomerType customerType)
            {
                if (customerType == CustomerType.Gold)
                {
                    return subtotal - (subtotal * .50M);
                }
                else if (customerType == CustomerType.Silver)
                {
                    return subtotal - (subtotal * .40M);
                }
                else if (customerType == CustomerType.Bronze)
                {
                    return subtotal - (subtotal * .30M);
                }
                else if (customerType == CustomerType.Normal)
                {
                    return subtotal - (subtotal * .20M);
                }
                else
                {
                    return subtotal;
                }
            }
        }
        public enum CustomerType
        {
            Gold,
            Silver,
            Bronze,
            Normal
        }
}
