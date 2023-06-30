
namespace TuplesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //! Generic Tuple Class  (Immutable 
            Tuple<int,string> obj = new Tuple<int,string>(123, "Vipul");
            Console.WriteLine(obj.Item1);
            Console.WriteLine(obj.Item2);
            
            var tupleObj = Tuple.Create(123,"Mr.Vipul");
            Console.WriteLine(tupleObj.Item1);
            Console.WriteLine(tupleObj.Item2);

            //! Value Tuple (Mutable)
            var valueObj = (123, "Vipul Kumar");
            Console.WriteLine(valueObj.Item1);
            Console.WriteLine(valueObj.Item2);
            valueObj.Item1 = 153;
            Console.WriteLine(valueObj.Item1);

            Console.WriteLine("-------------------------");

            //! Name Tuple (Mutable)
            var nameObj = (Empname : "Mr.Vipul", empId:123);
            Console.WriteLine(nameObj.Empname);
            Console.WriteLine(nameObj.empId);
            nameObj.Empname = "Vipul";
            nameObj.empId = 153;
            Console.WriteLine(nameObj.Empname);
            Console.WriteLine(nameObj.empId);
        }
    }
}