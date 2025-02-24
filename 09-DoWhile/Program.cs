namespace _09_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //koşula bakmadan önce yapılacak olan işi yapar sonra döngüye başlar.
            //string sifre;
            //do
            //{
            //    Console.WriteLine("şifreyi girin");
            //    sifre = Console.ReadLine();  
            //} while (  sifre != "Admin123");

            //kullanıcıdan geçerli yaş girene kadar sürekli yaş sorun. yaş 0 ile 120 arasında olmalıdır. bu aralık dışında her girişte program tekrar sormalıdır.


            //int yas;

            //do
            //{
            //    Console.WriteLine("yaş?");
            //    yas = int.Parse(Console.ReadLine());

            //    if(yas<0 || yas > 120)
            //    {
            //        Console.WriteLine("geçersiz yaş");
            //    }

            //} while (yas < 0 || yas > 120);
            //Console.WriteLine("geçerli bir yaş");

            #region Kontrol Deyimleri
            //Break, bir döngüyü veya switch yapısını anında sonlandırmak için (scope yapısının dışına tamak için) kullanılır.
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;    //5 olduğunda breake gelerek döngüyü kırar.
                Console.WriteLine(i);
            }

            //Continue, döngüyü ya da switchi bozmaz iterasyon atlatır.
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;    //5 olduğunda yazdırmaz diğer tüm değerleri yazdırır.
                Console.WriteLine(i);
            }

            //Return değer döndürmek için kullanılır.
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    return;    //
                Console.WriteLine(i);
            }

            //goto
            int sayac = 0;
            start:                  //sayac 1 arttırıldıktan sonra buraya gelir.
            if (sayac < 5)
            {
                Console.WriteLine(sayac);
                sayac++;
                goto start;  //döngü oluşturulmuş gibi olur. startın ilk tanımlandığı yere gider.
            }
            #endregion
        }
    }
}