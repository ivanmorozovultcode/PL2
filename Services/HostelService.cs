using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL2;
using DAL2.Model;
namespace Services
{
    public class HostelService
    {
        public bool AddHostel(int number, int rooms)
        {
            if (number >0 && rooms > 0)
            {
                using (DataBaseContext db = new DataBaseContext())
                {

                    Hostel hostel = new Hostel
                    {
                        Number = number,
                        Room = rooms,
                      //  Residents = residents
                    };

                    db.Add(hostel);
                    db.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public bool ChangeHostel(int number, int rooms)
        {
            if (number > 0 )
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    var FindedHostel = db.Hostels.Where(a=>a.Number==number).FirstOrDefault();
                    FindedHostel.Number = number;
                    FindedHostel.Room = rooms;
                   
                    db.SaveChanges();
                    return true;
                }
            }
            else return false;
        }
        public bool DeleteStudent(int number, string surname)
        {
            if (surname != null && number > 0)
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    var FindedSGroup = db.Hostels.Where(findedgroup => findedgroup.Number == number).FirstOrDefault();
                    var FindedStudent = db.Students.Where(findedstudent => findedstudent.Surname == surname).FirstOrDefault();
                    db.Students.Remove(FindedStudent);
                    db.SaveChanges();
                    return true;
                }
            }
            else return false;
        }
        public List<Hostel> SearchHostel(int number)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Hostels.Where(a => a.Number == number).ToList();
            }
        }
        public List<Hostel> SearchRooms(int number, int rooms)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Hostels.Where(a => a.Room == rooms).ToList();
            }
        }
    }
}
