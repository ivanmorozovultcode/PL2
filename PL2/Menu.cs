using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
namespace PL2
{
    class Menu
    {
        DataValidation validator = new DataValidation();
        public void OpenMenu()
        {
            Console.WriteLine("1. Щоб додати студента - натисніть: \"1\".");
            Console.WriteLine("2. Щоб додати группу  - натисніть: \"2\".");
            Console.WriteLine("3. Щоб змінити дані про студента - натисніть: \"3\".");
            Console.WriteLine("4. Вивід даних про студента  - натисніть: \"4\".");
            Console.WriteLine("5. Вивід усіх студентів  - натисніть: \"5\".");
            Console.WriteLine("6. Щоб змінити дані про групу  - натисніть: \"6\".");
            Console.WriteLine("7. Вивід даних про групу  - натисніть: \"7\".");
            Console.WriteLine("8. Вивід усіх груп  - натисніть: \"8\".");
            Console.WriteLine("9. Видалення студента   - натисніть: \"9\".");
            Console.WriteLine("10. Видалення студента з группи  - натисніть: \"10\".");
            Console.WriteLine("11. Видалення групи  - натисніть: \"11\".");
            Console.WriteLine("12. Додати гуртожиток  - натисніть: \"12\".");
            Console.WriteLine("13. Змінити дані про гуртожиток  - натисніть: \"13\".");
            Console.WriteLine("14. Виселення студента з гуртожитка  - натисніть: \"14\".");
            Console.WriteLine("15. Продивитися інформацію про мешканців гуртожитка  - натисніть: \"15\".");
            Console.WriteLine("16. Продивитися інформацію про мешканців гуртожитка по кімнатах  - натисніть: \"16\".");
           
            int answer = Int32.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    AddGroup();
                    break;
                case 3:
                    ChangeStudent();
                    break;
                case 4:
                    SearchStudent();
                    break;
                case 5:
                    SearchStudents();
                    break;
                case 6:
                    ChangeGroup();
                    break;
                case 7:
                    SearchGroup();
                    break;
                case 8:
                    SearchGroups();
                    break;
                case 9:
                    RemoveStudent();
                    break;
                case 10:
                    DeleteStudent();
                    break;
                case 11:
                    RemoveGroup();
                    break;
                case 12:
                    AddHostel();
                    break;
                case 13:
                    ChangeHostel();
                    break;
                case 14:
                    DeleteStudentFromHostel();
                    break;
                case 15:
                    SearchHostel();
                    break;
                case 16:
                    SearchRooms();
                    break;
                    //default:
                    //    OpenMenu();
                    //    break;
            }
        }
        public void AddStudent()
        {
            string name = "", surname = "", groupname = "";
            int mounth, day, year, number, room;

            Console.WriteLine("Введіть ім'я:");
            name = Console.ReadLine();
            validator.AddName(name);
            Console.Clear();

            Console.WriteLine("Введіть прізвище:");
            surname = Console.ReadLine();
            validator.AddSurname(surname);
            Console.Clear();

            Console.WriteLine("Введіть день народження");
            day = int.Parse(Console.ReadLine());
            validator.AddDay(day);
            Console.Clear();

            Console.WriteLine("Введіть місяць народження");
            mounth = int.Parse(Console.ReadLine());
            validator.AddMounth(mounth);
            Console.Clear();

            Console.WriteLine("Введіть рік народження");
            year = int.Parse(Console.ReadLine());
            validator.AddYear(day);
            Console.Clear();

            Console.WriteLine("Введіть назву до якої групи ви хочете додати студента");
            groupname = Console.ReadLine();
            validator.AddGroup(groupname);
            Console.Clear();

            Console.WriteLine("Введіть номер гуртожитка");
            number = int.Parse(Console.ReadLine());
            validator.AddtoHostel(number);
            Console.Clear();

            Console.WriteLine("Введіть номер кімнати");
            room = int.Parse(Console.ReadLine());
            validator.AddtoHostel(room);
            Console.Clear();

            StudentService student = new StudentService();
            bool result = student.AddStudent(name, surname, year, mounth, day, groupname, number, room);
            if (result == true)
            {
                Console.WriteLine("Студент додан успішно");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("Студент не додан (такого студента не існує)");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }

        public void AddGroup()
        {
            string name = "";

            Console.WriteLine("Введіть ім'я:");
            name = Console.ReadLine();
            validator.AddGroup(name);
            Console.Clear();

            ServiceGroup group = new ServiceGroup();
            bool result = group.AddGroup(name);
            if (result == true)
            {
                Console.WriteLine("Група доданa успішно");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("Не вдалося додати групу. Така група вже існує.");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }
        public void ChangeStudent()
        {
            string name = "", surname = "", groupname= "";
            int mounth, day, year, number, room;

            Console.WriteLine("Введіть ім'я:");
            name = Console.ReadLine();
            validator.AddName(name);
            Console.Clear();

            Console.WriteLine("Введіть прізвище:");
            surname = Console.ReadLine();
            validator.AddSurname(surname);
            Console.Clear();
           
            Console.WriteLine("Введіть день народження");
            day = int.Parse(Console.ReadLine());
            validator.AddDay(day);
            Console.Clear();

            Console.WriteLine("Введіть місяць народження");
            mounth = int.Parse(Console.ReadLine());
            validator.AddMounth(mounth);
            Console.Clear();

            Console.WriteLine("Введіть рік народження");
            year = int.Parse(Console.ReadLine());
            validator.AddYear(year);
            Console.Clear();

            Console.WriteLine("Введіть назву до якої групи ви хочете додати студента");
            groupname = Console.ReadLine();
            validator.AddGroup(groupname);
            Console.Clear();

            Console.WriteLine("Введіть номер гуртожитка");
            number = int.Parse(Console.ReadLine());
            validator.AddtoHostel(number);
            Console.Clear();


            Console.WriteLine("Введіть номер кімнати");
            room = int.Parse(Console.ReadLine());
            validator.AddtoHostel(room);
            Console.Clear();

            StudentService student = new StudentService();
            bool result = student.ChangeStudent(name, surname, year,day,mounth, groupname, number, room);
            if (result == true)
            {
                Console.WriteLine("Студент змінен успішно");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("Студент не змінен (такого студента не існує)");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }

        }
        public void SearchStudent()
        {
            string name = "", surname = "";

            Console.WriteLine("Введіть ім'я:");
            name = Console.ReadLine();
            validator.AddName(name);
            Console.Clear();

            Console.WriteLine("Введіть прізвище:");
            surname = Console.ReadLine();
            validator.AddSurname(surname);
            Console.Clear();


            StudentService student = new StudentService();
            var result = student.SearchStudent(surname);
            if (result != null)
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item.Name + " " + item.Surname);
                }
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("такого студента не існує");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }
        public void SearchStudents()
        {
            Console.Clear();
            StudentService student = new StudentService();
            var result = student.SearchStudents();
            if (result != null)
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item.Name + " " + item.Surname + " " + item.Date);
                }
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("cтуденів не існує");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }
        public void ChangeGroup()
        {
            string groupname = "";

            Console.WriteLine("Введіть назву групи ");
            groupname = Console.ReadLine();
            validator.AddGroup(groupname);
            Console.Clear();
          
            ServiceGroup group = new ServiceGroup();   
            bool result = group.ChangeGroup(groupname);
            if (result == true)
            {
                Console.WriteLine("Група змінена успішно");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("Група не змінена (такої групи не існує)");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }
        
        public void SearchGroup()
        {
            string groupname;

            Console.WriteLine("Введіть ім'я:");
            groupname = Console.ReadLine();
            validator.AddGroup(groupname);
            Console.Clear();

            ServiceGroup group = new ServiceGroup();
            var result = group.SearchGroup(groupname);
            if (result != null)
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("такого групи не існує");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }
        public void SearchGroups()
        {
            Console.Clear();
            ServiceGroup group = new ServiceGroup();
            var result = group.SearchGroups();
            if (result != null)
            {
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                foreach(var item in result)
                {
                    Console.WriteLine(item.Name);
                }
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("груп не існує");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }
        public void RemoveStudent()
        {
            string name = "", surname = "";

            Console.WriteLine("Введіть ім'я:");
            name = Console.ReadLine();
            validator.AddName(name);
            Console.Clear();

            Console.WriteLine("Введіть прізвище:");
            surname = Console.ReadLine();
            validator.AddSurname(surname);
            Console.Clear();


            StudentService student = new StudentService();
            bool result = student.RemoveStudent(name, surname);
            if (result == true)
            {
                Console.WriteLine("Студент видален успішно");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("такого студента не існує");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }
        public void DeleteStudent()
        {
            string groupname = "", surname = "";

            Console.WriteLine("Введіть прізвище:");
            surname = Console.ReadLine();
            validator.AddSurname(surname);
            Console.Clear();

            Console.WriteLine("Введіть назву групи з якої ви хочете видалити студента");
            groupname = Console.ReadLine();
            validator.AddGroup(groupname);
            Console.Clear();

            ServiceGroup student = new ServiceGroup();
            bool result = student.DeleteStudent(groupname, surname);
            if (result == true)
            {
                Console.WriteLine("Студент видален успішно");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("такого студента не існує");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }
        public void RemoveGroup()
        {
            string groupname = "";

            Console.WriteLine("Введіть ім'я:");
            groupname = Console.ReadLine();
            validator.AddGroup(groupname);
            Console.Clear();

            ServiceGroup group = new ServiceGroup();
            bool result = group.RemoveGroup(groupname);
            if (result == true)
            {
                Console.WriteLine("Група видалена успішно"); 
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("Не вдалося видалити групу. Такої групи не існує.");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }
        public void AddHostel()
        {
            int number, room;

            Console.WriteLine("Введіть номер гуртожитка");
            number = int.Parse(Console.ReadLine());
            validator.AddtoHostel(number);
            Console.Clear();

            Console.WriteLine("Введіть кількість кімнат");
            room = int.Parse(Console.ReadLine());
            validator.AddtoHostel(room);
            Console.Clear();

            HostelService hostel = new HostelService();
            bool result = hostel.AddHostel(number, room);
            if (result == true)
            {
                Console.WriteLine("Гуртожиток додан успішно");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("Гуртожиток не додан (такого Гуртожитка не існує)");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }
        public void ChangeHostel()
        {
            int number, room;

            Console.WriteLine("Введіть номер гуртожитка");
            number = int.Parse(Console.ReadLine());
            validator.AddtoHostel(number);
            Console.Clear();

            Console.WriteLine("Введіть кількість кімнат");
            room = int.Parse(Console.ReadLine());
            validator.AddtoHostel(room);
            Console.Clear();

            HostelService hostel = new HostelService();
            bool result = hostel.ChangeHostel(number, room);
            if (result == true)
            {
                Console.WriteLine("Гуртожиток успішно змінен");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("такого Гуртожитка не існує");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();

            }
        }
        public void DeleteStudentFromHostel()
        {
            int number;
            string surname = "";

            Console.WriteLine("Введіть номер гуртожитка");
            number = int.Parse(Console.ReadLine());
            validator.AddtoHostel(number);
            Console.Clear();

            Console.WriteLine("Введіть прізвище:");
            surname = Console.ReadLine();
            validator.AddSurname(surname);
            Console.Clear();

            HostelService hostel = new HostelService();
            bool result = hostel.DeleteStudent(number, surname);
            if (result == true)
            {
                Console.WriteLine("Студент виселен успішно");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("такого студента не існує");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();

            }
        }
        public void SearchHostel()
        {
            int number;

            Console.WriteLine("Введіть номер гуртожитка");
            number = int.Parse(Console.ReadLine());
            validator.AddtoHostel(number);
            Console.Clear();

            HostelService hostel = new HostelService();
            var result = hostel.SearchHostel(number);
            if (result != null)
            {
               Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
               foreach (var item in result)
               {
                   Console.WriteLine(item.Number);
               }
               Console.ReadLine();
               OpenMenu();
            }
            else
            {
               Console.WriteLine("гуртожитка не існує");
               Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
               Console.ReadLine();
               OpenMenu();
            }  
        }
        public void SearchRooms()
        {
            int room;

            Console.WriteLine("Введіть кількість кімнат");
            room = int.Parse(Console.ReadLine());
            validator.AddtoHostel(room);
            Console.Clear();

            HostelService hostel = new HostelService();
            var result = hostel.SearchHostel(room);
            if (result != null)
            {
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                foreach (var item in result)
                {
                    Console.WriteLine(item.Room);
                }
                Console.ReadLine();
                OpenMenu();
            }
            else
            {
                Console.WriteLine("гуртожитка не існує");
                Console.WriteLine("Натисність на будь-яку клавішу для повернення в меню");
                Console.ReadLine();
                OpenMenu();
            }
        }
    }
}