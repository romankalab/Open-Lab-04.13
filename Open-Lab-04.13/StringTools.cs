using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_04._13
{
    class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            var result = "";

            var builder = new StringBuilder();
            for (var x = 0; x < str1.Length; x++)
            {
                var pos = x;
                foreach (var ch in str2)
                {
                    if (pos < str1.Length && str1[pos] == ch)
                    {
                        builder.Append(ch);
                        ++pos;
                    }
                    else
                    {
                        if (builder.Length > result.Length)
                            result = builder.ToString();
                        builder.Clear();
                    }
                }

                if (builder.Length > result.Length)
                {
                    result = builder.ToString();
                    builder.Clear();
                }
            }
            return result;
        }
    }
}
