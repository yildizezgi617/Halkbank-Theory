using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Generic.UrunTakipOrnek.Exception
{
    public class StockAmountException : System.Exception

    {
        public StockAmountException()
        {
            Console.WriteLine("stok 0dan küçük olamaz tarih:"+ DateTime.Now);
        }


        public StockAmountException(string message) : base(message)
        {
            Console.WriteLine("stok 0dan kucuk olamaz");
            Console.WriteLine(message);
        }

        public StockAmountException(string message, IOException exception) : base(message, exception)
        {
            Console.WriteLine(  "stok 0 dan kucuk olamaz");
            Console.WriteLine(message);
            Console.WriteLine(exception.StackTrace);
        }
    }
}
