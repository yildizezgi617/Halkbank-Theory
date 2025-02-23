namespace _02_TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Belirli bir veri tipinin diğer bir veri tipine dönüştürülmesi olayıdır.


            //Explicit (Açık) Dönüşüm: Bir veri kaybı yaşanma ihtimali vardır. Büyükten küçüğe dönüşüm denebilir. int>short
            int degiskenX = 1243524213;
            short degiskenY = (short)degiskenX; //kayıp olabileceğini biliyorum, sorumluluğu üstüme alıyorum,dönüştürmek istediğim tipi "açıkça" parantez içinde ekliyorum. (short)
            //Console.WriteLine(degiskenY);

            int a = 56;
            short b = (short)a;


            long e = 12;
            int c = (int)e;  //long>int


            //Implicit (Kapalı) Dönüşüm: Herhangi bir veri kaybı yaşanma ihtimali yoktur.
            short degisken1 = 12;
            int degisken2 = degisken1;

            //Console.WriteLine(degisken2);

            #region Convert Sınıfı
            //.NET Frameworkte yerleşik olarak bulunan bir veri tipini başka bir veri tipine dönüştürmek için kullanılan bir araçtır. (Ilkel veri tipleri)
            //staticitr. Yani instance alınmadan kullanılabilir. 
            //Convert.To(byte,Int32,Int16(short),Int64(long),String,Single(float)   Neye dönüştüreceksen onu seçeceksin.

            Console.WriteLine("deger giriniz");
            //string kuldeger = Console.ReadLine();
            //bool booldeger = Convert.ToBoolean(kuldeger);
            //Console.WriteLine(booldeger);


            //bool deneme = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine(deneme);

            float x = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine($"x in degeri {x}");

            string str = "123";
            int number = Convert.ToInt32(str);
           // Console.WriteLine(number);

            bool str1 = false;
            int bool1 = Convert.ToInt32(str1);

            int karakter1 = 64;
            char integer1 = Convert.ToChar(karakter1);

            double double1 = 13.99;
            int sayi1 = Convert.ToInt32(double1); //14
            //Console.WriteLine();

            #endregion


            #region Parse Metodu
            //Sadece string bir girdiyi hedef veri tipine dönüştrebilir. Parse metodu Convert sınıfına göre daha hızlı çalışır.

            string numberString = "123";

            int result1 = int.Parse(numberString);
            double result2 = double.Parse(numberString);
            //bool result3 = bool.Parse(numberString);  //numberstring =1 olsaydı true dönerdi

            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine(number3);
            #endregion

            #region ToString()

            bool denem1 = true;
           // Console.WriteLine(denem1.ToString() + 2);
           // Console.WriteLine(22.ToString() + 2);

            #endregion

            object obj1 = "123";
            int int1 = Convert.ToInt32(obj1);
            int int2 = int.Parse(obj1.ToString());
            //int int3 = (int)obj1;

            //is ve as kullanım, typeOf ve GetType (ileride öğrenilecek)

            string degisken12;
            degisken12 = "Merhaba";
            degisken12 = "Fatih";

            //Console.WriteLine(degisken12);

            //Nullable,
            //Sadece stringlere null atanır ama bu özellik sayesinde doğum tarihi vs gibi yerlerde de null atamamız mümkün oluyor.
            string denemeA = null;

            int? denemeB = null;

            //Console.WriteLine();

            #region Checked-Uncheked
            //

            int max = int.MaxValue; // 'max', int türündeki en büyük değeri alır.

            int result = checked(max - 10);  // 'max' değerinden 10 çıkarılır ve 'checked' kullanılarak overflow kontrolü yapılır.
            // checked anahtar kelimesi, aritmetik işlemler sırasında overflow(değerin veri tipinin sınırlarını aşması) durumlarını kontrol eder.
            //unchecked: Overflow durumunda hata fırlatmaz ve veri tipinin sınırlarına göre değeri döner (genellikle taşan değeri döndürür).
            Console.WriteLine(result);

            #endregion
        }
    }
}