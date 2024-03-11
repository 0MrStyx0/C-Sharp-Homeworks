using OperatorsOverload.ClassMagazine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace OperatorsOverload.ClassShop
{
    internal class Shop
    {
        public string Name { get; set; }
        public int Square { get; set; }

        public Shop(string name, int Square)
        {
            Name = name;
            this.Square = Square;
        }

        public void showSquareCount()
        {
            Console.WriteLine("Square count: " + Square);
        }

        public static Shop operator +(Shop shop, int value)
        {
            shop.Square += value;
            return shop;
        }
        public static Shop operator -(Shop shop, int value)
        {
            shop.Square -= value;
            return shop;
        }

        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.Square == shop2.Square;
        }

        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return !(shop1 == shop2);
        }

        public static bool operator >(Shop shop1, Shop shop2)
        {
            return shop1.Square > shop2.Square;
        }

        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.Square < shop2.Square;
        }
    }
}
