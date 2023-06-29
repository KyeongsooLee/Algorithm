using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeNumber.Solution solution = new PalindromeNumber.Solution();

            int x = 12321;
            bool isPalindrome = solution.IsPalindrome(x);

            Console.WriteLine($"{x} is a palindrome: {isPalindrome}");
        }
    }
}