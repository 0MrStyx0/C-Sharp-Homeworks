using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Class1Homework.Shop
{
    internal class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Shop() { }
        public Shop(string name, string address, string description, string phoneNumber, string email)
        {
            Name = name;
            Address = address;
            Description = description;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("PhoneNumber: " + PhoneNumber);
            Console.WriteLine("Email: " + Email);
        }
    }
}
