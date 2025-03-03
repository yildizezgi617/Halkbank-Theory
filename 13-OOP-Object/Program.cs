namespace _13_OOP_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region bolum1
            //    Product kalem = new Product();
            //    try
            //    {
            //        Console.WriteLine("Kalem adı giriniz");
            //        kalem.Name = Console.ReadLine();
            //        Console.WriteLine("kalem fiyatı giriniz");
            //        kalem.Price = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"Girilen kalem {kalem.Name} girilen fiyat {kalem.Price}");
            //        kalem.Code = "1645151";
            //        // kalem.Fullname ="kfkfkk" bunu kullanamayız çünkü sadece get
            //        Console.WriteLine(  kalem.Fullname);



            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine(ex.Message);
            //    }
            #endregion


            #region Bolum2
            ICollection<Product> products = new List<Product>() { //Bu liste product istediği için once product nesnemi oluşturdum ve değerlerini verdim.
                new Product() {Code="101", Name ="Kalem-1", Price=56, Stock=100},


                };

            while (true)
            {
                foreach (var item in products)
                {
                    Console.WriteLine( $"adi {item.Fullname} Fiyatı {item.Price}");
                }
                Console.WriteLine("sipariş adet");
                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("sipariş kodu");
                    int no = int.Parse(Console.ReadLine());
                    order.AddProduct(products[no]);
                }
                Console.WriteLine( "siparişleriniz");
                foreach (var item in Order.GetProduct())
                {
                    Console.WriteLine($"Adı : {item.Fullname} Fiyati :{item.Price}");

                }
                Console.WriteLine( "toplam tutar :");
            }
            #endregion
        }
    }
}
