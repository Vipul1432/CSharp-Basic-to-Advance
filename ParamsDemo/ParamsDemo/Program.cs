using System;
namespace AccessSpecifiers
{
    class Program
    {
        // User defined function  
        public void Show(params int[] val) // Params Paramater  
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            Program program = new Program(); // Creating Object  
            program.Show(2, 4, 6, 8, 10, 12, 14); // Passing arguments of variable length  
        }
    }
}