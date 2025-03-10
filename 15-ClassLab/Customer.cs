using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ClassLab
{
    public class Customer
    {
        private static int no = 1000;
        private string firstName;
        private string lastName;
        private int birthYear;

        public Customer(string firstName, string lastName)
        {
            no++;
            Id = no;
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; private set; }

        public string LastName
        {
            set { lastName = Helper.CheckTurkishChracter(value); }
        }
        public string FirstName
        {
            set { firstName = Helper.CheckTurkishChracter(value); }
        }

        public string FullName => $"{firstName} {lastName}";

        /// <summary>
        /// In Year Out Age
        /// </summary>
        public int Age
        {
            get { return DateTime.Now.Year - birthYear; }
            set { birthYear = value; }
        }
    }
}