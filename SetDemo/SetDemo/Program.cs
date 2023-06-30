using System.Collections;

namespace SetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //! HashSet
            HashSet<string> set = new HashSet<string>();
            set.Add("A");
            set.Add("B");
            set.ToArray();

            //! SortedList
            #region SortedList

            //! Sorted list can't accept duplicate key(runtime error)
            //! It allow only one type of key can be added(like int or string)
            //! it is in sorted order it's value may be null or duplicate 

            SortedList sortedList = new SortedList();
            sortedList.Add(1, "Vipul");
            sortedList.Add(2, null);

            #endregion SortedList
            //! SortedList Generics
            #region SortedList Generic

            //! It is generic type so it will accept specific value only 
            //! It check key value at compile time 

            SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            keyValuePairs.Add(1, "vip");
            keyValuePairs.Add(2, null);
            Console.WriteLine(keyValuePairs.ElementAt(0));
            Console.WriteLine(keyValuePairs[1]);
        
            #endregion SortedList Generic
            //! SortedSet
            #region SortedSet Generic

            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(1);
            sortedSet.Add(1);

            #endregion SortedSet

            #region SortedDictionary
            SortedDictionary<int, string> stDictionary = new SortedDictionary<int, string>();
            stDictionary.Add(1, "abc");
            stDictionary.Add(2, "xyz");
            Console.WriteLine(stDictionary.ElementAt(1));
            #endregion SortedDictionary

            #region Dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "abc");
            dict.Add(2, "Bhavin");
            Console.WriteLine(dict.ElementAt(1));
            Console.WriteLine(dict[1]);
            #endregion Dictionary

            #region Hashtable
            Hashtable ht = new Hashtable();
            ht.Add(1, "abc");
            ht.Add("1", string.Empty);
            Console.WriteLine(ht["1"]);
            #endregion Hashtable

            #region LinkedList

            LinkedList<string> lst = new LinkedList<string>();
            lst.AddFirst("Vipul");
            lst.AddAfter(lst.Find("Vipul"), "Bhavin");

            Console.WriteLine(lst.Find("Bhavin").Value);
            lst.AddBefore(lst.Find("Bhavin"), "Jil");
            //! print Linked list element
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            //! find linked list element 
            if (lst.Contains("Jil") == true)
            {
                Console.WriteLine("Element Found");
            }
            else
            {
                Console.WriteLine("Element not Found");
            }

            #endregion LinkedList

        }
    }
}