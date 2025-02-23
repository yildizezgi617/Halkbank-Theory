namespace _06_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch
            //int gun = 4;

            //switch (gun)
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz Gün");
            //        break;
            //}




            Console.WriteLine("Harf notunuzu giriniz:");
            char harfNotu = Convert.ToChar(Console.Read());

            switch (harfNotu)
            {
                case 'a':
                    Console.WriteLine("geçtiniz harika");
                    break;


                case 'b':
                    Console.WriteLine("ortalama geçtiniz");
                    break;

                case 'c':
                    Console.WriteLine("şartlı geçtiniz");
                    break;

                case 'd':
                    Console.WriteLine("kaldınız");
                    break;
                default:
                    Console.WriteLine("a,b,c,d değerlerinden birini giriniz");
                    break;






            }


            #endregion

            #region Mevsim

            int ay = 6;

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevisimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevisimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimi");
                    break;
                default:
                    break;
            }

            #endregion


            #region Switch When
            //C#'da switch ifadesi içinde when koşulu kullanarak daha spesifik karşılaştırmalar yapılabilir.
            ////when, case koşullarına ek şartlar eklemeni sağlar.
            //Sayının pozitif, negatif, string, diğer türleri olup olmadığını kontrol eden bir program yazınız.

            object veri = true;


            switch (veri)
            {
                case int sayi when sayi > 0:
                    Console.WriteLine("Pozitif bir tam sayıdır.");
                    break;
                case int sayi when sayi < 0:
                    Console.WriteLine("Negatif bir tam sayıdır.");
                    break;
                case string:
                    Console.WriteLine("Bir string girdiniz.");
                    break;
                default:
                    Console.WriteLine("Tanımlanmayan bir tür");
                    break;
            }
            #endregion

            #region Switch Pattern Matching

            double sayi1 = 6;
            double sayi2 = 3;

            //+, -, *, /
            char islem = '*';

            double sonuc = islem switch
            {
                '+' => sayi1 + sayi2,
                '-' => sayi1 - sayi2,
                '*' => sayi1 * sayi2,
                '/' => sayi1 / sayi2,
                _ => double.NaN
            };

            if (double.IsNaN(sonuc))
                Console.WriteLine("Bilgilendirme");
            else
                Console.WriteLine("Sonuç: " + sonuc);

            #endregion

            #region Mevsim 2

            int ayNumarası = 6;

            string mevsim = ayNumarası switch
            {
                12 or 1 or 2 => "Kış",
                3 or 4 or 5 => "İlkbahar",
                6 or 7 or 8 => "Yaz",
                9 or 10 or 11 => "Sonbahar",
                _ => "Geçersiz ay numarası."
            };

            Console.WriteLine("Mevsim: " + mevsim);

            #endregion

        }
    }
}