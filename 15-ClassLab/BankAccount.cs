using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ClassLab
{
    public class BankAccount
    {
        private string accountNumber;

        public readonly Customer Customer;
        public BankAccount(string accountNumber, Customer customer)
        {
            this.accountNumber = accountNumber;
            this.Customer = customer;
        }
        public BankAccount(string accountNumber, Customer customer, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.Customer = customer;
            this.balance = balance;
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Deposit amount must be positive number.");
            balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("WithDraw amount must be positive number.");
            if (amount > balance)
                throw new InvalidOperationException("Insufficient funds.");
            balance -= amount;
        }

    }
}