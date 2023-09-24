using System;
using System.Collections.Generic;

namespace Shelter.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Role { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public string? SurName { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Act> Acts { get; set; } = new List<Act>();
}
