using System;
namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        protected internal int Id;
        public void Display1()
        {
            //protected internal Members Accessible with the Containing Type 
            //Where they are created
            Console.WriteLine(Id);
        }
    }
    public class AssemblyOneClass2 : AssemblyOneClass1
    {
        public void Display2()
        {
            //We can access protected internal Member from Derived Classes
            //Within the Same Assembly
            Console.WriteLine(Id); //No-Compile Time Error
        }
    }

    public class AssemblyOneClass3
    {
        public void Dispplay3()
        {
            //We can access protected internal Member from Non-Derived Classes
            //Within the Same Assembly
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            Console.WriteLine(obj.Id); //No-Compile Time Error
        }
    }
}