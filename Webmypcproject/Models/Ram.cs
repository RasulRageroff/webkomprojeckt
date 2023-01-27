using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Ram
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public int? Idtype { get; set; }

    public string? Capacity { get; set; }

    public string? Ramspeed { get; set; }

    public string? Type { get; set; }

    public virtual Memorytype? IdtypeNavigation { get; set; }

    public virtual ICollection<Pc> Pcs { get; } = new List<Pc>();
}
