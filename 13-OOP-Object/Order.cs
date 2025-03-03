using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_Object
{
    public class Order //public unutma
    {

        private List<Product> products = new List<Product>(); // liste referans tip olduğu için newledik.
        public List<Product> GetProduct() => products; //sadece okunabilir ve tek satırlı. //aynı ürün var mı varsa adedini arttır.



        public void AddProduct(Product product) //Product tipinde product aldım
        {
            products.Add(product);  //productliste aldığım productı ekledim
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}
