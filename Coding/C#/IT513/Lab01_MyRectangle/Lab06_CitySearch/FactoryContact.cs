using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_CitySearch
{
    internal class FactoryContact
    {
        public static Contact CreateFactory(string line) 
        {
            string[] parts = line.Split(":");
            string surname = parts[0];
            string firstName = parts[1];
            string address = parts[2];
            string city = parts[3];
            string phone = parts[4];
            return new Contact(surname,firstName,address,city,phone);
        }
    }
}
