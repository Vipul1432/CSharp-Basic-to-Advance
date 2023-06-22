namespace Ilogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application application = new Application(new DatabaseLogger());
            application.DoSomething();
        }
    }
    public interface ILogger
    {
        public void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // Log message to a file
            Console.WriteLine("FileLogger");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Log message to a database
            Console.WriteLine("DatabaseLogger");
            Console.WriteLine(message);
        }
    }

    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoSomething()
        {
            // Do something

            _logger.Log("Did something");
        }
    }

}