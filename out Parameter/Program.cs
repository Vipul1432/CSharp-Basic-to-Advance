namespace MyApplication
{
    class Program
    {
        public void show(out int val)
        {
            int val2 = 10;
            val = val2;
            val *= val;
            System.Console.WriteLine(val);
        }
        static void Main(string[] args)
        {

            Program obj = new Program();
            System.Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            obj.show(out num);
        }
    }
}