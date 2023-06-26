namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int n;
            Console.Write("Enter the number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());


            // 1st Pattern 
            /*
                      * * * * *
                      * * * * *
                      * * * * *
                      * * * * *
                      * * * * *
                                         */

            // for (i = 1; i <= n; i++)
            // {
            //     for (j = 1; j <= n; j++)
            //     {
            //         Console.Write("* ");
            //     }
            //     Console.WriteLine();
            // }


            // 2nd Pattern
            /*
                      * 
                      * * 
                      * * * 
                      * * * * 
                      * * * * * 
                                      */

            // for (i = 1; i <= n; i++)
            // {
            //     for (j = 1; j <= i; j++)
            //     {
            //         Console.Write("* ");
            //     }
            //     Console.WriteLine();
            // }

            // Pattern 3
            /*
                 * * * * *
                 * * * *
                 * * *
                 * *
                 *
                      */

            // for (i = 0; i <= n; i++)
            // {
            //     for (j = 0; j <= n - i; j++)
            //     {
            //         Console.Write("* ");
            //     }
            //     Console.WriteLine();
            // }

            // Pattern 4
            /*  
                      * 
                      * * 
                      * * * 
                      * * * * 
                      * * * * * 
                      * * * * 
                      * * * 
                      * * 
                      * 
                                 */

            // for (i = 1; i <= n; i++)
            // {
            //     for (j = 1; j <= i; j++)
            //     {
            //         Console.Write("* ");
            //     }
            //     Console.WriteLine();
            // }
            // for (i = 1; i <= n; i++)
            // {
            //     for (j = 1; j <= n - i; j++)
            //     {
            //         Console.Write("* ");
            //     }
            //     Console.WriteLine();
            // }

            // Pattern 5

            /* 
                      * * * * * 
                        * * * * 
                          * * * 
                            * * 
                              * 
                      */

            // for (i = 0; i < n; i++)
            // {
            //     for (j = 0; j < i; j++)
            //     {
            //         Console.Write("  ");
            //     }
            //     for (j = i; j < n; j++)
            //     {
            //         Console.Write("* ");
            //     }
            //     Console.WriteLine();
            // }

            // Pattern 6

            /* 
                      *       *
                      * *     *
                      *   *   *
                      *     * *
                      *       *
                                    */

            // for (i = 0; i < n; i++)
            // {
            //     for (j = 0; j < n; j++)
            //     {
            //         if (i == j || j == 0 || j == n - 1)
            //         {
            //             Console.Write(" *");
            //         }
            //         else
            //         {
            //             Console.Write("  ");
            //         }
            //     }
            //     Console.WriteLine();
            // }

            // Pattern 7
            /*
             * * * * *
                   *
                 *
               *
             * * * * *
                        */

            // for (i = 0; i < n; i++)
            // {
            //     for (j = 0; j < n; j++)
            //     {
            //         if (i + j == n - 1 || i == 0 || i == n - 1)
            //         {
            //             Console.Write(" *");
            //         }
            //         else
            //         {
            //             Console.Write("  ");
            //         }
            //     }
            //     Console.WriteLine();
            // }

            // Pattern 8

            /* 
                      * * * * *
                      *       *
                      *       *
                      *       *
                      * * * * *
                                    */

            // for (i = 0; i < n; i++)
            // {
            //     for (j = 0; j < n; j++)
            //     {
            //         if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
            //         {
            //             Console.Write(" *");
            //         }
            //         else
            //         {
            //             Console.Write("  ");
            //         }
            //     }
            //     Console.WriteLine();
            // }

            // Pattern 9
            /*
                        * * * * *
                        *       *
                        *   *   *
                        *       *
                        * * * * *
                                        */

            // for (i = 0; i < n; i++)
            // {
            //     for (j = 0; j < n; j++)
            //     {
            //         if (i == 0 || i == n - 1 || j == 0 || j == n - 1 || (i == j && i == n / 2))
            //         {
            //             Console.Write(" *");
            //         }
            //         else
            //         {
            //             Console.Write("  ");
            //         }
            //     }
            //     Console.WriteLine();
            // }

            // Pattern 10
            /*
                            * 
                          * * *
                        * * * * *
                       * * * * * *
                      * * * * * * *
                                        */

            // for (i = 0; i < n; i++)
            // {
            //     for (j = 0; j < n - i; j++)
            //     {
            //         Console.Write("  ");
            //     }
            //     for (j = 0; j <= i; j++)
            //     {
            //         Console.Write(" *");
            //     }
            //     for (j = 1; j <= i; j++)
            //     {
            //         Console.Write(" *");
            //     }
            //     Console.WriteLine();
            // }

            // Pattern 11
            /*
                 *
               * * *
             * * * * *
           * * * * * * *
         * * * * * * * * *
           * * * * * * *
             * * * * *
               * * *
                 *  
                                         */

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n - i; j++)
                {
                    Console.Write("  ");
                }
                for (j = 0; j <= i; j++)
                {
                    Console.Write(" *");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - i; j++)
                {
                    Console.Write("  ");
                }
                for (j = i; j <= n; j++)
                {
                    Console.Write(" *");
                }
                // for (j = 1; j <= i; j++)
                // {
                //     Console.Write(" *");
                // }
                Console.WriteLine();
            }

        }
    }
}