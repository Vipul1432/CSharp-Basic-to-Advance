namespace ParamsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSum(1, 2, 3, 4, 5);
        }
        static int Sum = 0;
        public static void CalculateSum(params int[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                Sum+= val[i];
            }
            Console.WriteLine(Sum);
        }
    }
}