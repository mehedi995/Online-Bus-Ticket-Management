using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMEntity
{
    public class Seat:Entity
    {
        [Required]
        [MaxLength(50)]
        public String Name { get; set; }
        [Required]
        public int BusID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Departure Date")]
        public DateTime DepartureDate { get; set; }
        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Departure Time")]
        public DateTime DepartureTime { get; set; }
        public int? PassengerID { get; set; }
        public bool Status { get; set; }
    }
}
