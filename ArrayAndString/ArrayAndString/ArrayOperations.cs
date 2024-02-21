using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayAndString.ArrayOperations
{
    internal class ArrayOperations
    {
        public static void RandomFillArr(int[][] arr, int range1, int range2)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(range1, range2);
                }
            }
        }

        public static void WriteArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"num {i + 1} --> ");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ERROR! DESCRIPTION: No letters or empty value! Only numbers in INT format!");
                    }
                }
            }
        }

        public static void ShowSimpleArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void ShowMDArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] >= 0) Console.Write(" " + arr[i][j] + " ");
                    else if (arr[i][j] < 0) Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine("\n");
            }
        }

        public static void CommonMax(int[] arr1, int[][] arr2)
        {
            
            int max1 = arr1.Max();
            int max2 = arr2[0][0];
            for (int i = 0; i < arr2.Length; i++) 
            {
                for(int j = 0; j < arr2[i].Length; j++)
                {
                    if (arr2[i][j] > max2) max2 = arr2[i][j];
                }
            }
            if (max1 == max2) Console.WriteLine("Common max: " + max2);
            else Console.WriteLine("Common max: ---");
        }

        public static void CommonMin(int[] arr1, int[][] arr2)
        {

            int min1 = arr1.Min();
            int min2 = arr2[0][0];
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    if (arr2[i][j] < min2) min2 = arr2[i][j];
                }
            }
            if (min1 == min2) Console.WriteLine("Common min: " + min2);
            else Console.WriteLine("Common min: ---");
        }

        public static void CommonSum(int[] arr1, int[][] arr2)
        {
            int sum1 = arr1.Sum();
            int sum2 = 0;
            int totalSum;
            for(int i = 0;i < arr2.Length; i++)
            {
                for(int j = 0; j < arr2[i].Length; j++)
                {
                    sum2 += arr2[i][j];
                }
            }
            totalSum = sum1 + sum2;
            Console.WriteLine("Common sum of 2 arrays: " + totalSum);
        }

        public static void CommonMultiplication(int[] arr1, int[][] arr2)
        {
            int multiplication1 = 1;
            int multiplication2 = 1;
            int totalMultiplication;
            for(int i = 0; i < arr1.Length; i++)
            {
                multiplication1 *= arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    multiplication2 *= arr2[i][j];
                }
            }
            totalMultiplication = multiplication1 * multiplication2;
            Console.WriteLine("Common multiplication of 2 arrays: " + totalMultiplication);
        }

        public static void EvenElSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] % 2 == 0) sum += arr[i];
            }
            Console.WriteLine(sum);
        }

        public static void OddColumnsSum(int[][] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    if ((j + 1) % 2 != 0) sum += arr[i][j];
                }
            }
            Console.WriteLine(sum);
        }

        public static void SumBetweenMinMax(int[][] arr)
        {
            int max = arr[0][0];
            int min = arr[0][0];
            int MaxIndexI = 0;
            int MaxIndexJ = 0;
            int MinIndexI = 0;
            int MinIndexJ = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                for (int j = 0; j < arr[i].Length; j++) 
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                        MaxIndexI = i;
                        MaxIndexJ = j;
                    }
                    if (arr[i][j] < min)
                    {
                        min= arr[i][j];
                        MinIndexI = i;
                        MinIndexJ = j;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (i >= MinIndexI && i <= MaxIndexI)
                    {
                        if (j > MinIndexJ && i == MinIndexI) sum += arr[i][j];
                        else if (i > MinIndexI && i <= MaxIndexI && (i == MaxIndexI && j == MaxIndexJ))
                        {
                            break;
                        }
                        else if (i > MinIndexI && i <= MaxIndexI) sum += arr[i][j];
                    }
                    else if(i <= MinIndexI && i >= MaxIndexI)
                    {
                        if (j > MaxIndexJ && i == MaxIndexI) sum += arr[i][j];
                        else if (i > MaxIndexI && i <= MinIndexI && (i == MinIndexI && j == MinIndexJ))
                        {
                            break;
                        }
                        else if (i > MaxIndexI && i <= MinIndexI) sum += arr[i][j];
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
        }

        public static void MatrixOnNumber(int[][] matrix,int number)
        {
            for (int i = 0; i < matrix.Length; i++) 
            {
                for (int j = 0; j < matrix[i].Length; j++) 
                {
                    matrix[i][j] *= number;
                }
            }
        }

        public static void MatrixSum(int[][] matrix1, int[][] matrix2)
        {
            int[][] matrixSum = new int[3][];
            for (int i = 0; i < matrixSum.Length; i++) 
            {
                matrixSum[i] = new int[3];
            }
            for (int i = 0; i < matrix1.Length; i++)
            {
                for (int j = 0; j < matrix1[i].Length; j++)
                {
                    matrixSum[i][j] = matrix1[i][j] + matrix2[i][j];
                }
            }

            Console.WriteLine("Sum:");
            ShowMDArray(matrixSum);
        }
    }
}
