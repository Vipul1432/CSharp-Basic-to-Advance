namespace Fibonacci
{
    internal class Program
    {
        static void Fibonacci(int N)
        {
            int num1 = 0, num2 = 1; int counter = 0;

            while (counter < N)
            {
                Console.Write(num1 + " ");

                int num3 = num2 + num1;
                num1 = num2;
                num2 = num3;
                counter = counter + 1;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}


//int Fib(int n)`
//{
//    if (n == 0 || n == 1)
//    {
//        return n;
//    }
//    return Fib(n - 1) + Fib(n - 2);
//}

//int i = 0;
//int n = 10;

//while (i > n)
//{
//    Console.WriteLine(Fib(i));
//    i++;
//}

