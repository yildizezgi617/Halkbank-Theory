using _19_Inheritance.Example1;
using _19_Inheritance.Example2;
using _19_Inheritance.Example3;

namespace _19_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example-1
            //Device device1 = new Device("i5", 18, 500);
            //Device device2 = new Device("i5", 18, 500);

            //if (device1.Equals(device2))
            //{
            //    Console.WriteLine("Eşittir");
            //    Console.WriteLine("Device 1: " + device1.GetHashCode());
            //    Console.WriteLine("Device 2: " + device2.GetHashCode());
            //}
            //else
            //{
            //    Console.WriteLine("Eşit değildir.");
            //    Console.WriteLine("Device 1: " + device1.GetHashCode());
            //    Console.WriteLine("Device 2: " + device2.GetHashCode());
            //}


            ////AllInOne allInOne = new AllInOne("i5", 16, 500, "su");

            ////Console.WriteLine(allInOne.ToString());

            //List<Device> devices = new List<Device>();
            //devices.Add(new Desktop("i5", 32, 500, "su"));
            //devices.Add(new Desktop("i7", 32, 500, "su"));
            //devices.Add(new Laptop("i7", 32, 500, 3 ));
            //devices.Add(new Laptop("i3", 8, 250, 2));

            //foreach (var item in devices)
            //{

            //    Console.WriteLine(item.ToString());

            //    //if (item.GetType() == typeof(Desktop))
            //    //{
            //    //    ((Desktop)item).
            //    //}
            //    //else
            //    //{ 
            //    //    ((Laptop)item).
            //    //}

            //    //if (item is Laptop)
            //    //{ 
            //    //    (item as Laptop).
            //    //}
            //}


            //List<object> objects = new List<object>();
            //objects.Add(1);
            //objects.Add(3);

            //foreach (var item in objects)
            //{
            //    Console.WriteLine((int)item*2);
            //}
            #endregion

            //Phone phone = new Phone("Brand");

            //MobilPhone phone2 = new MobilPhone("Nokia",true,false);

            //SmartPhone phone3 = new SmartPhone("Iphone", true, true, true);

            //List<Phone> phones = new List<Phone>();
            //phones.Add(phone);
            //phones.Add(phone2);
            //phones.Add(phone3);

            //foreach (var item in phones)
            //{
            //    Console.WriteLine(item.ToString());
            //}


            Employee employee = new FullTimeEmployee() { Id = 1, Name = "Fatih", AnnualSalary = 100 };
            Employee employee1 = new PartTimeEmployee() { Id = 2, Name = "Hasan", HoursWorked = 100, HourlyRate = 2 };



        }
    }
}
