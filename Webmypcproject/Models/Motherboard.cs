using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Motherboard
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? IdSocket { get; set; }

    public int? Price { get; set; }

    public string? Socket { get; set; }

    public int? Ramsockets { get; set; }

    public string? Ramtechnology { get; set; }

    public int? MaxRam { get; set; }

    public string? Formfactor { get; set; }

    public virtual IdSocket? IdSocketNavigation { get; set; }

    public virtual ICollection<Pc> Pcs { get; } = new List<Pc>();
}
