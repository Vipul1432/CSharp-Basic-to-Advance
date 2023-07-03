namespace Practical_7.DIP_Follow
{
    public interface IMessage
    {
        void SendMessage();
    }
    public class Email : IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            //Send email
            Console.WriteLine("Mail Sent");
        }
    }
    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            //Send Sms
            Console.WriteLine("SMS  Sent");
        }
    }
    public class Notification
    {
        private ICollection<IMessage> _messages;

        public Notification()
        {
        }

        public Notification(ICollection<IMessage> messages)
        { 
            this._messages = messages;
        }
        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
