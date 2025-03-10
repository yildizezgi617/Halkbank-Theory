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
       public int fuel;


        //public int MyProperty { get; set; }


        public Car(int _fuel)   //constructor yapıcı method. instance alındığında ilk çalışan method.
        {
            fuel = _fuel;
        }
        public Car()            //yakıtlı da yakıtsız da oluşturabiliriz.  method overloading
        {

        }
        public Car( string _model,int _fuel)
        {
          
            Model = _model;

            fuel = _fuel;
        }

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
