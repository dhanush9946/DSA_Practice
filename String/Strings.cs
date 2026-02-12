

using System.Text;

namespace DSA.String
{
    public class Strings
    {
        public static void StringOperations()
        {
            string a = "Hello";
            string b = "World";
            //String interpolation
            string c = $"{a} {b}";
            Console.WriteLine(c);

            //Verbatim strings(ignores escape sequences except " "
            string path = @"C:\Users\UserName\Documents";
            Console.WriteLine(path);
            //without '@' it will give error because of \U,\D its an escaping sequences

            string multipleLine = @"hello
                good morning
                eveyone";
            Console.WriteLine(multipleLine);

            Console.WriteLine();
            //verbatim string interpolation
            string multiinterpolation = $@"{a}
                    what is happening
                                    in the {b}";
            Console.WriteLine(multiinterpolation);

            //Raw string litterals
            string json =

                """
                {
                "Name":"Dhanush",
                "Age:21,
                isActive:true
                }
                """;
   
            Console.WriteLine(json);


            //Raw string interpolation
            string name = "gayathry";
            string girl =
                $"""
                "Name":{name}
                "Date":{DateTime.UtcNow}
                """;
            Console.WriteLine(girl);


            //----------------String Methods-------------------------
            string text = "Hello World";
            //Contains
            bool contains = text.Contains("World");//true
            Console.WriteLine(contains);

            //ToUpper
            string Upper = text.ToUpper();
            Console.WriteLine(Upper);

            //ToLower
            string lower = text.ToLower();
            Console.WriteLine(lower);

            //Replace
            string replaced = text.Replace("Hello", "Hi"); //Hi World
            Console.WriteLine(replaced);

            //Trim
            string trimed = "    text    ".Trim();//text
            Console.WriteLine(trimed);

            //Split
            string jk = "bridgeon solution";
            string[] split = jk.Split(' ');
            Console.WriteLine(string.Join("/",split));

            //Length
            int length = text.Length;
            Console.WriteLine(length);

            //String Comparison
            bool isequal = string.Equals("abc", "ABC");//false
            Console.WriteLine(isequal);

            bool isequal2 = string.Equals("abc", "ABC",StringComparison.OrdinalIgnoreCase);//true
            Console.WriteLine(isequal2);

            int comparison = string.Compare("abc", "ABC",StringComparison.Ordinal);
            Console.WriteLine(comparison);


            //StringBuilder

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 100; i++)
            {
                sb.Append($"Item{i }, ");
            }
            string result = sb.ToString();

            Console.WriteLine(result);
        }
    }
}
