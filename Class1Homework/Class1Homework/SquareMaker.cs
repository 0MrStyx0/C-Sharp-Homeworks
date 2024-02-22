using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1Homework.SquareMaker
{
    internal class SquareMaker
    {
        public static void PrintFullSquare(int length,char symbol)
        {
            for(int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++) 
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintHollowSquare(int length, char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || i == length - 1)
                    {
                        Console.Write(symbol + " ");
                    }
                    else if (j == 0 || j == length - 1) 
                    {
                        Console.Write(symbol + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
