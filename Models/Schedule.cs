using System;
using System.Collections.Generic;

namespace Shelter.Models;

public partial class Schedule
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public virtual Settlement IdNavigation { get; set; } = null!;
}
