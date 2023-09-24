using System;
using System.Collections.Generic;

namespace Shelter.Models;

public partial class Contract
{
    public int Id { get; set; }

    public int? Number { get; set; }

    public DateOnly? ConDate { get; set; }

    public DateOnly? ValidDate { get; set; }

    public string? Executor { get; set; }

    public string? Customer { get; set; }

    public int? Icid { get; set; }

    public int? Zcid { get; set; }

    public virtual ICollection<Act> Acts { get; set; } = new List<Act>();

    public virtual ICollection<ContractsSettlement> ContractsSettlements { get; set; } = new List<ContractsSettlement>();

    public virtual Organization? Ic { get; set; }

    public virtual Organization? Zc { get; set; }
}
