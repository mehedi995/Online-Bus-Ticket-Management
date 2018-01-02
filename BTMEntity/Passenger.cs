using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMEntity
{
    public class Passenger: Entity
    {
        public String Name { get; set; }
        public int Mobile { get; set; }
        public int Age { get; set; }
        public String Email { get; set; }
        public String Gender { get; set; }
        public String Address { get; set; }
        public String BoardingPoint { get; set; }
        public String DropingPoint { get; set; }
        public String DepartureDate { get; set; }
        public String BoardingTime { get; set; }
        public int BusID { get; set; }
    }
}
