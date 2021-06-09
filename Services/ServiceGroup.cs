using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL2;
using DAL2.Model;
namespace Services
{
    public class ServiceGroup
    {
        public bool AddGroup(string name)
        {
            if (name != null)
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    Group NewGroup = new Group
                    {
                        Name = name
                    };

                    db.Groups.Add(NewGroup);
                    db.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public bool RemoveGroup(string name)
        {
            if (name != null)
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    var A = db.Groups.ToList();
                    var FindedGroup = db.Groups.Where(findedgroup => findedgroup.Name == name).FirstOrDefault();
                    db.Groups.Remove(FindedGroup);
                    db.SaveChanges();
                    return true;
                }
            }
            else return false;
        }
        public bool ChangeGroup(string name)
        {
            if (name != null)
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    var FindedSGroup = db.Groups.Where(findedgroup => findedgroup.Name == name).FirstOrDefault();
                    FindedSGroup.Name = name;
                    db.SaveChanges();
                    return true;
                }
            }
            else return false;
        }
        public List<Group> SearchGroup(string name)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Groups.Where(a => a.Name == name).ToList();
            }
        }
        public List<Group> SearchGroups()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Groups.ToList();
            }
        }
        public bool DeleteStudent(string groupname, string surname)
        {
            if (surname != null && groupname!=null )
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    var FindedSGroup = db.Groups.Where(findedgroup => findedgroup.Name == groupname).FirstOrDefault();
                    var FindedStudent = db.Students.Where(findedstudent => findedstudent.Surname == surname).FirstOrDefault();
                    db.Students.Remove(FindedStudent);
                    db.SaveChanges();
                    return true;
                }
            }
            else return false;
        }
    }
}
