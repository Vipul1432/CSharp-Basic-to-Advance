using System;

namespace PartialClass_Demo
{
    public partial class PartialClass
    {
        public void FullName()
        {
            Console.WriteLine("Full Name:" + FirstName + " " + LastName);
        }
    }
}