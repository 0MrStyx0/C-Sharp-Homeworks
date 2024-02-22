using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1Homework.Palindrome
{
    internal class Palindrome
    {
        public static bool IsPalindrome(int number)
        {
            string num = number.ToString();
            for (int i = 0; i < num.Length / 2; i++) 
            {
                if (num[i] != num[num.Length - 1 - i]) 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
