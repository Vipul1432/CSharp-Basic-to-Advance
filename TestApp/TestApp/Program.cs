namespace TestApp
{
    public class Test
    {
        static void Main(String[] args)
        {
            Test2 test2 = new Test2();
            Console.WriteLine(Test2.Count);  // 5
            Console.WriteLine(Test2.Count2); // 4
            Test2.Count = 7;
            // test2.Count2 = 9;
            Console.WriteLine(Test2.Count); // 7
            Console.WriteLine(Test2.Count2); // 4

            Test2 newObj = new Test2();
            Console.WriteLine(Test2.Count); // 7
            Console.WriteLine(Test2.Count2); // 4
        }
        public class Test2
        {
            public static int? Count = 5;
            public const int Count2 = 4;
        }

    }
}
