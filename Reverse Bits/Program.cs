using System;
using static Reverse_Bits.Reverse_Bits;

namespace Reverse_Bits
{
    class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            // Test the provided examples
            uint test1 = 43261596; // Corresponds to binary: 00000010100101000001111010011100
            uint test2 = 4294967293; // Corresponds to binary: 11111111111111111111111111111101

            uint result1 = solution.reverseBits(test1);
            uint result2 = solution.reverseBits(test2);

            Console.WriteLine($"Input: {test1} ({Convert.ToString(test1, 2).PadLeft(32, '0')}), Output: {result1} ({Convert.ToString(result1, 2).PadLeft(32, '0')})");
            Console.WriteLine($"Input: {test2} ({Convert.ToString(test2, 2).PadLeft(32, '0')}), Output: {result2} ({Convert.ToString(result2, 2).PadLeft(32, '0')})");
        }
    }
}