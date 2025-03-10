using _23_Generic.Exceptions;
using _23_Generic.Models;
using _23_Generic.Repository.Concrete;

namespace _23_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryManagement<FoodProduct> inventoryFood = new InventoryManagement<FoodProduct>();

            foreach (var item in inventoryFood.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n" + new string('*', 20) + "\n");
            inventoryFood.Add(new FoodProduct("Kivi", 100, DateTime.Now.AddDays(10)) { Price = 100 });

            foreach (var item in inventoryFood.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n" + new string('*', 20) + "\n");

            var product = inventoryFood.Get(3);
            Console.WriteLine(product);

            Console.WriteLine("\n" + new string('*', 20) + "\n");

            inventoryFood.Add(product);

            foreach (var item in inventoryFood.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n" + new string('*', 20) + "\n");

            try
            {
                inventoryFood.Update(new FoodProduct("Kivi", 200, DateTime.Now.AddDays(10)), 6);

                Console.WriteLine("\n" + new string('*', 20) + "\n");

                foreach (var item in inventoryFood.GetAll())
                {
                    Console.WriteLine(item);
                }
            }
            catch (StockAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            InventoryManagement<ElectronicProduct> inventoryManagement = new InventoryManagement<ElectronicProduct>();

            foreach (var item in inventoryManagement.GetAll())
            {
                Console.WriteLine(item);
            }


        }
    }
}