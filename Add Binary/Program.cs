using System;

namespace Add_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Add_Binary.Solution solution = new Add_Binary.Solution();

            string a = "1010";
            string b = "1011";
            string output = solution.AddBinary(a, b);

            Console.WriteLine($"String a:           [{a}]");
            Console.WriteLine($"String b:           [{b}]");
            Console.WriteLine($"Add Binary Result: [{output}]");
        }
    }
}