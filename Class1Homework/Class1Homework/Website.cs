using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1Homework.Website
{
    internal class Website
    {
        public string Name {  get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string IP { get; set; }

        public Website() { }
        public Website(string name, string url, string description, string ip)
        {
            Name = name;
            Url = url;
            Description = description;
            IP = ip;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Url: " + Url);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("IP: " + IP);
        }
    }
}
