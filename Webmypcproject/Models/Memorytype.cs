using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Memorytype
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<Ram> Rams { get; } = new List<Ram>();
}
