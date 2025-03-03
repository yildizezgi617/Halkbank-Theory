using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OOP_Class
{
   public class Car          //internal sadece projede erişilebilir dışardan erişilemez
    {

      public string Color;
      public string Brand;
      public string Model;
       public int Speed;


        //public int MyProperty { get; set; }

        public void Drive()
        {
            Console.WriteLine("araba çalıştı"+Color+Model+Brand+Speed);
        }

        public void Start(int speed)
        {
            Speed += speed;
            Console.ForegroundColor = ConsoleColor.Green;

            Drive();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Stop(int speed)
        {
            Speed -= speed;
            Console.ForegroundColor = ConsoleColor.Red;
            Drive();
            Console.ForegroundColor = ConsoleColor.White;

        }




    }

 
}
