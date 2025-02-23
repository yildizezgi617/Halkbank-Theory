namespace _04_KararYapılar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If-Else: Bir programın belirli bir koşula göre farklı yolları izlemesidir.

            //Syntax
            /*If(koşul)
             * {
             *      Koşul sağlanıyorsa çalışacak kod alanı.
             * }
             * else
             * {
             *      Koşul sağlanmıyorsa çalışacak kod alanı.
             * }
             */

            //Console.WriteLine("Notunuzu giriniz: ");
            //string result =  Console.ReadLine();
            //int score = int.Parse(result);

            //if (score >= 50)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Tebrikler Geçtiniz... Mükemmel...");
            //}
            //else if (score >= 90 )
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Tebrikler Geçtiniz...");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Üzgünüm Kaldınız!!!");
            //}


            //Mantıksal && - || 
            //Birden fazla koşulu birleştirmek.

            int yas = 25;
            bool ehliyetVarmi = false;

            if (yas >= 18 && ehliyetVarmi == true)
            {
                Console.WriteLine("Araç sürebilirsiniz.");
            }
            else
            {
                Console.WriteLine("Araç süremezsiniz.");
            }

            #region Example-1
            //Kullanıcıdan kilo ve boy alınarak vucut kitle indeksini hesaplanyan programız yazını.
            //Formül:  VKI = kilo/ (boy*boy)
            /* VKI<18.5 - Zayıf
             * 18.5< VKI <24.9 - Normal
             * 25 <= VKI <29.9 - Kilolu
             * 30 <= VKI - Obez
             */

            #endregion

            #region Example-2
            //Kullanıcıdan üçgenin üç kenar uzunluğu alarak üçgenin çeşitkenar mı?, ikizkenar mı? yoksa eşkenar mı? olup olmadığını bulan programı yazınız. 
            Console.WriteLine("Birinc kenar uzunluğunu giriniz: ");
            int kenar1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci kenar uzunluğunu giriniz: ");
            int kenar2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Üküncü kenar uzunluğunu giriniz: ");
            int kenar3 = int.Parse(Console.ReadLine());


            if (kenar1 == kenar2 && kenar2 == kenar3)
            {
                Console.WriteLine("üçgen eşkenardır.");
            }
            else if (kenar1 == kenar2 || kenar2 == kenar3 || kenar1 == kenar3)
            {
                Console.WriteLine("ikizkenar üçgen");
            }
            else
            {
                Console.WriteLine("Çok kenar...");
            }


            #endregion

        }
    }
}