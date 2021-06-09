using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL2.Model
{
    public class Room
    {
        public int ID { get; set; }
        public int RoomNumber { get; set; }
        public int IDHostel { get; set; }
        public Hostel hostel { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
