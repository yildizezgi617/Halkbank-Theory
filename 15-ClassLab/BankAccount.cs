using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _15_ClassLab
{
    class BankAccount
    {
		private string accountNumber;


		public BankAccount(string accountNumber, Customer customer)
		{
			this.accountNumber = accountNumber;
			this.Customer = customer;
		}
		public Customer Customer { get; set; }

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
			if (amount<0)
			{
				throw new ArgumentException("Girilen değer 0 olmalı");
				balance += amount;

			}
		}

		public void WithDraw(decimal amount)
		{
            if (amount < 0)
            {
                throw new ArgumentException("Girilen değer 0 olmalı");
                balance += amount;
            }

            if (amount < balance)
            {
                throw new  InvalidOperationException("Yetersiz bakiye");
				balance -=amount;
            }

        }









	}
}
