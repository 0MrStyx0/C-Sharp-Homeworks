using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.NotationConverter
{
    internal class NotationConverter
    {
        public static void ConvertNumber(string number, int baseNotation, int finalNotation)
        {
            int baseNumber = Convert.ToInt32(number, baseNotation);
            string finalNumber = Convert.ToString(baseNumber, finalNotation);
            Console.WriteLine("Result: " + finalNumber);
        }
    }
}
