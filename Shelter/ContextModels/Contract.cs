using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Shelter.ContextModels;

public partial class Contract
{
    public int Id { get; set; }

    public string? ContractNumber { get; set; }

    public DateOnly? ConclusionDate { get; set; }

    public DateOnly? ValidDate { get; set; }
    [Browsable(false)]
    public int? OrganizationId { get; set; }
    [Browsable(false)]
    public virtual ICollection<Act> Acts { get; set; } = new List<Act>();
    [Browsable(false)]
    public virtual ICollection<ContractsCity> ContractsCities { get; set; } = new List<ContractsCity>();
    [Browsable(false)]
    public virtual Organization? Organization { get; set; }
    [Browsable(false)]
    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
    public string OrganizationTitle { get; set; }
}
