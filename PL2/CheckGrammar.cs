using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL2
{
    class CheckGrammar
    {
        public bool CheckName(string someString)
        {
            bool check = false;
            if (!someString.ToCharArray().All(char.IsDigit))
            {
                check = true;
                return check;
            }
            else
            {
                return check;
            }
        }

        public bool CheckSurrName(string someString)
        {
            bool check = false;
            if (!someString.ToCharArray().All(char.IsDigit))
            {
                check = true;
                return check;
            }
            else
            {
                return check;
            }
        }

       public bool CheckGroup(string someString)
       {
            bool check = false;
            if (!someString.ToCharArray().All(char.IsDigit))
            {
                check = true;
                return check;
            }
            else
            {
                return check;
            }
       }

        public bool CheckDate(int day)
        {
            bool checkDay = false;

            if (day >= 1 && day <= 31)
            {
                checkDay = true;
                return checkDay;
            }
            else
            {
                return checkDay;
            }

        }

        public bool CheckYear(int year)
        {
            bool checkYear = false;

            if (year > 1 && year < 2050)
            {
                checkYear = true;
                return checkYear;
            }
            else
            {
                return checkYear;
            }

        }

        public bool CheckMounth(int mounth)
        {
            bool checkMounth = false;

            if (mounth.ToString().Length >= 1 && mounth.ToString().Length <= 12)
            {
                checkMounth = true;
                return checkMounth;
            }
            else
            {
                return checkMounth;
            }

        }
        public bool CheckNumber(int number)
        {
            bool check = false;
            if (number > 0 )
            {
                check = true;
                return check;
            }
            else
            {
                return check;
            }
        }
        public bool CheckRoom(int room)
        {
            bool check = false;
            if (room > 0)
            {
                check = true;
                return check;
            }
            else
            {
                return check;
            }
        }
    }
}
