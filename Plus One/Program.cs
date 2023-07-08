using System;

namespace Plus_One
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Plus_One.Solution solution = new Plus_One.Solution();

            int[] digits = { 9, 9, 9 };
            Console.Write("Input digits: [ ");
            for (int i = 0; i < digits.Length; i++)
            {
                if (i != digits.Length - 1)
                    Console.Write($"{digits[i]}, ");
                else
                    Console.Write($"{digits[i]} ]\n");
            }
            int[] output = solution.PlusOne(digits);
            Console.Write("Output digits: [ ");
            for (int i = 0; i < output.Length; i++)
            {
                if (i != output.Length - 1)
                    Console.Write($"{output[i]}, ");
                else
                    Console.Write($"{output[i]} ]\n");
            }
        }
    }
}