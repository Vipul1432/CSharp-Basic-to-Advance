namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            // Variable length arguments 
            obj.show(10, 20, 30, 40, 50, 60);
        }
        // Variable length parameter using params keyword
        public void show(params int[] value)
        {
            int result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                result += value[i];
            }
            System.Console.WriteLine(result);
        }
    }
}