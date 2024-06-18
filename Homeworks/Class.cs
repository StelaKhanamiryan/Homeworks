using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    public class Data
    {
       
        public string path = @"C:\Users\Home\Desktop\homework\data.txt";
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public void PrintData()
        {
            Address = new Address();
            using (StreamReader sr = new StreamReader(path))
            {
                Name = sr.ReadLine();
                Surname = sr.ReadLine();
                Age = Convert.ToInt32(sr.ReadLine());
                Address.Country = sr.ReadLine();
                Address.City = sr.ReadLine();
                Address.Street = sr.ReadLine();
                Address.Apartment = sr.ReadLine();
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Address MyAddress { get; set; }
    }
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Apartment { get; set; }

    }

}

