namespace Practical_7.DIP_Not_Follow
{
    public class Email
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            //Send email
            Console.WriteLine("Mail Sent");
        }
    }
    public class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            //Send sms
            Console.WriteLine("SMS Sent");
        }
    }
    public class Notification
    {
        private Email _email;
        private SMS _sms;
        public Notification()
        {
            _email = new Email();
            _sms = new SMS();
        }
        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}
