using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Videocard
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public string? Vram { get; set; }

    public string? Vramtype { get; set; }

    public int? BusWidth { get; set; }

    public string? Recommendedpowersupply { get; set; }

    public string? GpubaseClock { get; set; }

    public string? GpuboostClock { get; set; }

    public virtual ICollection<Pc> Pcs { get; } = new List<Pc>();
}
