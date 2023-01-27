using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Pcpowersupply
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public string? Power { get; set; }

    public string? FormFactor { get; set; }

    public string? Pfc { get; set; }

    public int? Sataconnectors { get; set; }

    public string? Certificate { get; set; }

    public int? Fans { get; set; }

    public string? Fansize { get; set; }

    public virtual ICollection<Pc> Pcs { get; } = new List<Pc>();
}
