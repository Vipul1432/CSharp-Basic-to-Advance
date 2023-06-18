public class Example
{
    static void Main()
    {
        // Define some integers for a division operation.
        int[] values = { 10, 7 };
        foreach (var value in values)
        {
            try
            {
                Console.WriteLine("{0} divided by 2 is {1}", value, DivideByTwo(value));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
            }
            Console.WriteLine();
        }
    }

    static int DivideByTwo(int num)
    {
        // If num is an odd number, throw an ArgumentException.
        if ((num % 2) == 1)
            throw new ArgumentException($"{num} is not an even number");

        // num is even, return half of its value.
        return num / 2;
    }
}