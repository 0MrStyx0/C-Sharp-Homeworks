using ArrayAndString.ArrayOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndString.Tasks
{
    internal class Tasks
    {
        public static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Task 1");
            int[] arrA = new int[5];
            int[][] arrB = new int[3][];
            for (int i = 0; i < arrB.Length; i++)
            {
                arrB[i] = new int[4];
            }
            Console.WriteLine("Array A: ");
            ArrayOperations.ArrayOperations.WriteArr(arrA);
            Console.Clear();

            Console.Write("Array A: ");
            ArrayOperations.ArrayOperations.ShowSimpleArray(arrA);

            Console.WriteLine("\nArray B: ");
            ArrayOperations.ArrayOperations.RandomFillArr(arrB, -20, 20);
            ArrayOperations.ArrayOperations.ShowMDArray(arrB);

            ArrayOperations.ArrayOperations.CommonMax(arrA, arrB);
            ArrayOperations.ArrayOperations.CommonMin(arrA, arrB);
            ArrayOperations.ArrayOperations.CommonSum(arrA, arrB);
            ArrayOperations.ArrayOperations.CommonMultiplication(arrA, arrB);
            Console.Write("Even sum of array A: ");
            ArrayOperations.ArrayOperations.EvenElSum(arrA);
            Console.Write("Odd Columns sum of array B: ");
            ArrayOperations.ArrayOperations.OddColumnsSum(arrB);
        }

        public static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Task 2");
            int[][] arr = new int[5][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[5];
            }
            Console.WriteLine("Array : ");
            ArrayOperations.ArrayOperations.RandomFillArr(arr, -100, 100);
            ArrayOperations.ArrayOperations.ShowMDArray(arr);
            Console.Write("Sum between min and max: ");
            ArrayOperations.ArrayOperations.SumBetweenMinMax(arr);
        }

        public static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Task 3");
            Console.Write("Text --> ");
            string text = Console.ReadLine();
            char symbol;
            string encryptedText = "";
            string decryptedText = "";
            for(int i = 0; i < text.Length; i++)
            {
                symbol = (char)(text[i] + 5);
                encryptedText += symbol;
            }
            for (int i = 0; i < text.Length; i++)
            {
                symbol = (char)(encryptedText[i] - 5);
                decryptedText += symbol;
            }
            Console.WriteLine("Encrypted text: " + encryptedText);
            Console.WriteLine("Decrypted Text: " + decryptedText);
        }

        public static void Task4()
        {
            Console.Clear();
            Console.WriteLine("Task 4");
            int[][] matrix1 = new int[3][];
            int[][] matrix2 = new int[3][];
            for (int i = 0; i < 3; i++) 
            {
                matrix1[i] = new int[3];
                matrix2[i] = new int[3];
            }

            ArrayOperations.ArrayOperations.RandomFillArr(matrix1, 1, 20);
            ArrayOperations.ArrayOperations.RandomFillArr(matrix2, 1, 20);
            Console.WriteLine("Matrix 1:");
            ArrayOperations.ArrayOperations.ShowMDArray(matrix1);
            Console.WriteLine("Matrix 2:");
            ArrayOperations.ArrayOperations.ShowMDArray(matrix2);

            ArrayOperations.ArrayOperations.MatrixSum(matrix1, matrix2);
            

            Console.WriteLine("Matrix 1 multiple:");
            ArrayOperations.ArrayOperations.MatrixOnNumber(matrix1, 2);
            ArrayOperations.ArrayOperations.ShowMDArray(matrix1);
        }

        public static void Task5()
        {
            Console.Clear();
            Console.WriteLine("Task 5");
            while (true)
            {
                try
                {
                    Console.Write("Math expression (q to exit)--> ");
                    string expression = Console.ReadLine();

                    if (string.IsNullOrEmpty(expression)) throw new Exception("ERROR! DESCRIPTION: Empty value!");
                    if (expression == "q")
                    {
                        Console.Clear();
                        break;
                    }

                    for (int i = 0; i < expression.Length; i++)
                    {
                        if ((expression[i] == '+' || expression[i] == '-') && i == expression.Length - 1) throw new Exception("ERROR! DESCRIPTION: incorect expression!");
                        if (expression[i] == '+' || expression[i] == '-') continue;
                        if (expression[i] < '0' || expression[i] > '9') throw new Exception("ERROR! DESCRIPTION: only int numbers!");
                    }
                    int result = 0;
                    char operation = '+';

                    for (int i = 0; i < expression.Length; i++)
                    {
                        if (expression[i] == '+')
                        {
                            operation = '+';
                        }
                        else if (expression[i] == '-')
                        {
                            operation = '-';
                        }
                        else
                        {
                            int number = 0;
                            while (i < expression.Length && Char.IsDigit(expression[i]))
                            {
                                number = number * 10 + (expression[i] - '0');
                                i++;
                            }

                            if (operation == '+')
                            {
                                result += number;
                            }
                            else if (operation == '-')
                            {
                                result -= number;
                            }
                            i--;
                        }
                    }
                    Console.WriteLine("Result = " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }

        public static void Task6()
        {
            Console.Clear();
            Console.WriteLine("Task 6");
            while (true)
            {
                try
                {                   
                    Console.Write("Enter the text (q to exit) --> ");
                    string text = Console.ReadLine();
                    StringBuilder textSB = new StringBuilder();
                    textSB.Append(text);
                    if (text == "q")
                    {
                        Console.Clear();
                        break;
                    }
                    if (string.IsNullOrEmpty(text)) throw new Exception("ERROR! DESCRIPTION: Empty value!");

                    for(int i = 0; i < text.Length; i++)
                    {
                        if (i == 0 && text[i] > 'a' && text[i] < 'z')
                        {
                            textSB[i] = (char)(text[i] - 32);
                        }
                        else if ((text[i] == '.' || text[i] == '!' || text[i] == '?') && i == text.Length - 1)
                        {
                            break;
                        }
                        else if ((text[i] == '.' || text[i] == '!' || text[i] == '?') && (text[i + 1] == ' ' && text[i + 2] > 'a' && text[i + 2] < 'z'))
                        {
                            textSB[i + 2] = (char)(text[i + 2] - 32);
                        }
                    }
                    var newText = textSB.ToString();
                    Console.WriteLine(newText);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }

        public static void Task7()
        {
            Console.Clear();
            Console.WriteLine("Task 7");

            while (true)
            {
                try
                {
                    Console.Write("Enter the text (q to exit) --> ");
                    string text = Console.ReadLine();
                    if (text == "q")
                    {
                        Console.Clear();
                        break;
                    }
                    if (string.IsNullOrEmpty(text)) throw new Exception("ERROR! DESCRIPTION: Empty value!");

                    Console.Write("Enter the censor --> ");
                    string censor = Console.ReadLine();

                    string censoredText = text.Replace(censor, "***");

                    Console.WriteLine("Original text: " + text);
                    Console.WriteLine("Censored text: " + censoredText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
}