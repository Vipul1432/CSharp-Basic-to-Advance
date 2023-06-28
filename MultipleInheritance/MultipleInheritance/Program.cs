using System;
namespace MultipleInheritance
{
    public class Program
    {
        static void Main()
        {
            // Creating object of Child class and
            // invoke the methods of Parent classes and Child class
            SmartPhone obj = new SmartPhone(); ;
            obj.GetPhoneModel();
            obj.GetCameraDetails();
            obj.GetDetails();

            Console.ReadKey();
        }
    }
    //Parent Class 1
    class Phone
    {
        public void GetPhoneModel()
        {
            Console.WriteLine("Redmi Note 5 Pro");
        }
    }
    //Parent class2
    class Camera
    {
        public void GetCameraDetails()
        {
            Console.WriteLine("24 Mega Pixel Camera");
        }
    }

    //Child Class derived from more than one Parent class
    class SmartPhone : Phone, Camera
    {
        public void GetDetails()
        {
            Console.WriteLine("Its a RedMi Smart Phone");
        }
    }
}