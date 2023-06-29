namespace MyApplication
{
    class GrandParent
    {
        public GrandParent()
        {
            System.Console.WriteLine("This is Grand Parent Constructor");
        }
        public void Method()
        {
            System.Console.WriteLine("This is Grand Parent Method");
        }
    }

    class Parent : GrandParent
    {
        public Parent()
        {
            System.Console.WriteLine("This is Parent Constructor");
        }
        public new void Method()
        {
            base.Method();
            System.Console.WriteLine("This is Parent Method");
        }
    }
    class Child : Parent
    {
        public Child()
        {
            System.Console.WriteLine("This is Child Constructor");
        }
        public new void Method()
        {
            base.Method();
            System.Console.WriteLine("This is Child Method");
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.Method();
            System.Console.WriteLine();

        }
    }
}
