using System;
using System.Collections.Generic;

namespace Webmypcproject.Models;

public partial class Pc
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int IdCpu { get; set; }

    public int IdMotherboard { get; set; }

    public int IdVideocard { get; set; }

    public int IdRam { get; set; }

    public int IdPcpowersupplyUnit { get; set; }

    public int IdHdd { get; set; }

    public int IdSsd { get; set; }

    public int IdCooling { get; set; }

    public int IdCase { get; set; }

    public int? Price { get; set; }

    public int? Likes { get; set; }

    public int? Rel { get; set; }

    public virtual Case IdCaseNavigation { get; set; } = null!;

    public virtual Cooling IdCoolingNavigation { get; set; } = null!;

    public virtual Cpu IdCpuNavigation { get; set; } = null!;

    public virtual Hdd IdHddNavigation { get; set; } = null!;

    public virtual Motherboard IdMotherboardNavigation { get; set; } = null!;

    public virtual Pcpowersupply IdPcpowersupplyUnitNavigation { get; set; } = null!;

    public virtual Ram IdRamNavigation { get; set; } = null!;

    public virtual Ssd IdSsdNavigation { get; set; } = null!;

    public virtual Videocard IdVideocardNavigation { get; set; } = null!;

    public virtual User? RelNavigation { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
