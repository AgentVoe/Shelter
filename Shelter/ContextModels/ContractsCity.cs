using System;
using System.Collections.Generic;

namespace Shelter.ContextModels;

public partial class ContractsCity
{
    public int Id { get; set; }

    public int? ContractId { get; set; }

    public int? CityId { get; set; }

    public double? CatchingPrice { get; set; }

    public virtual City? City { get; set; }

    public virtual Contract? Contract { get; set; }
	public string? CityTitle { get; set; }
	public string? ContractNumber { get; set; }
}
