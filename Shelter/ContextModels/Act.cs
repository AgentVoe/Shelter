using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Shelter.ContextModels;

public partial class Act
{
    public int Id { get; set; }

    public string? ActNumber { get; set; }

    public int? CatchedCats { get; set; }

    public int? CatchedDogs { get; set; }

    public DateOnly? CatchingDate { get; set; }

    public string? Purpose { get; set; }
    [Browsable(false)]
    public int? ContractId { get; set; }
    [Browsable(false)]
    public int? CityId { get; set; }
    [Browsable(false)]
    public virtual City? City { get; set; }
    [Browsable(false)]
    public virtual Contract? Contract { get; set; }

    public string? ContractNumber { get; set; }
    public string? CityTitle { get; set; }
}

