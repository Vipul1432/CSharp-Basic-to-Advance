namespace StringParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "100";
            string str2 = null;
            Console.WriteLine(Convert.ToString(str));
            Console.WriteLine(int.Parse(str));
            Console.WriteLine(Convert.ToInt32(str2));
            // It will give an error 
            //Console.WriteLine(int.Parse(str2);
        }
    }
}