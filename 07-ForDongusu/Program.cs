namespace _07_ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //syntax for(baslangic; kosul; guncelleme(artış/azılış))
            //{
            //   Kod bloğu
            //}

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Merhaba Dünya");
            }

            //for (; ; )
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //}

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} x {j} = {i * j}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
   