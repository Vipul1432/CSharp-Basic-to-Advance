using System;
namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        public int Id;
        public void Display1()
        {
            //Public Members Accessible with the Containing Type
            //Where they are created
            Console.WriteLine(Id);
        }
    }
    public class AssemblyOneClass2 : AssemblyOneClass1
    {
        public void Display2()
        {
            //We Can access public Members from Derived Class
            //Within the Same Assembly
            Console.WriteLine(Id); //No-Compile Time Error
        }
    }

    public class AssemblyOneClass3
    {
        public void Dispplay3()
        {
            //We Can access public Members from Non-Derived Classes
            //Within the Same Assembly
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.Id); //No-Compile Time Error
        }
    }
}