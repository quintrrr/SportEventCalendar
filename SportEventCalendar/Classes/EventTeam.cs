using System.ComponentModel.DataAnnotations.Schema;

namespace SportEventCalendar.Classes
{

    [Table("event_team")]
    public class EventTeam
    {
        [Column("event_id")]
        public Guid Event_id { get; set; }
        //индекс уникальности

        [Column("team_id")]
        public int Team_id { get; set; }

        public EventTeam(Guid event_id, int team_id) 
        {
            Event_id = event_id;
            Team_id = team_id;
        }
    }
}
