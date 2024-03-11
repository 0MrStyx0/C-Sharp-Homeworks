using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverload.ClassMagazine
{
    internal class Magazine
    {
        public string Name { get; set; }
        public int workersCount { get; set; }

        public Magazine(string name, int workersCount)
        {
            Name = name;
            this.workersCount = workersCount;
        }

        public void showWorkersCount()
        {
            Console.WriteLine("Workers count: " + workersCount);
        }

        public static Magazine operator +(Magazine magazine,int value)
        {
            magazine.workersCount += value;
            return magazine;
        }
        public static Magazine operator -(Magazine magazine, int value)
        {
            magazine.workersCount -= value;
            return magazine;
        }

        public static bool operator ==(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.workersCount == magazine2.workersCount;
        }

        public static bool operator !=(Magazine magazine1, Magazine magazine2)
        {
            return !(magazine1 == magazine2);
        }

        public static bool operator >(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.workersCount > magazine2.workersCount;
        }

        public static bool operator <(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.workersCount < magazine2.workersCount;
        }
    }
}
