using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportEventCalendar.Classes
{
    [Table("teams")]
    public class Team
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Column("sport_number")]
        public int Sport_number { get; set; }

    }
}
