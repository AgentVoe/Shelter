using System;
using System.Collections.Generic;

namespace Shelter.Models;

public partial class Animal
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? Sex { get; set; }

    public string? Breed { get; set; }

    public decimal? Size { get; set; }

    public string? Hair { get; set; }

    public string? Color { get; set; }

    public string? Ears { get; set; }

    public string? Tail { get; set; }

    public string? Signs { get; set; }

    public string? Mark { get; set; }

    public string? Chip { get; set; }

    public int? Sid { get; set; }

    public int? Aid { get; set; }

    public virtual Act? AidNavigation { get; set; }

    public virtual Settlement? SidNavigation { get; set; }
}
