using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Enum
{
    class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }


        public void PrintStatus()
        {
            Console.WriteLine($"Order {OrderId} Status {Status}");
        }
    }





    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }



}
