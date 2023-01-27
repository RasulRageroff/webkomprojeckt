using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Cpu
{
    public int Id { get; set; }

    public int Idmanufacturer { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public int? IdSocket { get; set; }

    public int? Cpucores { get; set; }

    public double? Speed { get; set; }

    public string? Graphicsintegrated { get; set; }

    public int? Threads { get; set; }

    public virtual IdSocket? IdSocketNavigation { get; set; }

    public virtual Cpumanufacturer IdmanufacturerNavigation { get; set; } = null!;

    public virtual ICollection<Pc> Pcs { get; } = new List<Pc>();
}
