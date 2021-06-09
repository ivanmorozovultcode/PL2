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
        public bool AddHostel(int number)
        {
            if (number >0)
            {
                using (DataBaseContext db = new DataBaseContext())
                {

                    Hostel hostel = new Hostel
                    {
                        Number = number,
                    };

                    db.Hostels.Add(hostel);
                    db.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public bool AddRoom(int room, int hostelnumber)
        {
            if ( room > 0 && hostelnumber>0)
            {
                using (DataBaseContext db = new DataBaseContext())
                {

                    var FindedHostel = db.Hostels.Where(a => a.Number == hostelnumber).FirstOrDefault();
                    Room room1 = new Room
                    {
                       RoomNumber = room,
                       IDHostel = FindedHostel.ID
                    };

                    db.Rooms.Add(room1);
                    db.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        
        public bool ChangeHostel(int number)
        {
            if (number > 0 )
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    var FindedHostel = db.Hostels.Where(a=>a.Number==number).FirstOrDefault();
                    FindedHostel.Number = number;
                   
                    db.SaveChanges();
                    return true;
                }
            }
            else return false;
        }
        public bool DeleteStudent(string surname)
        {
            if (surname != null)
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    var FindedStudent = db.Students.Where(findedstudent => findedstudent.Surname == surname).FirstOrDefault();
                    FindedStudent.RoomID = 0;   
                    db.SaveChanges();
                    return true;
                }
            }
            else return false;
        }
        public List<Student> SearchHostel()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Students.Where(a => a.RoomID > 0).ToList();
            }
        }
        public List<Student> SearchRooms(int rooms)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Students.Where(a => a.RoomID == rooms).ToList();
            }
        }
    }
}
