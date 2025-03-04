using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ClassLab
{
    public class Customer
    {
        private int birthdate;
        private static int no = 1000;
        public int Id { get; set; }
        private string firstname;
        private string lastname;



		public Customer(string firstName, string lastName)
		{
			no++;
			FirstName = firstName;
			LastName = lastName;
		}


        public Customer()  // constructordayken bu ayarlamayı yapıyorum id otomatik artsın
		{
			no++;
			Id = no;

		}

		

		public int BirthDate
		{
			get 
			{
				return DateTime.Now.Year- birthdate;
			}
			set
			{
				birthdate = value;
			}
		}

	

		public string LastName
		{
			set 
			{ 
				lastname = Helper.CheckTurkishChrackter(value);
			}
		}



		public string FirstName
		{
			set 
			{
				firstname = Helper.CheckTurkishChrackter(value);
			}
		}

		//private string fullname;

		public string FullNane => $"{firstname} {lastname}";
		
	}

	public static class Helper   //static bir class oluşturduk
	{

		public static string CheckTurkishChrackter(string param)
		{
			string[] turkce = new string[] { "ı", "İ", "ü","Ü", "ç", "Ç", "ş", "Ş", "ö", "Ö", "Ğ", "ğ" };
			string[] ingilizce = new string[] { "i", "I", "u", "U", "c", "C", "s", "S", "o", "O", "G", "g" };
			for (int i = 0; i < turkce.Length; i++)
			{
				param = param.Replace(turkce[i], ingilizce[i]);

			}
			return param.ToUpper();
		} 
	} 

}
 