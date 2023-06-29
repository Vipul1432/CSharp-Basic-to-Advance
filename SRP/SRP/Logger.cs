using System;
namespace SRP_Follow
{
    public interface ILogger
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }

    public class Logger : ILogger
    {
        public Logger()
        {
            // here write the Code for initialization 
            // that is Creating the Log file with necesssary details
        }
        public void Info(string info)
        {
            // here write the Code for info information into the ErrorLog text file
        }
        public void Debug(string info)
        {
            // here write the Code for Debug information into the ErrorLog text file
        }
        public void Error(string message, Exception ex)
        {
            // here write the Code for Error information into the ErrorLog text file
        }
    }
}