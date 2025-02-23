namespace _03_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aritmatik Operatörler
            //Aritmatik Operatörler
            //Toplama (+)
            //Fark (-)
            //Çarpım (*)
            //Bölüm (/)
            //Mod (%);

            //int a = 6;
            //int b = 5;

            //int toplam = a + b;

            //String bir ifadeyle (+) birlikte kullanıldığında birleştirme operatörü olarak görev alır.
            //Console.WriteLine("Birleştirme operatörü " + (a + b));

            //int fark = a - b;
            //int carpim = a * b;
            //int bolum = a / b;
            //int kalan = a % b;
            #endregion

            #region Atama Operatörleri

            //int sayi = 10; //(=) atama operatörü
            //sayi = sayi + sayi;

            ////Birleşim operatörleri

            //int toplam = 5;
            //toplam += toplam;

            //int fark = 7;
            //fark -= 3;

            //*=, /=
            #endregion

            #region Artırma ve Azaltma

            //int i = 1;
            //Console.WriteLine(i++ + ++i - ++i - --i - i--);

            //-6,

            #endregion

            #region Karşılaştırma Operatörler

            int a = 5, b = 6;

            bool esitMi = (a == b);
            bool esitDegilMi = (a != b);
            bool kucukMu = (a < b);
            bool kucukEsitMi = (a <= b);
            bool buyukMu = (a > b);
            bool buyukEsitm = (a >= b);
            #endregion

            #region Mantıksal Operatörler
            //AND (&&): her iki koşulunda true olması durumunda sonucu true verir.

            bool c = false;
            bool d = false;

            bool sonuc = c && d;

            bool e = false;
            bool f = false;

            bool sonuc1 = e || f;

            Console.WriteLine(sonuc1);

            #endregion
        }
    }
}