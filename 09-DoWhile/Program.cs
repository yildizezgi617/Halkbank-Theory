namespace _09_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //koşula bakmadan önce yapılacak olan işi yapar sonra döngüye başlar.
            string sifre;
            //do
            //{
            //    Console.WriteLine("şifreyi girin");
            //    sifre = Console.ReadLine();  
            //} while (  sifre != "Admin123");

            //kullanıcıdan geçerli yaş girene kadar sürekli yaş sorun. yaş 0 ile 120 arasında olmalıdır. bu aralık dışında her girişte program tekrar sormalıdır.


            int yas;

            do
            {
                Console.WriteLine("yaş?");
                yas = int.Parse(Console.ReadLine());
                
                if(yas<0 || yas > 120)
                {
                    Console.WriteLine("geçersiz yaş");
                }

            } while (yas < 0 || yas > 120);
        }
    }
}