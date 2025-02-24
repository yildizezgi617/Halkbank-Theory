namespace _10_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)

        {
        /* Hata Yönetimi
         *1-Derleme zamanı hataları(Compiler time errors)
         *2- Çalışma Zamanı Hataları (Runtime Error)
         3-Mantıksal Hatalar (Logical Errors)
        */
        start:
            //try
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("telefon no");
            //        int telNo = int.Parse(Console.ReadLine());    //Hata Gelmesi Muhtemel kodlarımızı yazacağımız alan
            //    }   
            //}
            //catch (Exception ex)   //hatayı oluşturdun ve ex ismini verdin
            //{
            //    //Hata Olduğunda Ne Yapacaksınız
            //    Console.WriteLine("yanlış giriş yaptın");
            //    Console.WriteLine(ex.Message);             //exin mesajını yazdırdın.
            // goto start;
            //}


            //Bu çok genel bir hata yönetimiydi. Daha özelleştirebiliriz o zaman hatayı oluştururken direkt hata türünden oluştururuz.
            //try
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("telefon no");
            //        int telNo = int.Parse(Console.ReadLine());    //Hata Gelmesi Muhtemel kodlarımızı yazacağımız alan
            //    }
            //}
            //catch (OverflowException ex)   //hatayı oluşturdun ve ex ismini verdin
            //{
            //    //Hata Olduğunda Ne Yapacaksınız
            //    Console.WriteLine("Girdiğiniz sayı çok büyük ya da çok küçük");
            //    Console.WriteLine(ex.Message);             //exin mesajını yazdırdın.
            //    goto start;
            //}
            //catch (FormatException ex)   //hatayı oluşturdun ve ex ismini verdin
            //{
            //    //Hata Olduğunda Ne Yapacaksınız
            //    Console.WriteLine("Geçersiz giriş lütfen bir tamsayı giriniz");
            //    Console.WriteLine(ex.Message);             //exin mesajını yazdırdın.
            //    goto start;

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine( "bir hata oluştu");   //Bunu en başa yazsaydık tüm hatalarda bu mesaj dönerdi özelleştirmenin bir anlamı kalmazdı.
            //    Console.WriteLine(ex.Message);
            //    goto start;
            //}
            //finally
            //{                                        //Finally hata gelse de gelmese de çalışır.

            //    Console.WriteLine("ben hata gelse de gelmese de çalışırım");

            //}

            //TryParse, tip dönüşümlerinde hatalar çok olur. bu yüzden burda onun kontrolünü yapıyoruz. true ya da false dönüyor. dönüşürse out ifadesi ile belirtilen ifadeye dönüştürdüğü sayıyı yükleme yapıyor.
            //basla:
            //Console.WriteLine("bir sayı gir");
            //string sayi = Console.ReadLine();
            //int donusensayi = 0;

            //bool gecerliSayi = int.TryParse(sayi,out donusensayi);

            //if(!gecerliSayi) {
            //    Console.WriteLine("geçersiz giriş yaptınız tekrar deneyiniz");
            //    goto basla;
            //}
            //Console.WriteLine("Girdiğiniz sayi"+sayi);


            //KULLANICIDAN 0 İLE 100 ARALIĞINDA DEĞER AL KONTROLÜNÜ YAP
            //Burada hem sayı olup olmadığını hem de değer aralığını kontrol etmem lazım.
            int not;
            bool gecerliNot = false;
            while (!gecerliNot)
            {
                Console.WriteLine("0 ile 100 arası değer giriniz");
                string girdi = Console.ReadLine();  
                if(int.TryParse(girdi, out not) && not >=0 && not<=100) {

                    Console.WriteLine("girilen not"+not);
                }
            }          
        }
    }
}