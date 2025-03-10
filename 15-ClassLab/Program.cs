namespace _15_ClassLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Anıl", "Yılmaz") { Age = 1990 };
            Customer customer2 = new Customer("Hasan", "Özdemir") { Age = 1994 };
            Customer customer3 = new Customer("Zeynmep", "Arı") { Age = 1993 };

            BankAccount bankAccount1 = new BankAccount(Guid.NewGuid().ToString(), customer1);
            BankAccount bankAccount2 = new BankAccount(Guid.NewGuid().ToString(), customer2, 50000);

            Console.WriteLine($"Hesabın sahibi: {bankAccount1.Customer.FullName} Miktar: {bankAccount1.Balance}");
            bankAccount1.Deposit(5000);
            Console.WriteLine($"Hesabın sahibi: {bankAccount1.Customer.FullName} Miktar: {bankAccount1.Balance}");
            bankAccount1.WithDraw(2000);
            Console.WriteLine($"Hesabın sahibi: {bankAccount1.Customer.FullName} Miktar: {bankAccount1.Balance}");



        }
    }
}