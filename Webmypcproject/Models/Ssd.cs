using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Ssd
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public string? ReadingSpeed { get; set; }

    public string? Writingspeed { get; set; }

    public string? Formfactor { get; set; }

    public virtual ICollection<Pc> Pcs { get; } = new List<Pc>();
}
