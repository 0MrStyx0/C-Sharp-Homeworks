using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeAndDestructor
{
    internal class Shop:IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public int ShopCount {  get;}

        public Shop() { Count++; ShopCount = Count; }
        public Shop(string name, string address, string type)
        {
            Count++;
            ShopCount = Count;
            Name = name;
            Address = address;
            Type = type;
        }

        private static int Count = 0;

        public void Dispose()
        {
            Console.WriteLine($"Shop {ShopCount} was disposed");
            Count--;
        }
    }
}
