using System;

namespace _01_FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bolum1

            Console.WriteLine("Merhaba Ezgi");
            //Burada ekrana yazı yazılacak.
            Console.Write("Halkbank"); //Alt satıra geçmeden yazı yazdırılacak.

            string deneme = Console.ReadLine(); //Kullanıcıdan veri almak için kullanılır.

            int yas = 12;

            Console.WriteLine(deneme);
            Console.WriteLine(yas - 2);

            #endregion



            #region Degisken
            //Berlirli bir veri türünde data saklamak.
            //veri_tipi degisken_ismi; şeklinde tanımlanır.

            //Ilkel veri tipleri (Primitive Type)
            //Value Type (Değer Tipli): int, oool, double, char, decimal...
            //Değer tipli yapılar belleğin stack alanında bulunduğunda dolayı üzerinde direk belirli bir data alanıyla oluşur.


            //Rerefence Type (Referans/Adres Tipli) string, class, diziler, interfaceler v.b.

            //int ogrencininYasi;
            //ogrencininYasi = 50;
            //ogrencininYasi = 65;
            //Console.WriteLine( ogrencininYasi);

            //string adi = "Fatih";
            //adi = adi + " Alkan";
            //Console.WriteLine(adi);

            //Tam Sayılar
            //byte, 1byte, 0 ile 255 tam sayı değeri alır.
            //sbyte, 1byte, -128 ile 127 tam sayı değeri alır.
            //short 2byte, -32,768 ile 32,767
            //Ushort 2byte 0 ile 65,535 tam
            //int 4byte -2,147,483,648 ile 2,147,483,647
            //uint 4byt 0 ile 4,294,967,295
            //long 8byte -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807
            //ulong 8byte 0


            //Ondalıklı Sayılar
            //float 4byte .dan sonra 6-9 hane 
            //double 8byte .dan sonra 15-17 hane desteği
            //decimal 16byte .dan sonra 28-29 hane desteği (finansal hesaplamalar)

            double degisken = 2.15;   //default olarak ondalıklı bir sayı double kabul edilir.
            float degisken2 = 3.2222f;  //float olduğunu belirtmek için f eklenir.
            decimal degisken3 = 3.8m;  //decimal olduğunu belirtmek için m eklenir.

            //char karakter = 'a';
            //bool devamMi = true;

            //int age = 26;
            //string name = "Ezgi";
            ////
            //Console.WriteLine(nameof(Byte));
            //Console.WriteLine($"Alt Limit      : {Byte.MinValue}");
            //Console.WriteLine($"Üst Limit      : {Byte.MaxValue}");
            //Console.WriteLine($"Boyut          : {sizeof(Byte)}");



            //Console.WriteLine("Merhaba benim yaşım " + age + " benim adım: " + name);   //consola yazdırırken bu 3 seçeneği de kullanabiliriz.
            //Console.WriteLine("Merhaba benim yaşım: {0} benim adım: {1} dır", age, name);
            //Console.WriteLine($"Merhaba benim yaşım: {age} bemim adım: {name}");

            #endregion

            //Gelişmiş Tipler
            //Object degisken1 = "merhaba";
           // Object degisken2 = "sf";
            //Object degisken3 = true;

            var degisken4 = "merhaba";
            var degisken5 = 12;
            var degisken6 = true;

            dynamic degisken7 = "merhaba";
            dynamic degisken8 = 23;
            dynamic degisken9 = true;


            //Console.WriteLine(degisken7 * 2);

            //Compile Time Derleme Zamanı - Run Time Çalışma zamanı anlamına gelir.
        }
    }
}
