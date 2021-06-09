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
        public List<Room> Rooms { get; set; } = new List<Room>();
       // public int Residents { get; set; }
    }
}
