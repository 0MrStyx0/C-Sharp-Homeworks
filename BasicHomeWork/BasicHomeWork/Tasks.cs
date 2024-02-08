using BasicHomeWork.Checker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicHomeWork.Tasks
{
    internal class Tasks
    {
        public static void Task1()
        {
            while (true)
            {
                Console.Write("Enter numbers ranging from 1 to 100(or q to exit)\n--> ");
                var num = Console.ReadLine();
                if (num == "q") 
                {
                    Console.Clear();
                    break;
                }

                if (!Checker.Checker.checkTask1(num))
                {
                    Checker.Checker.PrintError();
                }
                else
                {
                    int Cnum = Convert.ToInt32(num);
                    if (Cnum % 3 == 0 && Cnum % 5 == 0) Console.WriteLine("Fizz Buzz");
                    else if (Cnum % 3 != 0 && Cnum % 5 != 0) Console.WriteLine(Cnum);
                    else if (Cnum % 3 == 0) Console.WriteLine("Fizz");
                    else if (Cnum % 5 == 0) Console.WriteLine("Buzz");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }

        public static void Task2()
        {
            while (true)
            {
                string num;
                string percent;
                while (true) 
                {
                    Console.Write("Number (or q to exit) --> ");
                    num = Console.ReadLine();
                    if (num == "q")
                    {
                        Console.Clear();
                        return;
                    }
                    if (!Checker.Checker.checkNumberTask2(num))
                    {
                        Checker.Checker.PrintError();
                    }
                    else break;
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Number --> " + num);
                    Console.Write("Percent (or q to exit) --> ");
                    percent = Console.ReadLine();
                    if (percent == "q")
                    {
                        Console.Clear();
                        break;
                    }
                    if (!Checker.Checker.checkMenuOrPercent(percent))
                    {
                        Checker.Checker.PrintError();
                    }
                    else
                    {
                        float resutlt = ((float)Convert.ToInt32(num) * Convert.ToInt32(percent)/100);
                        Console.WriteLine("Result: " + resutlt);
                        Thread.Sleep(1000);
                        break;
                    }
                }
            }
        }

        public static void Task3()
        {
            while (true) 
            {
                string num1;
                string num2;
                string num3;
                string num4;
                while (true)
                {
                    Console.Write("Number 1 (or q to exit) --> ");
                    num1 = Console.ReadLine();
                    if(num1 == "q")
                    {
                        Console.Clear();
                        return;
                    }

                    if (!Checker.Checker.checkTask3(num1))
                    {
                        Checker.Checker.PrintError();
                    }
                    else break;
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Number 1 --> " + num1);
                    Console.Write("Number 2 (or q to exit) -->  ");
                    num2 = Console.ReadLine();
                    if (num2 == "q")
                    {
                        Console.Clear();
                        break;
                    }

                    if (!Checker.Checker.checkTask3(num2))
                    {
                        Checker.Checker.PrintError();
                    }
                    else break;
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Number 1 --> " + num1);
                    Console.WriteLine("Number 2 --> " + num2);
                    Console.Write("Number 3 (or q to exit) -->  ");
                    num3 = Console.ReadLine();
                    if (num3 == "q")
                    {
                        Console.Clear();
                        break;
                    }

                    if (!Checker.Checker.checkTask3(num3))
                    {
                        Checker.Checker.PrintError();
                    }
                    else break;
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Number 1 --> " + num1);
                    Console.WriteLine("Number 2 --> " + num2);
                    Console.WriteLine("Number 3 --> " + num3);
                    Console.Write("Number 4 (or q to exit) -->  ");
                    num4 = Console.ReadLine();
                    if (num4 == "q")
                    {
                        Console.Clear();
                        break;
                    }

                    if (!Checker.Checker.checkTask3(num4))
                    {
                        Checker.Checker.PrintError();
                    }
                    else
                    {
                        string result = num1 + num2 + num3 + num4;
                        Console.WriteLine("Number: " + Convert.ToInt32(result));
                        Thread.Sleep(1000);
                        break;
                    }
                }
            }
        }

        public static void Task4()
        {
            while (true)
            {
                string num;
                string index1;
                string index2;
                while (true)
                {
                    Console.Write("Enter the six-digit number (or q to exit)\n--> ");
                    num = Console.ReadLine();
                    if (num == "q")
                    {
                        Console.Clear();
                        return;
                    }
                    if (!Checker.Checker.checkTask4(num))
                    {
                        Checker.Checker.PrintError();
                    }
                    else break;
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Now,swap the numbers");
                    Console.WriteLine("Number: " + num);
                    Console.Write("Index 1 (or q to exit) --> ");
                    index1 = Console.ReadLine();
                    if (index1 == "q") 
                    {
                        Console.Clear();
                        break;
                    }
                    if (!Checker.Checker.checkIndexTask4(index1)) 
                    {
                        Checker.Checker.PrintError();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Now,swap the numbers");
                            Console.WriteLine("Number: " + num);
                            Console.WriteLine("Index 1 --> " + index1);
                            Console.Write("Index 2 (or q to exit) --> ");
                            index2 = Console.ReadLine();
                            if (index2 == "q")
                            {
                                Console.Clear();
                                break;
                            }
                            if (!Checker.Checker.checkIndexTask4(index2))
                            {
                                Checker.Checker.PrintError();
                            }
                            else
                            {
                                char[] arrNum = num.ToCharArray();
                                for(int i = 0; i < arrNum.Length; i++)
                                {
                                    if (i == Convert.ToInt32(index1) - 1)
                                    {
                                        for (int j = 0; j < arrNum.Length; j++) 
                                        {
                                            if (j == Convert.ToInt32(index2) - 1) 
                                            {
                                                arrNum[i] = num[j];
                                                arrNum[j] = num[i];
                                                num = new string(arrNum);
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void Task5()
        {
            string day;
            string month;
            string year;
            while (true)
            {
                while (true)
                {
                    Console.Write("Year (or q to exit) --> ");
                    year = Console.ReadLine();
                    if (year == "q")
                    {
                        Console.Clear();
                        return;
                    }
                    if (!Checker.Checker.checkYear(year))
                    {
                        Checker.Checker.PrintError();
                    }
                    else break;
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Year --> " + year);
                    Console.Write("Month (or q to exit) --> ");
                    month = Console.ReadLine();
                    if(month == "q")
                    {
                        Console.Clear();
                        break;
                    }
                    if (!Checker.Checker.checkMonth(month))
                    {
                        Checker.Checker.PrintError();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Year --> " + year);
                            Console.WriteLine("Month --> " + month);
                            Console.Write("Day (or q to exit) --> ");
                            day = Console.ReadLine();
                            if (day == "q")
                            {
                                Console.Clear();
                                break;
                            }
                            if (!Checker.Checker.checkDay(day, month, year))
                            {
                                Checker.Checker.PrintError();
                            }
                            else
                            {
                                DateTime date = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
                                if (Convert.ToInt32(month) == 12 || Convert.ToInt32(month) >= 1 && Convert.ToInt32(month) < 3)
                                {
                                    Console.Write("Winter ");
                                }
                                else if (Convert.ToInt32(month) >= 3 && Convert.ToInt32(month) < 6) 
                                {
                                    Console.Write("Spring ");
                                }
                                else if (Convert.ToInt32(month) >= 6 && Convert.ToInt32(month) < 9)
                                {
                                    Console.Write("Summer ");
                                }
                                else if (Convert.ToInt32(month) >= 9 && Convert.ToInt32(month) < 12)
                                {
                                    Console.Write("Autumn ");
                                }
                                Console.WriteLine(date.DayOfWeek);
                                Thread.Sleep(1000);
                            }
                        }
                    }
                }
            }
        }

        public static void Task6()
        {
            while (true)
            {
                string choice;
                Console.Write("1.Celsius\n2.Kelvin\n3.Fahrenheit\n4.Exit\n--> ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    while (true)
                    {
                        string Celsius;
                        Console.Write("Celsius (or q to exit) --> ");
                        Celsius = Console.ReadLine();
                        if (Celsius == "q")
                        {
                            Console.Clear();
                            break;
                        }
                        if (!Checker.Checker.checkCelsius(Celsius))
                        {
                            Checker.Checker.PrintError();
                        }
                        else
                        {
                            double Kelvin = Convert.ToDouble(Celsius) + 273.15;
                            double Fahrenheit = (Convert.ToDouble(Celsius) * (9.0 / 5.0)) + 32;
                            Console.WriteLine("Results:");
                            Console.WriteLine(Convert.ToDouble(Celsius) + " C");
                            Console.WriteLine(Kelvin + " K");
                            Console.WriteLine(Fahrenheit + " F");
                        }
                    }
                }
                else if(choice == "2")
                {
                    while (true)
                    {
                        string Kelvin;
                        Console.Write("Kelvin (or q to exit) --> ");
                        Kelvin = Console.ReadLine();
                        if (Kelvin == "q")
                        {
                            Console.Clear();
                            break;
                        }
                        if (!Checker.Checker.checkKelvin(Kelvin))
                        {
                            Checker.Checker.PrintError();
                        }
                        else
                        {
                            double Celsius = Convert.ToDouble(Kelvin) - 273.15;
                            double Fahrenheit = (Convert.ToDouble(Kelvin) - 273.15) * (9.0 / 5.0) + 32;
                            Console.WriteLine("Results:");
                            Console.WriteLine(Celsius + " C");
                            Console.WriteLine(Convert.ToDouble(Kelvin) + " K");
                            Console.WriteLine(Fahrenheit + " F");
                        }
                    }
                }
                else if( choice == "3")
                {
                    while (true)
                    {
                        string Fahrenheit;
                        Console.Write("Fahrenheit (or q to exit) --> ");
                        Fahrenheit = Console.ReadLine();
                        if (Fahrenheit == "q")
                        {
                            Console.Clear();
                            break;
                        }
                        if (!Checker.Checker.checkFahrenheit(Fahrenheit))
                        {
                            Checker.Checker.PrintError();
                        }
                        else
                        {
                            double Celsius = (Convert.ToDouble(Fahrenheit) - 32) * (5.0 / 9.0);
                            double Kelvin = (Convert.ToDouble(Fahrenheit) - 32) * (5.0 / 9.0) + 273.15;
                            Console.WriteLine("Results:");
                            Console.WriteLine(Celsius + " C");
                            Console.WriteLine(Kelvin + " K");
                            Console.WriteLine(Convert.ToDouble(Fahrenheit) + " F");
                        }
                    }
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Checker.Checker.PrintError();
                }
            }
        }
        public static void Task7()
        {
            string range1;
            string range2;
            while (true)
            {
                Console.Write("Range 1 (or q to exit) --> ");
                range1 = Console.ReadLine();
                if(range1 == "q")
                {
                    Console.Clear();
                    break;
                }
                if (!Checker.Checker.checkTask7(range1))
                {
                    Checker.Checker.PrintError();
                }
                else
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Range 1 --> " + range1);
                        Console.Write("Range 2 (or q to exit) --> ");
                        range2 = Console.ReadLine();
                        if (range2 == "q")
                        {
                            Console.Clear();
                            break;
                        }
                        if (!Checker.Checker.checkTask7(range2))
                        {
                            Checker.Checker.PrintError();
                        }
                        else
                        {
                            Console.WriteLine("Even Numbers:");
                            int Crange1 = Convert.ToInt32(range1);
                            int Crange2 = Convert.ToInt32(range2);
                            if(Crange1 < Crange2)
                            {
                                while(Crange1 < Crange2)
                                {
                                    if (Crange1 % 2 == 0) 
                                    {
                                        Console.WriteLine(Crange1);
                                    }
                                    Crange1++;
                                }
                            }
                            else if(Crange1 > Crange2)
                            {
                                while (Crange2 < Crange1)
                                {
                                    if (Crange2 % 2 == 0)
                                    {
                                        Console.WriteLine(Crange2);
                                    }
                                    Crange2++;
                                }
                            }
                            Console.WriteLine("Press any key to escape");
                            var skip = Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    }
                }
            }
        }
    }
}