namespace MyApplication
{
    class MethodParameter
    {
        public void MyMethod(string child1, string child2, string child3)
        {
            System.Console.WriteLine("The youngest child is " + child3);
        }
    }
    class Abc
    {
        public void printName()
        {
            Console.WriteLine("You are a Web Developer!");
        }
        public void login(string userName, string password)
        {
            if (userName == "Vipul" && password == "1234")
            {
                Console.WriteLine("You are logged in!");
            }
            else
            {
                Console.WriteLine("Invalid username or password!");
            }
        }
    }

}
namespace MyApplication
{
    class WebApp
    {
        static void MyMethod(string child1, string child2, string child3)
        {
            System.Console.WriteLine("The youngest child is " + child3);
        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            Abc obj = new Abc();
            pg.printName();
            obj.printName();
            Console.WriteLine();
            var userName = "Vipul";
            var password = "1234";
            obj.login(userName, password);
            // MethodParameter mp = new MethodParameter();
            WebApp.MyMethod(child3: "a", child1: "b", child2: "c");
        }
    }
}