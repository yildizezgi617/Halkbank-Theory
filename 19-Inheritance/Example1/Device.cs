using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance.Example1
{
   public class Device  //Base class
    {
        public  string CPU { get; set; }
        public string RAM { get; set; }
        public int Storage { get; set; }
        

        public void BootUp()
        {
            Console.WriteLine("Device is booting up");
        }

    }

    public    class Desktop : Device //Sub class, child class
    {
        public  string CoolingSystem { get; set; }
    }



    public class AllInOne : Desktop //Hem Desktop sınıfından hem de Device sınıfından özellikler alır. Hiyerarşik miras
    {
        public string D  { get; set; }
    }


    public class Laptop : Device
    {
        public string BatteryLife { get; set; }
    }

}
