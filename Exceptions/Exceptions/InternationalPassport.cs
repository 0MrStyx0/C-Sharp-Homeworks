using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Class.InternationalPassport
{
    internal class InternationalPassport
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") throw new Exception("ERROR! DESCRIPTION: Empty value!");
                if (value.Length > 15) throw new Exception("ERROR! DESCRIPTION: name is too long.");
                if (value.Length < 2) throw new Exception("ERROR! DESCRIPTION: name is too short.");
                for (int i = 0; i < value.Length; i++)
                {
                    if ((value[i] < 'A' || value[i] > 'Z') && (value[i] < 'a' || value[i] > 'z')) throw new Exception("ERROR! DESCRIPTION: Incorrect spelling, only letters!");
                    else if (value[0] > 'Z') throw new Exception("ERROR! DESCRIPTION: Incorrect spelling, first letter must be uppercase!");
                    else if (i > 0 && (value[i] >= 'A' && value[i] <= 'Z')) throw new Exception("ERROR! DESCRIPTION: Incorrect spelling, all letters except the first must be lowercase!");
                }
                name = value;
            }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value == "") throw new Exception("ERROR! DESCRIPTION: Empty value!");
                if (value.Length > 15) throw new Exception("ERROR! DESCRIPTION: surname is too long.");
                if (value.Length < 2) throw new Exception("ERROR! DESCRIPTION: surname is too short.");
                for (int i = 0; i < value.Length; i++)
                {
                    if ((value[i] < 'A' || value[i] > 'Z') && (value[i] < 'a' || value[i] > 'z')) throw new Exception("ERROR! DESCRIPTION: Incorrect spelling, only letters!");
                    else if (value[0] > 'Z') throw new Exception("ERROR! DESCRIPTION: Incorrect spelling, first letter must be uppercase!");
                    else if (i > 0 && (value[i] >= 'A' && value[i] <= 'Z')) throw new Exception("ERROR! DESCRIPTION: Incorrect spelling, all letters except the first must be lowercase!");
                }
                surname = value;
            }
        }

        private string patronymic;
        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                if (value == "") throw new Exception("ERROR! DESCRIPTION: Empty value!");
                if (value.Length > 15) throw new Exception("ERROR! DESCRIPTION: patronymic is too long.");
                if (value.Length < 2) throw new Exception("ERROR! DESCRIPTION: patronymic is too short.");
                for (int i = 0; i < value.Length; i++)
                {
                    if ((value[i] < 'A' || value[i] > 'Z') && (value[i] < 'a' || value[i] > 'z')) throw new Exception("ERROR! DESCRIPTION: Incorrect spelling, only letters!");
                    else if (value[0] > 'Z') throw new Exception("ERROR! DESCRIPTION: Incorrect spelling, first letter must be uppercase!");
                    else if (i > 0 && (value[i] >= 'A' && value[i] <= 'Z')) throw new Exception("ERROR! DESCRIPTION: Incorrect spelling, all letters except the first must be lowercase!");
                }
                patronymic = value;
            }
        }

        private string number;
        public string Number
        {
            get { return number; }
            set
            {
                if (value.Length < 7) throw new Exception("ERROR! DESCRIPTION: number is too short.");
                else if (value.Length > 7) throw new Exception("ERROR! DESCRIPTION: number is too long.");
                for (int i = 0; i < value.Length; i++) 
                {
                    if (i > 1 && (value[i] < '0' || value[i] > '9')) throw new Exception("ERROR! DESCRIPTION: wrong number! EXAMPLE: AA12345");
                    else if (i < 2 && (value[i] < 'A' || value[i] > 'Z')) throw new Exception("ERROR! DESCRIPTION: wrong number! EXAMPLE: AA12345");
                }
                number = value;
            }
        }
        private DateTime issueDate;
        public DateTime IssueDate
        {
            get { return issueDate; }
            set
            {
                if (value > DateTime.Now) throw new Exception("ERROR! DESCRIPTION: date is ahead of current date!");
                if (value.Year < 1991) throw new Exception("ERROR! DESCRIPTION: less than 1991");
                issueDate = value;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Patronymic: " + patronymic);
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Issue Date: " + IssueDate.ToShortDateString());
        }
    }
}
