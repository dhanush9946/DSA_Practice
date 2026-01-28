using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class BasicOperations
    {
        public static void Operations()
        {
            //Traversal.Traveling();

            //Reverse obj = new Reverse();
            //obj.Reversing();

            SumOfAll obj = new SumOfAll();
            obj.Sum();


        }
    }


    //1.Print all elements of an array
    class Traversal
    {
        public static void Traveling()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            foreach(int x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }

    //2.Print array elements in reverse order
    class Reverse
    {
        public void Reversing()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int i = arr.Length-1;
            
            for (; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }


    //3.Find the sum of all elements
    class SumOfAll
    {
        public void Sum()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum=0;
            foreach(int i in arr)
            {
                sum += i;
            }
            Console.WriteLine($"The Total sum of the elements is:{sum}");
        }
    }
}
