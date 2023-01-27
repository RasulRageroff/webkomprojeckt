using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;


public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdRole { get; set; }

    public int? Idpc { get; set; }

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual Pc? IdpcNavigation { get; set; }

    public virtual ICollection<Pc> Pcs { get; } = new List<Pc>();
}
