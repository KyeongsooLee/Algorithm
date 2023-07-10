using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Binary
{
    internal class Add_Binary
    {
        public class Solution
        {
            public string AddBinary(string a, string b)
            {
                int length = Math.Max(a.Length, b.Length);

                a = a.PadLeft(length, '0');
                b = b.PadLeft(length, '0');

                string result = "";
                bool carry = false;

                for (int i = length - 1; i >= 0; i--)
                {
                    if (a[i] == '1' && b[i] == '1')
                    {
                        result = (carry ? "1" : "0") + result;
                        carry = true;
                    }
                    else if (a[i] == '1' || b[i] == '1')
                    {
                        result = (carry ? "0" : "1") + result;
                        carry = carry && (a[i] == '1' || b[i] == '1');
                    }
                    else
                    {
                        result = (carry ? "1" : "0") + result;
                        carry = false;
                    }
                }

                if (carry) result = "1" + result;

                return result;
            }
        }
    }
}
