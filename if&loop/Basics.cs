

namespace DSA.if_loop
{
    internal class Basics
    {
        public static void IfLoop()
        {
            LeepYear.Leep();
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
}
