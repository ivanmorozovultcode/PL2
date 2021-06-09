using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL2.Model
{
    public class Hostel
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int Room { get; set; }
       // public int Residents { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
