using _23_Generic.UrunTakipOrnek.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Generic.UrunTakipOrnek.Models
{
    public abstract class Product
    {
        private static int id = 0;  //Id Otomatik artması için.
        private int stock;
      
        public Product(string name)
        {
            Name =name;
            Id = id++;
            Stock = stock;
        }
        public int Id { get; set; }
        public string Name { get; }
        public Status Status { get; set; } =Status.Active;                                      

        public decimal Price
        {
            get { return Price; }
            set { if(value > 0)
                    Price = value;
                else
                    throw new Exception.StockAmountException("Fiyat 0 dan kucuk olamaz");
            }
        }


        public int Stock 
        {
            get
            {
                return stock;
            }
            set { 
                if (value>0)
                    stock = value;
                else
                    throw new Exception.StockAmountException();
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, Stock: {Stock}";
        }


        public abstract decimal TaxPrice(); //kdv hesaplama
    }
}
