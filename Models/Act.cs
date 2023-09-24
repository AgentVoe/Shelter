using System;
using System.Collections.Generic;

namespace Shelter.Models;

public partial class Act
{
    public int Id { get; set; }

    public int? Number { get; set; }

    public int? Dogs { get; set; }

    public int? Cats { get; set; }

    public int? Animals { get; set; }

    public int? Oid { get; set; }

    public DateOnly? Date { get; set; }

    public string? Target { get; set; }

    public string? Request { get; set; }

    public int? Cid { get; set; }

    public int? Uid { get; set; }

    public virtual ICollection<Animal> AnimalsNavigation { get; set; } = new List<Animal>();

    public virtual Contract? CidNavigation { get; set; }

    public virtual Organization? OidNavigation { get; set; }

    public virtual User? UidNavigation { get; set; }
}
