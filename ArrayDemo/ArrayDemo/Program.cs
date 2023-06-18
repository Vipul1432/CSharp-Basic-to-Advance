namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Single Dimension Array
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            } 
            Console.WriteLine();


            Console.WriteLine("------------- Multi-Dimension Array --------------");


            // Two Dimension Array  
            int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("------------- Jagged Array --------------");


            int[][] arr3 = new int[3][];
            arr3[0] = new int[4] { 1, 2, 3, 4 };
            arr3[1] = new int[2] { 1, 2 };
            arr3[2] = new int[3] { 1, 2, 3 };
            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    Console.Write(arr3[i][j] + " ");
                }
                Console.WriteLine();
            }
            foreach (int[] i in arr3)
            {
                foreach (var j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("------------- Dynamic Array --------------");


            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int n = 3;
            Array.Resize(ref array, n);
            Console.WriteLine("Array after resize :");
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.WriteLine("------------- CopyTo Array --------------");

            int[] firstArray = new int[5] { 1, 2, 3, 4, 5 };
            int[] secondArray = new int[3] { 6, 7, 9 };
            secondArray.CopyTo(firstArray, 1);
            foreach (var item in firstArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------- Copy Array --------------");
            // Array Copy Method
            int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[3] { 6, 7, 8 };
            Array.Copy(array2, array1, 2);
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("------------- Array Methods --------------");

            //  arr =  1, 2, 3, 4, 5
            int[] newarr = new int[5] { 1, 2, 3, 4, -5 };
            Array.Reverse(newarr);
            foreach (var item in newarr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Clear Method 
            Array.Clear(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            string[] strArray = new string[5] {"Vipul", "Bhavin", "Abhi", "Jay", "Jil"};
            Array.Sort(strArray);
            foreach (var item in strArray)
            {
                Console.Write(item + " ");

            }

            var user = Array.Find(strArray, (e) => e == "Bhavin");

            Console.WriteLine();

            Console.WriteLine(user);
        }
    }
}