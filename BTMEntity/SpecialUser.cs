using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMEntity
{
    public class SpecialUser:Entity
    {
        [Required]
        [MaxLength(50)]
        public String UserName { get; set; }
        [Required]
        [MaxLength(50)]
        public String Password { get; set; }
    }
}
