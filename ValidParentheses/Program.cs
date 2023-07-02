using System;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidParentheses.Solution solution = new ValidParentheses.Solution();

            string strs = "()[]{}";
            bool result = solution.IsValid(strs);

            Console.WriteLine($"Input: {strs}");
            Console.WriteLine($"Result: {result}");
        }
    }
}