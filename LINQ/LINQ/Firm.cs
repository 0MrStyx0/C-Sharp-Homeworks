using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.ClassFirm
{
    internal class Firm
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string DirectorName { get; set; }
        public string DirectorSurame { get; set; }
        public string Address { get; set; }
        public int WorkersCount { get; set; }

        public DateTime date { get; set; }
        public Firm() { }
    }
}
