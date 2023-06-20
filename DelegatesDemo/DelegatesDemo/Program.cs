namespace DelegatesDemo
{
    internal class Program
    {
        //! Creating Delegate
        public delegate void myDelegate(string s);
        static void Display(string s)
        {
            Console.WriteLine($"Hello {s}");
        }
        static void Main(string[] args)
        {
            //! Intantiating Delegate
            myDelegate delegateObj = new myDelegate(Display);
            //! Invoking delegates 
            delegateObj("Mr.Vipul");
            DelegateClass obj = new DelegateClass();
            //! Instantiating Delegate from different class
            myDelegate myDelegateObj = new myDelegate(obj.MyMethod);
            myDelegateObj("Mr.Vipul");
        }
    }
    internal class DelegateClass
    {
        public void MyMethod(string s)
        {
            Console.WriteLine($"Hi {s}");
        }
    }
}