using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Cpumanufacturer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Cpu> Cpus { get; } = new List<Cpu>();
}
