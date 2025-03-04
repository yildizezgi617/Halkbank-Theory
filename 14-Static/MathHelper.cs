using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _14_Static
{
    public static class MathHelper //içersinde vs tanımlanacak her şey de static olacak.
    {
        public static double CalculeteCircleArea(double radios)
        {
            return Math.PI * radios * radios;
        }
        public static double PI => Math.PI;   // geriye deger donduren bir method.sadece okuma yapabiliyor.









    }

}
