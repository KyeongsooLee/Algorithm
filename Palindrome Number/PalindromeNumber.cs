using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    internal class PalindromeNumber 
    {
        public class Palindrome_Number
        {
            public bool IsPalindrome(int x)
            {
                string k = x.ToString();

                for (int i = 0; i < k.Length / 2; i++)
                {
                    if (k[i] != k[k.Length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
