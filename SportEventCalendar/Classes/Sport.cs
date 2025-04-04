using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
