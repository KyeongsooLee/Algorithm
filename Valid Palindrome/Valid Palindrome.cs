using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Palindrome
{
    internal class Valid_Palindrome
    {
        public class Solution
        {
            public bool IsPalindrome(string s)
            {
                // Convert the string to lowercase
                s = s.ToLower();

                // Use StringBuilder to create a new string with alphanumeric characters only
                StringBuilder sb = new StringBuilder();
                foreach (char c in s)
                {
                    if (char.IsLetterOrDigit(c))
                        sb.Append(c);
                }

                // Get the cleaned string after removing non-alphanumeric characters
                string cleanedString = sb.ToString();

                // Check if the cleaned string is a palindrome
                int left = 0;
                int right = cleanedString.Length - 1;

                while (left < right)
                {
                    if (cleanedString[left] != cleanedString[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }

                return true;
            }
        }
    }
}
