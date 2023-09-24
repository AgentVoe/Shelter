using System;
using System.Collections.Generic;

namespace Shelter.Models;

public partial class Type
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();
}
