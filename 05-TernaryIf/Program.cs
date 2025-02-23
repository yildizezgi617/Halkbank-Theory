 ﻿namespace _05_TernaryIf
{
    internal class Program
{
    static void Main(string[] args)
    {
        //Syntax koşul ? dogruSonuc : yanlisSonuc

        int not = 75;
        string durum = "";

        durum = not >= 50 ? "Geçti" : "Kaldı";

        Console.WriteLine(durum);


        int sayi = 35;
        Console.WriteLine(sayi % 2 == 0 ? "Çift" : "Tektir");



            int tamSayi = -3;
           bool dogruMu = tamSayi < 0 ? true : false;
            Console.WriteLine($"doğru mu : {dogruMu}");


            double fiyat = 150;
            double indirimliFiyat = fiyat > 100 ? fiyat * 0.9 : fiyat;
            Console.WriteLine(indirimliFiyat); // Çıktı: 135

            int sayisi = -5;
            int mutlakDeger = sayisi < 0 ? -sayisi : sayisi;
            Console.WriteLine(mutlakDeger); // Çıktı: 5


            //Kullanıcın girdiği sayının pozitif mi, negatif mi veya sıfır olup olumadığını ternarty if kontrol edin.


            int sayii = Convert.ToInt32(Console.Read());

            string durumu = "";
            durumu = sayii < 10 ? "negatif" : "pozitif";
            Console.WriteLine("durumu: {0}",durumu);

           // string durumu = sayii < 10 ? "negatif" : "pozitif";   sadece koşulda tanımlansa da olur, başlangıçta "" bu şekilde tanımlansa da olur.
            //Console.WriteLine("durumu: {0}", durum);



            int number = -12;

        if (number == 0)
        {
            Console.WriteLine("Sıfır");
        }
        else if (number > 0)
        {
            Console.WriteLine("Pozitif");
        }
        else
        {
            Console.WriteLine("Negatif");
        }

        Console.WriteLine(number == 0 ? "Sıfır" : number > 0 ? "Pozitif" : "Negatif");


    }
}
}