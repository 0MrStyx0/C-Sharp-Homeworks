using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1Homework.Magazine
{
    internal class Magazine
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Magazine() { }
        public Magazine(string name, string year, string description, string phoneNumber,string email)
        {
            Name = name;
            Year = year;
            Description = description;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("PhoneNumber: " + PhoneNumber);
            Console.WriteLine("Email: " + Email);
        }
    }
}
