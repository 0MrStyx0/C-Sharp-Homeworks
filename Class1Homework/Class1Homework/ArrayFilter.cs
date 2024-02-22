using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1Homework.ArrayFilter
{
    internal class ArrayFilter
    {
        public static void FiltrateArray(int[] originalArr, int[] filterArr)
        {
            Console.Write("Original Array: ");
            for (int i = 0; i < originalArr.Length; i++) 
            {
                Console.Write(originalArr[i] + " ");
            }
            Console.Write("\nFilter Array: ");
            for (int i = 0; i < filterArr.Length; i++)
            {
                Console.Write(filterArr[i] + " ");
            }
            Console.Write("\nResult: ");
            for (int i = 0; i < originalArr.Length; i++) 
            {
                for (int j = 0; j < filterArr.Length; j++) 
                {
                    if (originalArr[i] == filterArr[j])
                    {
                        break;
                    }
                    else if (originalArr[i] != filterArr[j] && j == filterArr.Length - 1) 
                    {
                        Console.Write(originalArr[i] + " ");
                    }
                }
            }
        }
    }
}
