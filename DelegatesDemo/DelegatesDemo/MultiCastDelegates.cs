namespace DelegatesDemo
{
    internal class Calculate
    {
        public virtual void Add(int a, int b)
        {
            Console.WriteLine($"Addition is {a + b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"Subtraction is {a - b}");
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine($"Multiplication is {a * b}");
        }
        public void Div(int a, int b)
        {
            Console.WriteLine($"Division is {a / b}");
        }
    }
    public delegate void CalculateDelegate(int a, int b);                                                                                                
    internal class MultiCastDelegates : Calculate
    {
        public static void Main()
        {
            //Calculate obj = new Calculate();
            MultiCastDelegates mcObj = new MultiCastDelegates();
            CalculateDelegate delegateObj = new CalculateDelegate(mcObj.Add);
            //! Multicast Delegates 
            delegateObj += mcObj.Sub;
            delegateObj += mcObj.Mul;
            delegateObj += mcObj.Div;
            delegateObj(20, 10);
        }


    }
}


using System;
namespace delegate_Example4
{

    class Program
    {
        public delegate void delmethod(int x, int y);

        public class TestMultipleDelegate
        {
            public void plus_Method1(int x, int y)
            {
                Console.Write("You are in plus_Method");
                Console.WriteLine(x + y);
            }

            public void subtract_Method2(int x, int y)
            {
                Console.Write("You are in subtract_Method");
                Console.WriteLine(x - y);
            }
        }

        static void Main(string[] args)
        {

            TestMultipleDelegate obj = new TestMultipleDelegate();
            delmethod del = new delmethod(obj.plus_Method1);

            // Here we have multicast
            del += new delmethod(obj.subtract_Method2);
            // plus_Method1 and subtract_Method2 are called
            del(50, 10);
            Console.WriteLine();
            //Here again we have multicast
            del -= new delmethod(obj.plus_Method1);
            //Only subtract_Method2 is called
            del(20, 10);
            Console.ReadLine();
        }
    }
}
