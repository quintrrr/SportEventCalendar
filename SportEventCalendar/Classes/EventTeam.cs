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
        [Column("event_id")]
        public Guid Event_id { get; set; }


        [Column("team_id")]
        public int Team_id { get; set; }

        public EventTeam(Guid event_id, int team_id) 
        {
            Event_id = event_id;
            Team_id = team_id;
        }
    }
}
