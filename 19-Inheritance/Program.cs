using _19_Inheritance.Example1;

namespace _19_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inheritance kalıtım veya miras verme anlamına gelir
            //bir sınıfın başka bir sınıftan özelliklerini almasıdır.
            // base ve super anahtar kelimeleri ile çalışır.
            Desktop desktop = new Desktop();
            desktop.BootUp();
            desktop.CoolingSystem = "Fan";  //her iki sınıfın özelliklerine de erişebilir.


            AllInOne allInOne = new AllInOne();
            allInOne.BootUp();                          //Device sınıfından gelen metot
            allInOne.CoolingSystem = "Fan";           //Desktop sınıfından gelen özellik
            allInOne.D = "D";                          //AllInOne sınıfından gelen özellik

            Laptop laptop = new Laptop();
            laptop.BootUp();                          //Device sınıfından gelen metot
            laptop.BatteryLife = "10 hours";           //Laptop sınıfından gelen özellik






        }
    }
}
