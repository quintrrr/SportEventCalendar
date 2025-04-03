using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEventCalendar.Classes
{
    [Table("events")]
    public class Event
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        public string name { get; set; }
        public string description { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        
        public TimeSpan time { get; set; }
        public string image_url { get; set; }
        [ForeignKey("Sport")]
        public int sport_number { get; set; }

        public Sport Sport { get; set; }


        public Event(Guid id, string name, string description, DateTime start_date, DateTime end_date, int sport_number, TimeSpan time, string image_url)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.start_date = start_date;
            this.end_date = end_date;
            this.sport_number = sport_number;
            this.time = time;
            this.image_url = image_url;
        }
    }
}
