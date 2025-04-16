using System;
using System.Collections.Generic;

namespace SportEventCalendar.Models;

public partial class Team
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? SportNumber { get; set; }
}
