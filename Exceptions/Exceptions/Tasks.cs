using Exceptions.Class.Comparison;
using Exceptions.Class.InternationalPassport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Tasks
{
    internal class Tasks
    {
        public static void Task1() 
        {
            Console.Clear();
            while (true)
            {
                try
                {  
                    Console.Write("Enter the number (or q to exit) --> ");
                    string number = Console.ReadLine();
                    if(number == "q")
                    {
                        Console.Clear();
                        break;
                    }
                    Console.Write("Number notation (2,8,10,16) --> ");
                    int baseNotation = Convert.ToInt32(Console.ReadLine());
                    Console.Write("To (2,8,10,16) --> ");
                    int finalNotation = Convert.ToInt32(Console.ReadLine());
                    NotationConverter.NotationConverter.ConvertNumber(number, baseNotation, finalNotation);
                }
                catch(FormatException)
                {
                    Console.WriteLine("ERROR! DESCRIPTION: Wrong convertation");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("ERROR! DESCRIPTION: Only 2 8 10 and 16 notation!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
        public static void Task2() 
        {
            Console.Clear();
            while (true)
            {
                Console.Write("Write the number in words (or q to exit)\n--> ");
                string wordNumber = Console.ReadLine();
                if(wordNumber == "q")
                {
                    Console.Clear();
                    break;
                }
                switch(wordNumber)
                {
                    case "zero":
                    case "Zero":
                        Console.WriteLine("Result: " + 0);
                        break;

                    case "one":
                    case "One":
                        Console.WriteLine("Result: " + 1);
                        break;

                    case "two":
                    case "Two":
                        Console.WriteLine("Result: " + 2);
                        break;

                    case "three":
                    case "Three":
                        Console.WriteLine("Result: " + 3);
                        break;

                    case "four":
                    case "Four":
                        Console.WriteLine("Result: " + 4);
                        break;

                    case "five":
                    case "Five":
                        Console.WriteLine("Result: " + 5);
                        break;

                    case "six":
                    case "Six":
                        Console.WriteLine("Result: " + 6);
                        break;

                    case "seven":
                    case "Seven":
                        Console.WriteLine("Result: " + 7);
                        break;

                    case "eight":
                    case "Eight":
                        Console.WriteLine("Result: " + 8);
                        break;

                    case "nine":
                    case "Nine":
                        Console.WriteLine("Result: " + 9);
                        break;

                    default:
                        Console.WriteLine("ERROR! DESCRIPTION: Wrong Value");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            }
        }
        public static void Task3()
        {
            Console.Clear();
            while (true)
            {
                InternationalPassport passport = new InternationalPassport();
                while (true)
                {
                    try
                    {
                        Console.Write("Name (q to exit) --> ");
                        string name = Console.ReadLine();
                        if (name == "q")
                        {
                            Console.Clear();
                            return;
                        }
                        passport.Name = name;
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Name --> " + passport.Name);
                        Console.Write("Surname (q to exit) --> ");
                        string surname = Console.ReadLine();
                        if (surname == "q")
                        {
                            Console.Clear();
                            return;
                        }
                        passport.Surname = surname;
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Name --> " + passport.Name);
                        Console.WriteLine("Surname --> " + passport.Surname);
                        Console.Write("Patronymic (q to exit) --> ");
                        string patronymic = Console.ReadLine();
                        if (patronymic == "q")
                        {
                            Console.Clear();
                            return;
                        }
                        passport.Patronymic = patronymic;
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Name --> " + passport.Name);
                        Console.WriteLine("Surname --> " + passport.Surname);
                        Console.WriteLine("Patronymic --> " + passport.Patronymic);
                        Console.Write("Passport number (q to exit) --> ");
                        string number = Console.ReadLine();
                        if (number == "q")
                        {
                            Console.Clear();
                            return;
                        }
                        passport.Number = number;
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }

                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Name --> " + passport.Name);
                        Console.WriteLine("Surname --> " + passport.Surname);
                        Console.WriteLine("Patronymic --> " + passport.Patronymic);
                        Console.WriteLine("Passport number --> " + passport.Number);
                        Console.Write("Issue date (q to exit) --> ");
                        string issueDate = Console.ReadLine();
                        if (issueDate == "q")
                        {
                            Console.Clear();
                            return;
                        }
                        passport.IssueDate = DateTime.Parse(issueDate);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ERROR! DESCRIPTION: Wrong Data! Example: 01.01.2002");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
                passport.ShowInfo();
            }
        }
        public static void Task4()
        {
            Console.Clear();
            while (true)
            {
                try
                {
                    Console.Write("Enter comparison (q to exit)\n--> ");
                    string comparison = Console.ReadLine();
                    if(comparison=="q")
                    {
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine(Comparison.CompareInString(comparison));                   
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR! DESCRIPTION: Wrong comparison! Example: 1 < 2");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("ERROR! DESCRIPTION: number is too large for int!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("ERROR! DESCRIPTION: Wrong comparison! Example: 1 < 2");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
}
