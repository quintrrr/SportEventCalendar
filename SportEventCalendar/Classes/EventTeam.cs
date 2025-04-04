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
        [Column("event_id")]
        public int Event_id { get; set; }
        [Required]
        [Column("team_id")]
        public int Team_id { get; set; }

    }
}
