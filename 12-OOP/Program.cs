namespace _12_OOP_Class
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            
            Car car1 = new Car();
            car1.Brand = "TOGG";
            car1.Model = "X101";
            car1.Color = "Blue";
            car1.Drive();
            car1.Speed = 20;


            Car car2 = new Car();
            car2.Brand = "Fiat";
            car2.Model = "Egea";
            car2.Color = "Red";
            car2.Speed = 10;
            car2.Drive();


            int i = 0;
            bool devamMi = true;
            while (true)
            {
                Random rnd = new Random();
                int hiz = rnd.Next(1, 40);
                int fren = rnd.Next(2, 8);
                if (i%2==0)
                {
                    car1.Start(hiz);
                    car2.Stop(fren);
                }
                else
                {
                    car1.Stop(fren);
                    car2.Start(hiz);
                }

                i++;
                if (car1.Speed >300 || car2.Speed>300)
                {
                    devamMi = false;
                }
                Thread.Sleep(2000);
               
            }
            if (car1.Speed > car2.Speed)
            {
                Console.WriteLine("araba 1 kazandi " );
                car1.Drive();

            }
            else
            {
                Console.WriteLine("araba 2 kazandi");
                car2.Drive();

            }



        }
    }
}
