using System;

namespace Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Length_of_Last_Word.Solution solution = new Length_of_Last_Word.Solution();

            string s = "   fly me   to   the moon  ";
            int result = solution.LengthOfLastWord(s);
            Console.WriteLine($"Input string:[{s}]");
            Console.WriteLine($"The length of the last word: {result}");
        }
    }
}