using System;
using System.Text;

namespace CreateNewStringBySwitchingFirstAndLastChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word : ");
            string word = Console.ReadLine();
            FirstLast(word);
            
            //var str = Console.ReadLine();
            //var s = new StringBuilder();
            //s.Append(str);

            //var temp = s[0];
            //s[0] = s[s.Length - 1];
            //s[s.Length - 1] = temp;

            //str = s.ToString();
            //Console.WriteLine(str);
        }
        static void FirstLast(string word)
        {
            if (word.Length > 1)
            {
                var first = word[0];
                var last = word[word.Length - 1];
                Console.WriteLine(last + word.Substring(1, word.Length - 2) + first);
            }
        }
    }
}
 