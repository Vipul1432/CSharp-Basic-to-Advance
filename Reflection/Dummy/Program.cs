using System.Globalization;

namespace Dummy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guid g = Guid.NewGuid();
            Console.WriteLine(g.ToString("N"));
            Console.WriteLine(15.88.ToString("C3", CultureInfo.CurrentCulture));
        }
    }
}