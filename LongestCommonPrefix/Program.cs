using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args) 
        { 
            LongestCommonPrefix.Solution solution = new LongestCommonPrefix.Solution();

            string[] strs = new string[] { "flower", "flow", "flight" };
            string result = solution.LongestCommonPref(strs);

            Console.WriteLine($"The Longest common Prefix is {result}");
        }
    }
}