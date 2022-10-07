using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Assignment_2
{
    public sealed class StringUtility
    {
        public string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }
        public string CapitalizeString(string text)
        {
            string updatedText = text.ToUpper();

            return updatedText;

        }
        public string LowercaseString(string text)
        {
            string updatedText = text.ToLower();

            return updatedText;
        }
    }
}
