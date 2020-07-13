using System;
using System.Collections.Generic;

namespace Studio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            Console.Write("Enter string to test: ");
            // string input = Console.ReadLine();
            string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc accumsan sem ut ligula scelerisque sollicitudin.Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat.Donec sit amet suscipit metus, non lobortis massa.Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] charsInString = input.ToUpper().ToCharArray();
            foreach (char c in charsInString)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (!charCount.ContainsKey(c))
                    {
                        charCount.Add(c, 0);
                    }
                    charCount[c] += 1;
                }
            }

            foreach (KeyValuePair<char, int> entry in charCount)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
    }
}
