namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 23;

            //! boxing (Convert Value Type to refrence type)
            object obj = num;

            //! unboxing (Convert refrence Type to Value type
            int i = (int)obj;

            //! Display result
            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);
        }
    }
    }
}