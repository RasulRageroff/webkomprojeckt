using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Case
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public int? IdForm { get; set; }

    public virtual CaseForm? IdFormNavigation { get; set; }

    public virtual ICollection<Pc> Pcs { get; } = new List<Pc>();
}
