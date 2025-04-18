using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportEventCalendar.Classes
{
    [Table("sports")]
    public class Sport
    {
        [Key]
        [Column("sport_number")]
        public int Sport_number { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
    }
}
