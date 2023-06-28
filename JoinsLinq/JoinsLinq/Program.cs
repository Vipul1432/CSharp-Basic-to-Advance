namespace JoinsLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var SelectQuery = Data.EmpList.Where(emp => emp.DOB == DateOnly.Parse("09-02-1999"));

            foreach (var item in SelectQuery)
            {
                Console.WriteLine($"Id : {item.ID} Name : {item.Name} Date of Birth {item.DOB}");
            }
        }
    }
}