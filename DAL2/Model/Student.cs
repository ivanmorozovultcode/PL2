using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL2.Model
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
        public int GroupID { get; set; }
        public Group Group { get; set; }
        public int Number { get; set; }
        public int Room { get; set; }
        public Hostel Hostel { get; set; }

    }
}
