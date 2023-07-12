using System;

namespace Climbing_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Climbing_Stairs.Solution solution = new Climbing_Stairs.Solution();

            int n = 5;
            int output = solution.ClimbStairs(n);

            Console.WriteLine($"Input n: {n}");
            Console.WriteLine($"Output : {output}");
        }
    }
}