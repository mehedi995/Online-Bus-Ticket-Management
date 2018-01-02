using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMEntity
{
    public class Bus: Entity
    {
        public String Name { get; set; }
        public String Route { get; set; }
        public String DepartureDate { get; set; }    
        public String DepartureTime { get; set; }
        public String StartingCounter { get; set;}
        public String EndingCounter { get; set; }
        public int Fare { get; set; }
        public String CoachType { get; set; }
        public String ArivalTime { get; set; }
        public int SeatAvailable { get; set; }

    }
}
