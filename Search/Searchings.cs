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
            //int a = DifferentSearches.LinearSerch(new[] { 2, 4, 6, 9, 4, 7 }, 9);
            //Console.WriteLine("The Element is find at the index number:"+ a);

            int a = DifferentSearches.BinarySearch(new int[] { 1,2,3,4,5,6,7,8 },7);
            Console.WriteLine("Index of the Target:"+a);
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

        public static int BinarySearch(int[] arr,int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }

                else if (arr[low] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

            }
            return -1;
        }
    }
}
