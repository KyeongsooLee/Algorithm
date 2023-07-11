using System;

namespace Sqrt_x_
{
    class Program
    {
        static void Main(string[] args)
        {
            Sqrt_x_.Solution solution = new Sqrt_x_.Solution();

            int x = 8;
            int output = solution.MySqrt(x);

            Console.WriteLine($"Input : {x}");
            Console.WriteLine($"Output: {output}");
        }
    }
}