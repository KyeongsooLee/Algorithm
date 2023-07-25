using System;
using static Valid_Palindrome.Valid_Palindrome;

namespace Valid_Palindrome
{
    class Program
    {
        static void Main()
        {
            Solution solution = new Solution();

            string s1 = "A man, a plan, a canal: Panama";
            Console.WriteLine(solution.IsPalindrome(s1)); // Output: True

            string s2 = "race a car";
            Console.WriteLine(solution.IsPalindrome(s2)); // Output: False

            string s3 = " "; // An empty string is considered a palindrome
            Console.WriteLine(solution.IsPalindrome(s3)); // Output: True
        }
    }
}