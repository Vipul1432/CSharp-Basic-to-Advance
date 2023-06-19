namespace BranchingDemo
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int i = 20;

            if (i == 10)
                Console.WriteLine("i is 10");
            else if (i == 15)
                Console.WriteLine("i is 15");
            else if (i == 20)
                Console.WriteLine("i is 20");
            else
                Console.WriteLine("i is not present");
        }
    }
}