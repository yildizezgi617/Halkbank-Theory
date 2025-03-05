namespace _18_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(WorkDays.Sunday);
            Console.WriteLine((int)WorkDays.Friday);
            Console.WriteLine((WorkDays)5);


            Order order = new Order() { OrderId = 1, Status = OrderStatus.Pending };
            order.Status =OrderStatus.Shipped;
            
        }
    }
}
