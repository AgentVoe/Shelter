using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Shelter.ContextModels;

public partial class Organization
{
    public int Id { get; set; }

    public string? OrgTitle { get; set; }

    public string? Inn { get; set; }

    public string? Kpp { get; set; }

    public string? Adres { get; set; }
    [Browsable(false)]
    public virtual ICollection<City> Cities { get; set; } = new List<City>();
    [Browsable(false)]
    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
