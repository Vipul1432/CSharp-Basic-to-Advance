namespace InOutRefDemo
{
    internal class Program
    {
        //public static string GetNextName(ref int num)
        //{
        //    string returnText = "Next-" + num.ToString();
        //    num += 1;
        //    return returnText;
        //}
        //static void Main(string[] args)
        //{
        //    int i = 1;
        //    Console.WriteLine("Previous value of integer i:" + i.ToString());
        //    string test = GetNextName(ref i);
        //    Console.WriteLine("Current value of integer i:" + i.ToString());

        //    try
        //    {
        //        int x = 10;
        //        int y = 0;
        //        Console.WriteLine(x / y);
        //    }catch(Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        Console.WriteLine(e.StackTrace);
        //        Console.WriteLine("***************************************-");
        //        Console.WriteLine(e.HelpLink);
        //    }

        //    Console.ReadKey();
        //}

        public static string GetNextNameByOut(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Previous value of integer i:" + i.ToString());
            string test = GetNextNameByOut(out i);
            Console.WriteLine("Current value of integer i:" + i.ToString());
        }
    }
}