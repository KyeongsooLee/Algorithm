using System;

namespace Find_the_Index_of_the_First_Occurrence_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Find_the_Index_of_the_First_Occurrence_in_a_String.Solution solution = new Find_the_Index_of_the_First_Occurrence_in_a_String.Solution();

            string haystack = "mississippi";
            string needle = "issip";
            int result = solution.StrStr(haystack, needle);

            Console.WriteLine($"haystack: {haystack}");
            Console.WriteLine($"needle: {needle}");
            Console.WriteLine($"Output: {result}");
        }
    }
}