using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    public class Sorts
    {
        public static void sortings()
        {
            BubbleSort.bubble(new int[] { 5,3,56,1,3,7,8,10,4});
        }
    }

    class BubbleSort
    {
        public static void bubble(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("sorted array:" + string.Join(", ",arr));
        }
    }
}
