using System.Diagnostics;

namespace StructVsClass
{
    internal class TestClass
    {
        public int num1, num2;
        public TestClass(int n1, int n2) 
        {
            this.num1 = n1;
            this.num2 = n2;
        }
        public void ShowValues()
        {
            Console.WriteLine("{0}, {1}", this.num1, this.num2);
        }
    }
    internal struct TestStruct
    {
        public int num1, num2;
        public TestStruct(int n1, int n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }
        public void ShowValues()
        {
            Console.WriteLine("{0}, {1}", this.num1, this.num2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new(10,20);
            Console.WriteLine("After Class Object Created...");
            testClass.ShowValues();
            ModifyClassValue(testClass);
            Console.WriteLine("After Modify Value Method Invoked...");
            testClass.ShowValues();

            Console.WriteLine("------------------------------------------");

            TestStruct testStruct = new(10, 20);
            Console.WriteLine("After Struct Object Created...");
            testStruct.ShowValues();
            ModifyClassValue(testStruct);
            Console.WriteLine("After Modify Value Method Invoked...");
            testStruct.ShowValues();

        }

        private static void ModifyClassValue(TestStruct testStruct)
        {
            testStruct.num1 += 100;
            testStruct.num2 += 100;
            Console.WriteLine("Within Struct Modify Value {0},{1}", testStruct.num1, testStruct.num2);
        }

        private static void ModifyClassValue(TestClass testClass)
        {
            testClass.num1 += 100;
            testClass.num2 += 100;
            Console.WriteLine("Within Class Modify Value {0},{1}", testClass.num1, testClass.num2);
            Console.WriteLine("Thread Count");
            Console.WriteLine(Process.GetCurrentProcess().Threads.Count);
        }
    }
}