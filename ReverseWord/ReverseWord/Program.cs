using System;
using System.Text;

namespace ReverseWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello it is a string for reverse";


            string[] arr = x.Split(' ');
            StringBuilder builder = new StringBuilder();


            foreach (var item in arr)
            {
                foreach (var test in item.Reverse())
                {
                    builder.Append(test);
                }
                builder.Append(" ");
            }

            Console.WriteLine(builder);


            string str = "I am going to reverse myself.";

            string[] strArray = str.Split(' ');

            string[] strArrayReversed = new string[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {

                char[] eachWordLetter = strArray[i].ToCharArray();

                Array.Reverse(eachWordLetter);

                strArrayReversed[i] = new string(eachWordLetter);
            }

            string newReversedString = String.Join(" ", strArrayReversed);

            Console.WriteLine(newReversedString);

            int[] arr2 = new int[5] { 1,2,3,4,5};
            foreach (var item in arr2.Reverse())
                Console.Write(item + " ");
        }
    }
}