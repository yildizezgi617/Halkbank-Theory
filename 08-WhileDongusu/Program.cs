namespace _08_WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool devamMi = true;
            //while(devamMi)
            //{
            //    Console.WriteLine("devam etmek istiyor musunuz[E] [H]");
            //    string result = Console.ReadLine().ToUpper();     //Bu bir string methodudur. Yazılan metni büyük harfli hale getirmek için kullanılır. Geriye string döndüren bir methoddur.
            //    if (result == "H"){
            //        devamMi = false;

            //    }
            //    Console.WriteLine("döngünün içersindesin");
            //}


            //int sayac = 0;
            //while (sayac < 10)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //}

            //string sifre = "";
            //while(sifre != "Admin123")
            //{
            //    Console.WriteLine("şifreyi girin");
            //    sifre = Console.ReadLine();
            //    if(sifre!= "Admin123")
            //        Console.WriteLine("hatalı şifre tekrar deneyin");
            //}
            //Console.WriteLine("başarılı giriş");

            #region Soru1
            //Bir tahmin oyunu yapıyorsunuz. pc ile 1 ile 100 arasında rastgele bir sayı tutacak ve kullanıcı bu sayıyı bulana kadar tahminlerde bulunacak.
           // FileSystemWatcher tahminden sonra bilgisayar kullanıcının tahmininin küçük mü büyük mü olduğunu bildirecek

            Random random = new Random();
            int tutulanSayi = random.Next(1, 10);
            Console.WriteLine("Bir sayı giriniz");
            int tahminSayi = 0;
            

            while(tahminSayi != tutulanSayi)
            {
                Console.Beep();
                 Console.WriteLine("Bir tahmin yapın(1-10");
                tahminSayi = int.Parse(Console.ReadLine());
                if (tahminSayi < tutulanSayi)
                {
                    Console.WriteLine("daha büyük bir sayı girin");
                }
                else if(tahminSayi>tutulanSayi)
                {

                    Console.WriteLine("daha küçük bir sayı girin");
                }
             

            }
            Console.WriteLine("doğru tahmin");
            #endregion
        }
    }
}