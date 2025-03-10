using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance.Example1
{
    // Base Class
    public class Device
    {
        public Device(string cPU, int rAM, int storage)
        {
            Console.WriteLine("Device parametreli yapıcı çalıştı");
            CPU = cPU;
            RAM = rAM;
            Storage = storage;
        }
        public Device()
        {
            Console.WriteLine("Device parametresiz yapıcı çalıştı");
        }

        public string CPU { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }

        public void BootUp()
        {
            Console.WriteLine("Device is booting up...");
        }

        public virtual string DisplayInfo()
        {
            return $"CPU: {CPU} RAM: {RAM} Hard Disk: {Storage}";
        }

        public override string ToString()
        {
            return $"CPU: {CPU} RAM: {RAM} Hard Disk: {Storage}";
        }

        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj == null)
                return result;

            if (obj is Device device)
            {
                var de = obj as Device;

                if (de.CPU == this.CPU && de.RAM == this.RAM && de.Storage == this.Storage)
                    result = true;
            }

            return result;
        }
    }

    // Child Class
    public class Desktop : Device
    {
        public Desktop(string cPU, int rAM, int storage, string coolingSystem) : base(cPU, rAM, storage)
        {
            CoolingSystem = coolingSystem;
            Console.WriteLine("Desktop parametreli yapıcı çalıştı");
        }
        public Desktop()
        {
            Console.WriteLine("Desktop parametresiz yapıcı çalıştı");
        }

        public string CoolingSystem { get; set; }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " Soğutma: " + CoolingSystem;
        }

        public override string ToString()
        {
            return base.ToString() + " Soğutma: " + CoolingSystem;
        }
    }

    public sealed class AllInOne : Desktop
    {
        public AllInOne(string cPU, int rAM, int storage, string coolingSystem) : base(cPU, rAM, storage, coolingSystem)
        {
            Console.WriteLine("AllInOne parametreli yapıcı çalıştı");
        }
        public AllInOne()
        {
            Console.WriteLine("AllInOne parametresiz yapıcı çalıştı");
        }

        public sealed override string DisplayInfo()
        {
            return base.DisplayInfo() + "All In One";
        }

        public override string ToString()
        {
            return $"CPU: {CPU} RaM: {RAM} Harddisk: {Storage}";
            base.ToString();
        }
    }

    public class Laptop : Device
    {
        public Laptop(string cPU, int rAM, int storage, int batery) : base(cPU, rAM, storage)
        {
            Console.WriteLine("Laptop parametreli yapıcı çalıştı");
            BatteryLife = batery;
        }
        public Laptop()
        {
            Console.WriteLine("Laptop parametresiz yapıcı çalıştı");
        }

        public int BatteryLife { get; set; }

        public override string ToString()
        {
            return base.ToString() + " Batery: " + BatteryLife;
        }
    }

    //public class Deneme : AllInOne
    //{ 

    //}
}