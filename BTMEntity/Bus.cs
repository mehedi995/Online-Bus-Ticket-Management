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
        [Required]
        [MaxLength(50)]
        public String Name { get; set; }
        [Required]
        [MaxLength(50)]
        public String Route { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Departure Date")]
        public DateTime DepartureDate { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Departure Time")]
        public DateTime DepartureTime { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Starting Counter")]
        public String StartingCounter { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Ending Counter")]
        public String EndingCounter { get; set; }
        [Required]
        public int Fare { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Coach Type")]
        public String CoachType { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Arival Time")]
        public DateTime ArivalTime { get; set; }
        [Required]
        [Display(Name = "AvailAble Seat")]
        public int SeatAvailable { get; set; }

    }
}
