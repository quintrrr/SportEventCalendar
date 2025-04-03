using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEventCalendar.Classes
{

    [Table("event_team")]
    public class EventTeam
    {
        [Key]
        public int event_id { get; set; }
        [Required]

        public int team_id { get; set; }

    }
}
