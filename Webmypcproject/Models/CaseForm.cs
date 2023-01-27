using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class CaseForm
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Case> Cases { get; } = new List<Case>();
}
