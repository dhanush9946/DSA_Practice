using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Recursion
{
    internal class RecursionProblems
    {
        public static int Problems()
        {
           int a = Recursive.Sumofdigits(123);
            return a;
        }
    }
    
    class Recursive
    {
        public static int Sumofdigits(int n)
        {
            if (n == 0) return 0;
            //n = Math.abs(n);
            return n % 10 + Sumofdigits(n / 10);
        }
        
    }
}
