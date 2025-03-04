namespace _14_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sabit eylemlerde statik, yaratma eylemlerinde newleme
            Console.WriteLine(MathHelper.CalculeteCircleArea(12.5));        //newlemeden kullanabilirdim.

            Counter counter = new Counter();

            //counter.Artis();
            //counter.Artis();
            //counter.Artis();
            //counter.Artis();                                  //statik yokkken
            //Console.WriteLine(counter.count);

            //Counter counter2 = new Counter();
            //Console.WriteLine(counter2.count);



            //eğer Counter sınıfına static deseydim newlememe gerek kalmyacaktı ama sonuc değişecekti

            Console.WriteLine( Counter.count);




        }
    }
}
