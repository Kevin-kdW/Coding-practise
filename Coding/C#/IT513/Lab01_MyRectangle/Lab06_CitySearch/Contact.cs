using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_CitySearch
{
    internal class Contact
    {
		private string surname;

		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}

		private string firstName;

		public string Firstname
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		private string city;

		public string City
		{
			get { return city; }
			set { city = value; }
		}

		private string phone;

		public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}

        public Contact(string surname, string firstName, string address, string city, string phone)
        {
			Surname = surname;
			Firstname = firstName;
			Address = address;
			City = city;
			Phone = phone;
        }

        public override string ToString()
        {
			return $"{firstName} {surname}, {address}, {city}, {phone}";
        }

        
    }
}

