using System;
using System.Collections.Generic;

namespace Shelter.Models;

public partial class ContractsSettlement
{
    public int Id { get; set; }

    public int? Cid { get; set; }

    public int? Sid { get; set; }

    public virtual Contract? CidNavigation { get; set; }

    public virtual Settlement? SidNavigation { get; set; }
}
