namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // First way to initialized single dimesion array
            int[] arr = new int[5];
            arr[0] = 5;
            arr[1] = 10;
            arr[2] = 15;
            arr[3] = 20;
            arr[4] = 25;

            // Second way to initialized single dimension array 
            int[] arr2 = new int[5] { 10, 20, 30, 40, 50 };

            // Third way to initialized single dimension array 
            int[] arr3 = { 15, 30, 45, 60, 75 };

            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr2[i] + " ");
            }
            System.Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr3[i] + " ");
            }
        }
    }
}