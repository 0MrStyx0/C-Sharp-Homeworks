using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicHomeWork.Checker
{
    internal class Checker
    {
        public static void PrintError()
        {
            Console.WriteLine("Error!");
            Thread.Sleep(1000);
            Console.Clear();
        }
        public static bool checkMenuOrPercent(in string choice)
        {
            if(string.IsNullOrEmpty(choice)) return false;

            for(int i = 0; i < choice.Length; i++)
            {
                if (choice[i] < 48 || choice[i] > 57) return false;
            }

            try
            {
                int convertedChoice = Convert.ToInt32(choice);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool checkTask1(in string num)
        {
            if(string.IsNullOrEmpty(num)) return false;

            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] == '-') continue;
                else if (num[i] < 48 || num[i] > 57) return false;
            }

            try
            {
                int Cnum = Convert.ToInt32(num);
                if (Cnum < 1 || Cnum > 100) throw new Exception();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool checkNumberTask2(in string num)
        {
            if (string.IsNullOrEmpty(num)) return false;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '-') continue;
                else if (num[i] < 48 || num[i] > 57) return false;
            }

            try
            {
                int Cnum = Convert.ToInt32(num);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool checkTask3(in string num)
        {
            if (string.IsNullOrEmpty(num)) return false;
            if (num.Length > 1) return false;
            if (num[0] < 48 || num[0] > 57) return false;

            return true;
        }

        public static bool checkTask4(in string num)
        {
            if(string.IsNullOrEmpty(num)) return false;
            if (num.Length < 6 || num.Length > 6) return false;
            if (num[0] == '0') return false;
            for (int i = 0; i < num.Length; i++) 
            {
                if (num[i] < 48 || num[i] > 57) return false;
            }
            return true;
        }
        public static bool checkIndexTask4(in string index)
        {
            if (string.IsNullOrEmpty(index)) return false;
            if (index.Length > 1) return false;
            if (index[0] < 49 || index[0] > 57) return false;
            if (Convert.ToInt32(index) > 6) return false;
            return true;
        }

        public static bool checkYear(in string year)
        {
            if (string.IsNullOrEmpty(year)) return false;
            if (year.Length > 4) return false;
            for(int i = 0; i < year.Length; i++)
            {
                if (year[i] < '0' || year[i] > '9') return false;
            }
            return true;
        }

        public static bool checkMonth(in string month)
        {
            if (string.IsNullOrEmpty(month)) return false;
            for (int i = 0; i < month.Length; i++)
            {
                if (month[i] < '0' || month[i] > '9') return false;
            }
            if (Convert.ToInt32(month) > 12 || Convert.ToInt32(month) == 0) return false;
            return true;
        }

        public static bool checkDay(in string day, in string month, in string year)
        {
            if (string.IsNullOrEmpty(day)) return false;
            for (int i = 0; i < day.Length; i++)
            {
                if (day[i] < '0' || day[i] > '9') return false;
            }
            if (Convert.ToInt32(day) > 31 || Convert.ToInt32(day) == 0) return false;
            if (Convert.ToInt32(month) == 2 && Convert.ToInt32(day) > 29) return false;
            if (!DateTime.IsLeapYear(Convert.ToInt32(year)) && Convert.ToInt32(month) == 2 && Convert.ToInt32(day) == 29) return false;
            return true;
        }

        public static bool checkCelsius(in string temperature)
        {
            if (string.IsNullOrEmpty(temperature)) return false;
            for(int i = 0; i < temperature.Length; i++)
            {
                if (temperature[i] == '-') continue;
                else if (temperature[0] == ',') return false;
                else if (temperature[i] == ',') continue;
                else if (temperature[i] < '0' || temperature[i] > '9') return false;
            }
            if (Convert.ToDouble(temperature) < -273.15) return false;
            return true;
        }

        public static bool checkKelvin(in string temperature)
        {
            if (string.IsNullOrEmpty(temperature)) return false;
            for (int i = 0; i < temperature.Length; i++)
            {
                if (temperature[i] == '-') continue;
                else if (temperature[0] == ',') return false;
                else if (temperature[i] == ',') continue;
                else if (temperature[i] < '0' || temperature[i] > '9') return false;
            }
            if (Convert.ToDouble(temperature) < 0) return false;
            return true;
        }

        public static bool checkFahrenheit(in string temperature)
        {
            if (string.IsNullOrEmpty(temperature)) return false;
            for (int i = 0; i < temperature.Length; i++)
            {
                if (temperature[i] == '-') continue;
                else if (temperature[0] == ',') return false;
                else if (temperature[i] == ',') continue;
                else if (temperature[i] < '0' || temperature[i] > '9') return false;
            }
            if (Convert.ToDouble(temperature) < -459.67) return false;
            return true;
        }

        public static bool checkTask7(in string range)
        {
            if (string.IsNullOrEmpty(range)) return false;
            for (int i = 0; i < range.Length; i++)
            {
                if (range[i] == '-') continue;
                else if (range[i] < '0' || range[i] > '9') return false;
            }
            try
            {
                int convertedRange = Convert.ToInt32(range);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
