using System;
using System.Collections.Generic;

namespace Shelter.Models;

public partial class Organization
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Inn { get; set; }

    public string? Kpp { get; set; }

    public string? Address { get; set; }

    public int? Tid { get; set; }

    public bool? Ip { get; set; }

    public bool? Ur { get; set; }

    public virtual ICollection<Act> Acts { get; set; } = new List<Act>();

    public virtual ICollection<Contract> ContractIcs { get; set; } = new List<Contract>();

    public virtual ICollection<Contract> ContractZcs { get; set; } = new List<Contract>();

    public virtual Type? TidNavigation { get; set; }
}
