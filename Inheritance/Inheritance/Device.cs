using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ClassDevice
{
    internal abstract class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }


        public void Sound() { }
        public void Show() { }
        public void Desc() { }
    }

    class Kettle:Device
    {
        public Kettle(string name)
        {
            Name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Chooo!");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }

        public void Desc()
        {
            Console.WriteLine("a hollow product (vessel) of various shapes with a lid, handle and spout (there are also kettles without a spout), intended for boiling water and brewing tea");
        }
    }

    class Microwave:Device
    {
        public Microwave(string name)
        {
            Name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Dzin!");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }

        public void Desc()
        {
            Console.WriteLine("an electrical appliance that allows heating of water-containing substances thanks to electromagnetic radiation in the decimeter range (usually with a frequency of 2450 MHz) and is intended for quickly preparing, heating or defrosting food.");
        }
    }

    class Car : Device
    {
        public Car(string name)
        {
            Name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Bip!");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }

        public void Desc()
        {
            Console.WriteLine("Earth transport");
        }
    }

    class Ship : Device
    {
        public Ship(string name)
        {
            Name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Wooooo!");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }

        public void Desc()
        {
            Console.WriteLine("Sea transport");
        }
    }
}
