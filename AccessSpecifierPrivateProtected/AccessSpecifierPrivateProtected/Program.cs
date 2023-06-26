using AssemblyOne;
using System;
namespace AccessSpecifierPrivateProtected
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class AnotherAssemblyClass1 : AssemblyOneClass1
    {
        public void Display4()
        {
            //We cannot access Private Protected Member from Derived Classes
            //from Other Assemblies
            Console.WriteLine(Id); //Compile Time Error
        }
    }

    public class AnotherAssemblyClass2
    {
        public void Dispplay3()
        {
            //We cannot access Private Protected Member from Non-Derived Classes
            //from Other Assemblies
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.Id); //Compile Time Error
        }
    }
}