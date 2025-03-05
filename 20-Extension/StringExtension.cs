using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Extension
{
    public static class StringExtension
    {
        //Metni tersine çeviren bir extension metot
        public static string ReverseString(this string str)  //string sınıfını genişleticem
        {
            char[] charArray = str.ToCharArray();  //gelen metni diziye atma
            Array.Reverse(charArray);                   //diziyi tersine çevirme
            return new string(charArray);   //diziyi string olarak dondurme
        }




        //İlk harfi büyük yapan metot
        public static string ToFirstUpper(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            return char.ToUpper(str[0]) + str.Substring(1);
        }

        //belirtilen indeksteki harfi büyük harf yapan metot
        public static string ToFirstUpper(this string str, int index)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            return str.Substring(0, index) + char.ToUpper(str[index]) + str.Substring(index + 1);
        }



        public static bool IsSuccessfull(this Student student)
        {
            return student.Scores.Average() >= 70;
        }

    }
}
