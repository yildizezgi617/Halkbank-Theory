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
            List<Product> products = new List<Product>() { //Bu liste product istediği için once product nesnemi oluşturdum ve değerlerini verdim.
                new Product() {Code="101", Name ="Kalem-1", Price=56, Stock=100},
                new Product() { Code="102", Name="Kalem-2", Price=35, Stock=100 },
              new Product() { Code="103", Name="Kalem-3", Price=55, Stock=100 },
              new Product() { Code="104", Name="Kalem-4", Price=65, Stock=100 },
              new Product() { Code="105", Name="Kalem-5", Price=58, Stock=100 },
              new Product() { Code="106", Name="Kalem-6", Price=51, Stock=100 },


                };
            Order order = new Order();
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
                foreach (var item in order.GetProduct())
                {
                    Console.WriteLine($"Adı : {item.Fullname} Fiyati :{item.Price}");

                }
                Console.WriteLine( "toplam tutar :" + order.CalculateTotal());
            }
            #endregion
        }
    }
}
