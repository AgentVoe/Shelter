using System;
using System.Collections.Generic;

namespace Shelter.Models;

public partial class Settlement
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();

    public virtual ICollection<ContractsSettlement> ContractsSettlements { get; set; } = new List<ContractsSettlement>();

    public virtual Schedule? Schedule { get; set; }
}
