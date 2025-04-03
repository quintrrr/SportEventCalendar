﻿using System;
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
            public int sport_number { get; set; }
            [Required]
            public string name { get; set; }
            public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
