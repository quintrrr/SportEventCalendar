using System;
using System.Collections.Generic;

namespace SportEventCalendar.Models;

public partial class EventTeam
{
    public Guid? EventId { get; set; }

    public int? TeamId { get; set; }
}
