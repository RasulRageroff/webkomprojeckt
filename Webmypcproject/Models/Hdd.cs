using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Hdd
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public string? Formfactor { get; set; }

    public string? Capacity { get; set; }

    public string? InterfaceType { get; set; }

    public string? Cache { get; set; }

    public string? SpindleSpeed { get; set; }

    public virtual ICollection<Pc> Pcs { get; } = new List<Pc>();
}
