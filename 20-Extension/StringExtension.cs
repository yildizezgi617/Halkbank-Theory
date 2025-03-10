using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Extension
{
    public static class StringExtension
    {
        //Metni ters çeviren bir extension Metot.

        public static string ReverseString(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string CapitaliceFirst(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return char.ToUpper(str[0]) + str.Substring(1);
        }

        public static string CapitaliceFirst(this string str, int index)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return str.Substring(0, index) + char.ToUpper(str[index]) + str.Substring(index + 1);
        }

        public static bool IsSuccessful(this Student student)
        {
            return student.Scores.Average() >= 70;
        }
    }
}