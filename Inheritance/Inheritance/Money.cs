using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ClassMoney
{
    internal class Money
    {
        public string Currency { get; set; }
        public int wholePart {  get; set; }
        public int Kopecks {  get; set; }

        public Money(string currency)
        {
            Currency = currency;
        }   

        public void setValue(int wholePart,int Kopecks)
        {
            this.wholePart = wholePart;
            this.Kopecks = Kopecks;
        }

        public virtual void ShowValue()
        {
            Console.WriteLine($"{wholePart}.{Kopecks} {Currency}");
        }
    }

    internal class Product : Money
    {
        public string Name {  get; set; }

        public Product(string name, string currency) : base(currency)
        {
            Name = name;
        }

        public override void ShowValue()
        {
            Console.WriteLine($"{Name} Price:{wholePart}.{Kopecks} {Currency}");
        }

        public void ReducePrice(int wholePart, int Kopecks)
        {
            this.wholePart -= wholePart;
            this.Kopecks -= Kopecks;
        }
    }

}
