namespace MyApplication
{
    class Program
    {
        public static void squareFun(int a)
        {
            int result = a * a;
            System.Console.WriteLine("Square of {0} is " + result, a);
        }
        static void Main(string[] args)
        {
            System.Console.Write("Enter value of a :  ");
            int a = Convert.ToInt32(Console.ReadLine());
            squareFun(a);
        }
    }
}
