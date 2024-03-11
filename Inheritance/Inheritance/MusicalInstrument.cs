using Inheritance.ClassDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance.ClassMusicalInstrument
{
    internal abstract class MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }

        public void Sound() { }
        public void Show() { }
        public void Desc() { }
        public void HistoryShow() { }
    }

    class Violin : MusicalInstrument
    {
        public Violin(string name)
        {
            Name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Violin Sound!");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }

        public void Desc()
        {
            Console.WriteLine("Violin Desc");
        }

        public void HistoryShow()
        {
            Console.WriteLine("Violin History");
        }
    }

    class Trombone : MusicalInstrument
    {
        public Trombone(string name)
        {
            Name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Trombone sound!");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }

        public void Desc()
        {
            Console.WriteLine("Trombone desc");
        }

        public void HistoryShow()
        {
            Console.WriteLine("Trombone History");
        }
    }

    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name)
        {
            Name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Ukulele sound!");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }

        public void Desc()
        {
            Console.WriteLine("Ukulele desc");
        }

        public void HistoryShow()
        {
            Console.WriteLine("Ukulele History");
        }
    }

    class Cello : MusicalInstrument
    {
        public Cello(string name)
        {
            Name = name;
        }

        public void Sound()
        {
            Console.WriteLine("Cello sound!");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }

        public void Desc()
        {
            Console.WriteLine("Cello desc");
        }

        public void HistoryShow()
        {
            Console.WriteLine("Cello History");
        }
    }
}
