using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Class.Comparison
{
    internal class Comparison
    {
        public static bool CompareInString(string comparison)
        {
            if (string.IsNullOrEmpty(comparison)) throw new Exception("ERROR! DESCRIPTION: empty value!");
            string number1 = "";
            string number2 = "";
            string simile = "";

            for(int i = 0; i < comparison.Length; i++)
            {
                if (comparison[i] == '>' || comparison[i] == '<' || comparison[i] == '=' || comparison[i] == '!')
                {
                    number1 = comparison.Substring(0, i);
                    if (comparison[i + 1] == '=')
                    {
                        simile = comparison.Substring(i, 2);
                        number2 = comparison.Substring(i + 2);
                        break;
                    }
                    else
                    {
                        simile += comparison[i];
                        number2 = comparison.Substring(i + 1);
                        break;
                    }
                }
            }

            int num1 = Convert.ToInt32(number1);
            int num2 = Convert.ToInt32(number2);

            if (simile == ">") return num1 > num2;
            else if (simile == "<") return num1 < num2;
            else if (simile == "==") return num1 == num2;
            else if (simile == "!=") return num1 != num2;
            else if (simile == ">=") return num1 >= num2;
            else if (simile == "<=") return num1 <= num2;
            else throw new Exception("ERROR! DESCRIPTION: Wrong simile!");
        }
    }
}