namespace LSP2
{
    internal class AdminUser
    {
        public virtual void Write()
        {
            Console.WriteLine("Admin user Write");
        }
        public virtual void Read()
        {
            Console.WriteLine("Admin User Read");
        }
    }
    internal class NormalUser
    {
        public virtual void Read()
        {
            Console.WriteLine("Normal User Read");
        }
    }

    internal class AdminUserAccessData : AdminUser
    {
        public override void Read()
        {
            Console.WriteLine("Normal User Access data");
        }
        public override void Write()
        {
            Console.WriteLine("Normal User Access data");
        }
    }
    internal class NormalUserAccessData : NormalUser
    {
        public override void Read()
        {
            Console.WriteLine("Normal User Access data");
        }
    }
}

