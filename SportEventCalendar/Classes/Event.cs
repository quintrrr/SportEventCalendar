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
        [Column("id")]
        public Guid Id { get; set; } // с большой буквы
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("start_date")]
        public DateTime Start_date { get; set; }
        [Column("end_date")]
        public DateTime End_date { get; set; }
        [Column("time")]
        public TimeSpan Time { get; set; }
        [Column("image_url")]
        public string Image_url { get; set; }
        [Column("sport_number")]
        public int Sport_number { get; set; }

        [Column("sport_name")]
        public string Sport_name;


        public Event(Guid id, string name, string description, DateTime start_date, 
            DateTime end_date,int sport_number, TimeSpan time, string image_url, string sport_name)
        {
            Id = id;
            Name = name;
            Description = description;
            Start_date = start_date;
            End_date = end_date;
            Sport_number = sport_number;
            Time = time;
            Image_url = image_url;
            this.Sport_name = sport_name;
        }
        public Event(Guid id, string name, string description, DateTime start_date,
            DateTime end_date, int sport_number, TimeSpan time, string image_url)
        {
            Id = id;
            Name = name;
            Description = description;
            Start_date = start_date;
            End_date = end_date;
            Sport_number = sport_number;
            Time = time;
            Image_url = image_url;
        }
    }
}
