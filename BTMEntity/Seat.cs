using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMEntity
{
    public class Seat: Entity
    {
        public String Name { get; set; }
        public int BusID { get; set; }
        public int PassengerID { get; set; }
        public int Status { get; set; }
    }
}
