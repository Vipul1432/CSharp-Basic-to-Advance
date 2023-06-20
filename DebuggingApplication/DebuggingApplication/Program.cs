namespace DebuggingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? userResponse;
            userResponse = Console.ReadLine();
            if (Convert.ToBoolean(int.Parse(userResponse)))
            {
                Console.WriteLine(userResponse);
            }
        }
    }
}