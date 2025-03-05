namespace _17_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //struct value tipli. diğer özellikleri classla aynı.

            Color color = new Color(); //intance alınması için newlenmiyor, default tiplerin yüklenmesi için
            color.Red = 255;
            color.Green = 240;
            color.Blue = 255;
            Console.WriteLine(color.GetColor());

            Color color2 = new Color(255, 200, 40);
            Console.WriteLine(color2.GetColor());

            Currency currency = new Currency(10000, "$",true);
            Console.WriteLine(currency.GetCurrency());

            Currency currency1 = new Currency(100, "TL", true);
            Console.WriteLine(currency1.GetCurrency());

        }
        
    }
}
