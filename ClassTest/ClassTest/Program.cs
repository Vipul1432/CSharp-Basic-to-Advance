using System;
namespace ClassTutorial
{
    public class ClassTest
    {
        private int id;//data member (also instance variable)    
        string? name;//data member(also instance variable)    

        public static void Main(string[] args)
        {
            ClassTest obj = new();
            obj.id = 101;
            obj.name = "Vipul Kumar"; 
            
            Console.WriteLine(obj.id);
            Console.WriteLine(obj.name);

        }
    }
}