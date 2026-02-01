

namespace DSA.if_loop
{
    internal class Basics
    {
        public static void IfLoop()
        {
           
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
}
