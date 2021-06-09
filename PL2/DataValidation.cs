using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL2
{
    class DataValidation
    {
        CheckGrammar Checks = new CheckGrammar();
        public string AddName(string firstName)
        {
            string tmpFirstName = "";

            if (Checks.CheckName(firstName))
            {
                Console.Clear();
                tmpFirstName = firstName;
                return tmpFirstName;
            }
            else
            {
                Console.WriteLine("Невірний формат ім'я. Введіть ім'я знову");
                tmpFirstName = Console.ReadLine();
                return AddName(tmpFirstName);// or retutn AddName() ?
            }
        }

        public string AddSurname(string surrName)
        {
            string tmpSurrName = "";

            if (Checks.CheckSurrName(surrName))
            {
                Console.Clear();
                tmpSurrName = surrName;
                return tmpSurrName;
            }
            else
            {
                Console.WriteLine("Невірний формат прізвища. Введіть прізвище знову");
                tmpSurrName = Console.ReadLine();
                return AddSurname(tmpSurrName);// or retutn AddSurName() ?
            }
        }

        public int AddDay(int day)
        {
            int tmpDay;
            if (Checks.CheckDate(day))
            {
                tmpDay = day;
                return tmpDay;
            }
            else
            {
                Console.WriteLine("Невірний формат дня. Введіть день знову");
                tmpDay = int.Parse(Console.ReadLine());
                return AddDay(tmpDay);
            }
        }

        public int AddYear(int year)
        {
            int tmpYear;
            if (Checks.CheckYear(year))
            {
                tmpYear = year;
                return tmpYear;
            }
            else
            {
                Console.WriteLine("Невірний формат. Введіть день знову");
                tmpYear = int.Parse(Console.ReadLine());
                return AddDay(tmpYear);
            }
        }
        public int AddMounth(int mounth)
        {
            int tmpMounth;
            if (Checks.CheckMounth(mounth))
            {
                tmpMounth = mounth;
                return tmpMounth;
            }
            else
            {
                Console.WriteLine("Невірний формат дня. Введіть день знову");
                tmpMounth = int.Parse(Console.ReadLine());
                return AddDay(tmpMounth);
            }
        }
        public string AddGroup(string name)
        {
            string tmpName = "";

            if (Checks.CheckName(name))
            {
                Console.Clear();
                tmpName = name;
                return name;
            }
            else
            {
                Console.WriteLine("Невірний формат ім'я. Введіть ім'я знову");
                tmpName = Console.ReadLine();
                return AddName(tmpName);// or retutn AddName() ?
            }
        }
        public int AddtoHostel(int number)
        {
            int tmpNumber;

            if (Checks.CheckNumber(number))
            {
                Console.Clear();
                tmpNumber = number;
                return number;
            }
            else
            {
                Console.WriteLine("Невірний формат номеру. Введіть номер знову");
                tmpNumber = int.Parse(Console.ReadLine());
                return AddtoHostel(tmpNumber);// or retutn AddName() ?
            }
        }
        public int AddtoRoom(int room)
        {
            int tmpNumber;

            if (Checks.CheckNumber(room))
            {
                Console.Clear();
                tmpNumber = room;
                return room;
            }
            else
            {
                Console.WriteLine("Невірний формат номеру. Введіть номер знову");
                tmpNumber = int.Parse(Console.ReadLine());
                return AddtoHostel(tmpNumber);// or retutn AddName() ?
            }
        }
    }
}
