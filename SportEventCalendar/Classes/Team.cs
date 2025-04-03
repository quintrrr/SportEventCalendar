using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEventCalendar.Classes
{
    [Table("teams")]
    public class Team
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public int sport_number { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
