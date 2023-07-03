namespace Practical_7.DIP_Follow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessage email = new Email();
            email.SendMessage();
            IMessage sms = new SMS();
            sms.SendMessage();
            sms.SendMessage();
        }
    }
}
