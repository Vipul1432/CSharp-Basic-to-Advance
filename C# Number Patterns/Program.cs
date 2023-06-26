namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Pattern 1

            // for (int i = n; i > 0; i--)
            // {
            //     for (int j = n; j > 0; j--)
            //     {
            //         for (int k = 0; k < i; k++)
            //         {
            //             Console.Write(j + " ");
            //         }
            //     }
            //     Console.Write("$");
            // }

            // Pattern 2

            /*      1
                    1 2
                    1 2 3
                    1 2 3 4
                    1 2 3 4 5        */

            // for (int i = 1; i <= n; i++)
            // {
            //     for (int j = 1; j <= i; j++)
            //     {
            //         Console.Write(j + " ");
            //     }
            //     Console.WriteLine(" ");
            // }

            // Pattern 3
            /*
                1
                2 2
                3 3 3
                4 4 4 4
                5 5 5 5 5
            */

            // for (int i = 1; i <= n; i++)
            // {
            //     for (int j = 1; j <= i; j++)
            //     {
            //         Console.Write(i + " ");
            //     }
            //     Console.WriteLine(" ");
            // }

            // Pattern 3
            /*
                1
                2 3
                4 5 6
                7 8 9 10
                11 12 13 14 15
            */

            // int k = 0;
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j <= i; j++)
            //     {
            //         Console.Write(++k + " ");
            //     }
            //     Console.WriteLine(" ");
            // }

            // Pattern 4
            /*
                1 2 3 4 5
                1 2 3 4
                1 2 3
                1 2
                1
            */

            // for (int i = 0; i <= n; i++)
            // {
            //     for (int j = 1; j <= n - i; j++)
            //     {
            //         Console.Write(j + " ");
            //     }
            //     Console.WriteLine(" ");
            // }

            // Pattern 5
            /*
                1       1
                2 2     2
                3   3   3
                4     4 4
                5       5
             */
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (i == j || j == 1 || j == n - 1)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}