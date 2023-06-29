namespace Prac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
               double Input_1 = 0, Input_2 = 0;
            checked
            {
                try
                {
                    do
                    {
                        Console.Write("Please Enter First Number : ");

                    } while (!double.TryParse(Console.ReadLine(), out Input_1));
                    do
                    {
                        Console.Write("Please Enter Second Number : ");

                    } while (!double.TryParse(Console.ReadLine(), out Input_2));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if ((Input_2 != 0))
                {
                    Console.WriteLine($"{Input_1 + Input_2}");
                }
                else
                {
                    Console.WriteLine($"The {Input_1} can't divide by 0");
                }
            }
        }
    }
}