using System;
using System.Collections.Generic;

namespace SportEventCalendar.Models;

public partial class Event
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int SportNumber { get; set; }

    public TimeOnly Time { get; set; }

    public string ImageUrl { get; set; } = null!;
}
