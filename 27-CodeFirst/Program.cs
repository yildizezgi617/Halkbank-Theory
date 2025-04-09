using _27_CodeFirst.Contexts;
using _27_CodeFirst.Models;
using System.Net.Http.Headers;

namespace _27_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext context = new AppDbContext())  
            {
                //var newCustomer = new Customer { Name = "Fatih" , Phone ="55555"};
                //context.Customers.Add(newCustomer);

                ////context.Orders.Add(new Order
                ////{
                ////    OrderDate = DateTime.Now,
                ////    TotalAmount = 100.50m,
                ////    Customer = newCustomer
                ////});
                
                //Console.WriteLine(context.SaveChanges()>0 ? "Ekleme başarılı": "Ekleme başarısız");



                #region EntityStates
                var customer = new Customer() { Name = "Huseyin" };  //Detachted 
                Console.WriteLine(context.Entry(customer).State);

             

                context.Add(customer);
                Console.WriteLine(context.Entry(customer).State);
                context.SaveChanges(); 
                Console.WriteLine(context.Entry(customer).State);


                #endregion
            }
        }
    }
}
