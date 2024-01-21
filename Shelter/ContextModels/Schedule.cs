using System;
using System.Collections.Generic;

namespace Shelter.ContextModels;

public partial class Schedule
{
    public int Id { get; set; }

    public DateOnly? CatchingMonth { get; set; }

    public int? AnimalsToCatch { get; set; }

    public int? ContractId { get; set; }

    public int? CityId { get; set; }

    public virtual City? City { get; set; }

    public virtual Contract? Contract { get; set; }
}
