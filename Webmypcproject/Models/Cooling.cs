using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Cooling
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Comments { get; set; }

    public int? Price { get; set; }

    public string? Socket { get; set; }

    public string? Fandimensions { get; set; }

    public string? Fanspeed { get; set; }

    public string? Noiselevel { get; set; }

    public string? Material { get; set; }

    public string? Rotationalspeedmax { get; set; }

    public string? Fanconnector { get; set; }

    public virtual ICollection<Pc> Pcs { get; } = new List<Pc>();
}
