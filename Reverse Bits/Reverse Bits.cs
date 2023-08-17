using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Bits
{
    internal class Reverse_Bits
    {
        public class Solution
        {
            public uint reverseBits(uint n)
            {
                uint result = 0;
                for (int i = 0; i < 32; i++)
                {
                    result <<= 1; // shift left to make space for the next bit
                    if ((n & 1) == 1)
                    { // if the current bit is set
                        result |= 1; // set the bit in the result
                    }
                    n >>= 1; // move to the next bit in n
                }
                return result;
            }
        }
    }
}
