using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Math
{
    internal class OddOrEven
    {
        public static void OddEven()
        {
            //FirstMethod obj = new FirstMethod();
            //obj.WithModulus();
            //SecondMethod obj = new SecondMethod();
            //obj.WithMulDiv();
            ThirdMethod obj = new ThirdMethod();
            obj.WithMinusTwo();

        }
    }
    //1.We can identify with modulus operator
    public class FirstMethod
    {
        public void WithModulus()
        {
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.Read());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }

        }
    }


    //2.we can identify with equation (n/2)*2 == n
    class SecondMethod
    {
        public void WithMulDiv()
        {
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.Read());

            if((num/2)*2 == num)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }

    //3.we can identify with continuesly subtract -2 with the given number,
    //finally we get 0 or 1.if we get 0 it is even number otherwise odd.

    class ThirdMethod
    {
        public void WithMinusTwo()
        {
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.Read());

            while (num >= 0)
            {
                if (num == 0)
                {
                    Console.WriteLine("Even Number");
                }
                if (num == 1)
                {
                    Console.WriteLine("Odd Number");
                }

                num = num - 2;
            }
        }
         
    }
}
