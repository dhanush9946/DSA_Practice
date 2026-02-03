

namespace DSA.if_loop
{
    internal class Basics
    {
        public static void IfLoop()
        {
            //LeepYear.Leep();
            //Loops.OneToTen();
            // Loops.TentoOne();
            //Loops.evenTo50();
            // Loops.oddto50();
            //Loops.Multiplication();
            //Loops.sum();
            //Loops.factorial();
            //Loops.count();
            Loops.reverse();
        }
    }

    class VowelCheck
    {
        public static void Vowel()
        {
            Console.WriteLine("Enter a character:");
            char c = Convert.ToChar(Console.ReadLine());

            if(c=='a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'||
               c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }

        }
    }

    class LeepYear
    {
        public static void Leep()
        {
            Console.WriteLine("Enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year%4==0 && year%100 !=0 || year % 400 == 0)
            {
                Console.WriteLine("Leep year");
            }
            else
            {
                Console.WriteLine("Not a Leep year");
            }

        }
    }

    class Loops
    {
        //print 1 to ten
        public static void OneToTen()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        //print 10 to 1
        public static void TentoOne()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        //print even numbers 1 to 50

        public static void evenTo50()
        {
            for (int i = 2; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        //print odd 1 to 50

        public static void oddto50()
        {
            for (int i = 1; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        //Multiplication Table

        public static void Multiplication()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{2}x{i}={2 * i}");
            }
        }

        //sum of first n numbers
        public static void sum()

        {
            int n = 5;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

        }
        //factorial
        public static void factorial()
        {
            int fact = 1;
            int n = 5;
            for (int i = 1; i <= 5; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }

        //count digits in number
        public static void count()
        {
            int n = 345;
            int count = 0;
            while (n > 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine(count);
        }
        public static void reverse()
        {
            int n = 324;
            int reverse = 0;
            while (n > 0)
            {
                reverse =reverse*10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine(reverse);
        }
        
            

    }
}
