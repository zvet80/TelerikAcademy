using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderSubstring
{
    public static class StringBuilderExtention
    {


        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder result = new StringBuilder(length);
            if (index < 0 || index > input.Length - 1)
            {
                throw new IndexOutOfRangeException("The index must be >0 and <" + (input.Length - 1));
            }
            if (length < 0 || index + length > input.Length)
            {
                throw new ArgumentOutOfRangeException("The length must be >0 and <" + (input.Length - index));
            }
            for (int i = index; i < index + length; i++)
            {
                result.Append(input[i]);
            }
            return result;

        }
    }
}
