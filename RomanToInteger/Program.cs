using System;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanToInteger.Solution solution = new RomanToInteger.Solution();

            String x = "MCMXCIV";
            int RomanToInt = solution.RomanToInt(x);

            Console.WriteLine($"{x} is {RomanToInt}");
        }
    }
}