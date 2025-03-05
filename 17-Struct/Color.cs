using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _17_Struct
{
    public struct Color //struct olduğunu bekirtmem lazım
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public string GetColor()
        {
            return $"RGB {Red}, {Blue},{Green}";
        }

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }


    }
}
