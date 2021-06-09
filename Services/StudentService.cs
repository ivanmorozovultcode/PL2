using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL2;
using DAL2.Model;
namespace Services
{
    public class StudentService
    {
        public bool AddStudent(string name, string surname, int year, int mounth, int day, string namegroup, int room)
        {
            if (name != null && surname != null && year > 0 && mounth > 0 && day > 0 && room > 0)
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    var Group = db.Groups.Where(a => a.Name == namegroup).FirstOrDefault();
                    var Room = db.Rooms.Where(a => a.RoomNumber == room).FirstOrDefault();
                    Student NewStudent = new Student
                    {
                        Name = name,
                        Surname = surname,
                        Date = new DateTime(year, mounth, day),
                        GroupID = Group.ID,
                        RoomID = Room.ID
                    };

                    db.Students.Add(NewStudent);
                    db.SaveChanges();
                    return true;
                }
            }
            else 
            {
                return false;
            }
        }
        public bool RemoveStudent(string name, string surname)
        {
            if (name != null && surname != null)
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    var FindedStudent = db.Students.Where(findedstudent => findedstudent.Name == name && findedstudent.Surname == surname).FirstOrDefault();
                    db.Students.Remove(FindedStudent);
                    db.SaveChanges();
                    return true;
                }
            }
            else return false;
            }
        public bool ChangeStudent(string name, string surname, int year, int mounth, int day, string groupname, int number, int room)
        {
            if (name != null && surname != null)
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    var FindedStudent = db.Students.Where(findedstudent => findedstudent.Name == name && findedstudent.Surname == surname).FirstOrDefault();

                    FindedStudent.Name = name;
                    FindedStudent.Surname = surname;
                    FindedStudent.Date = new DateTime(year, mounth, day);
                    FindedStudent.Group.Name = groupname;
                    // FindedStudent.Hostel.Number = number;
                    var FindedRoom = db.Rooms.Where(a => a.RoomNumber == number).FirstOrDefault();
                    FindedStudent.RoomID = FindedRoom.ID;
                    db.SaveChanges();
                    return true;
                }
            }
            else return false;
        }
        public List<Student> SearchStudents()
        {
                using (DataBaseContext db = new DataBaseContext())
                {
                    return db.Students.ToList();
                }
        }
        public List<Student> SearchStudent(string surname)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Students.Where(a => a.Surname == surname).ToList();
            }
        }
    }
}