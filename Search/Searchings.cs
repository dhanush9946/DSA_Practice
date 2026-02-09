using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Search
{
    public class Searchings
    {
        public static void search()
        {
            int a = DifferentSearches.LinearSerch(new[] { 2, 4, 6, 9, 4, 7 }, 9);
            Console.WriteLine("The Element is find at the index number:"+ a);
        }
    }
    class DifferentSearches
    {
        public static int LinearSerch(int[] arr,int target)
        {
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
