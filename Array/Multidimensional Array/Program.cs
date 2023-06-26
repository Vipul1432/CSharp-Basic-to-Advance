namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // first way initialized multidimensional array 
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // second way yo initialized multidimensional array 
            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // third way to initialized multidimensional array 
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
