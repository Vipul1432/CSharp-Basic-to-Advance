using System.Collections;
using System.Diagnostics;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            myClass.Value = 1;
            Console.WriteLine(myClass.Value);


            List<int> ListGeneric = new List<int> { 5, 9, 1, 4 };
            //non-generic list
            ArrayList ListNonGeneric = new ArrayList { 5, 9, 1, 4 };
            // timer for generic list sort
            Stopwatch s = Stopwatch.StartNew();
            ListGeneric.Sort();
            s.Stop();
            Console.WriteLine($"Generic Sort: {ListGeneric}  \n Time taken: {s.Elapsed.TotalMilliseconds}ms");

            //timer for non-generic list sort
            Stopwatch s2 = Stopwatch.StartNew();
            ListNonGeneric.Sort();
            s2.Stop();
            Console.WriteLine($"Non-Generic Sort: {ListNonGeneric}  \n Time taken: {s2.Elapsed.TotalMilliseconds}ms");

            MyClass<string> myGenericClass = new MyClass<string>
            {
                Message = "This is Something About me"
            };
            myGenericClass.GenericMethod("Vipul", "Ahmedabad");
        }
    }
    //! Generic Class
    internal class MyClass<T>
    {
        public T Value { get; set; }
        public T? Message;
        public void GenericMethod(T Name, T Location)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Location: {Location}");
        }
    }
}