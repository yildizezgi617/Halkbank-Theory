namespace _04_KararYapılar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If-Else: Bir programın belirli bir koşula göre farklı yolları izlemesidir. Dallanma denebilir.

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
            //int score = int.Parse(result);  //int.Parse yerine Covert.Tostring ile de yapabilirdik.

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
            //Kullanıcıdan kilo ve boy alınarak vucut kitle indeksini hesaplanyan programız yazınız.
            //Formül:  VKI = kilo/ (boy*boy)
            /* VKI<18.5 - Zayıf
             * 18.5< VKI <24.9 - Normal
             * 25 <= VKI <29.9 - Kilolu
             * 30 <= VKI - Obez
             */

            Console.WriteLine( "sırasıyla boy ve kilo giriniz");
            double boy = Convert.ToInt32(Console.ReadLine());
            double kilo = Convert.ToInt32(Console.ReadLine());
            double index = kilo / (boy * boy);

            if (index<18.5)
            {
                Console.WriteLine("üzgünüm çok zayıfsınız");
            }
            else if(index<24.9)
            {
                Console.WriteLine("normalsiniz");
            }
            else if(index <= 29.9)
            {
                Console.WriteLine("kilolusunuz");
            }
            else if (30 <= index)
            
            {
                Console.WriteLine("obezsiniz");
            }
            else {
                Console.WriteLine("Uygun bir değer giriniz");

            }
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