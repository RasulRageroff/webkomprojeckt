using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Webmypcproject.Models;

public partial class RasulpcContext : DbContext
{
    public RasulpcContext()
    {
    }

    public RasulpcContext(DbContextOptions<RasulpcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Case> Cases { get; set; }

    public virtual DbSet<CaseForm> CaseForms { get; set; }

    public virtual DbSet<Cooling> Coolings { get; set; }

    public virtual DbSet<Cpu> Cpus { get; set; }

    public virtual DbSet<Cpumanufacturer> Cpumanufacturers { get; set; }

    public virtual DbSet<Hdd> Hdds { get; set; }

    public virtual DbSet<IdSocket> IdSockets { get; set; }

    public virtual DbSet<Memorytype> Memorytypes { get; set; }

    public virtual DbSet<Motherboard> Motherboards { get; set; }

    public virtual DbSet<Pc> Pcs { get; set; }

    public virtual DbSet<Pcpowersupply> Pcpowersupplies { get; set; }

    public virtual DbSet<Ram> Rams { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Ssd> Ssds { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Videocard> Videocards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-VR7QIAT\\RASULIK; Database=Rasulpc;Trusted_Connection=True; TrustServerCertificate=True; ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Case>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IdCases");

            entity.ToTable("Case");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Cases)
                .HasForeignKey(d => d.IdForm)
                .HasConstraintName("FK_Case_CaseForm");
        });

        modelBuilder.Entity<CaseForm>(entity =>
        {
            entity.ToTable("CaseForm");

            entity.Property(e => e.Name).HasMaxLength(25);
        });

        modelBuilder.Entity<Cooling>(entity =>
        {
            entity.ToTable("Cooling");

            entity.Property(e => e.Comments).HasMaxLength(350);
            entity.Property(e => e.Fanconnector).HasMaxLength(50);
            entity.Property(e => e.Fandimensions).HasMaxLength(50);
            entity.Property(e => e.Fanspeed).HasMaxLength(50);
            entity.Property(e => e.Material).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Noiselevel).HasMaxLength(50);
            entity.Property(e => e.Rotationalspeedmax).HasMaxLength(50);
        });

        modelBuilder.Entity<Cpu>(entity =>
        {
            entity.ToTable("CPU");

            entity.Property(e => e.Cpucores).HasColumnName("CPUCores");
            entity.Property(e => e.Graphicsintegrated).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.IdSocketNavigation).WithMany(p => p.Cpus)
                .HasForeignKey(d => d.IdSocket)
                .HasConstraintName("FK_CPU_IdSocket");

            entity.HasOne(d => d.IdmanufacturerNavigation).WithMany(p => p.Cpus)
                .HasForeignKey(d => d.Idmanufacturer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CPU_CPUmanufacturer1");
        });

        modelBuilder.Entity<Cpumanufacturer>(entity =>
        {
            entity.ToTable("CPUmanufacturer");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Hdd>(entity =>
        {
            entity.ToTable("HDD");

            entity.Property(e => e.Cache).HasMaxLength(50);
            entity.Property(e => e.Capacity).HasMaxLength(50);
            entity.Property(e => e.Formfactor).HasMaxLength(50);
            entity.Property(e => e.InterfaceType).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.SpindleSpeed).HasMaxLength(50);
        });

        modelBuilder.Entity<IdSocket>(entity =>
        {
            entity.ToTable("IdSocket");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Memorytype>(entity =>
        {
            entity.ToTable("memorytype");

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Motherboard>(entity =>
        {
            entity.ToTable("Motherboard");

            entity.Property(e => e.Formfactor).HasMaxLength(50);
            entity.Property(e => e.MaxRam).HasColumnName("MaxRAM");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Ramsockets).HasColumnName("RAMSockets");
            entity.Property(e => e.Ramtechnology)
                .HasMaxLength(50)
                .HasColumnName("RAMtechnology");
            entity.Property(e => e.Socket).HasMaxLength(50);

            entity.HasOne(d => d.IdSocketNavigation).WithMany(p => p.Motherboards)
                .HasForeignKey(d => d.IdSocket)
                .HasConstraintName("FK_Motherboard_IdSocket1");
        });

        modelBuilder.Entity<Pc>(entity =>
        {
            entity.ToTable("PC");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCpu).HasColumnName("IdCPU");
            entity.Property(e => e.IdHdd).HasColumnName("IdHDD");
            entity.Property(e => e.IdPcpowersupplyUnit).HasColumnName("IdPCPOWERSupplyUNIT");
            entity.Property(e => e.IdRam).HasColumnName("IdRAM");
            entity.Property(e => e.IdSsd).HasColumnName("IdSSD");
            entity.Property(e => e.Likes).HasColumnName("likes");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Rel).HasColumnName("rel");

            entity.HasOne(d => d.IdCaseNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdCase)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PC_Case");

            entity.HasOne(d => d.IdCoolingNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdCooling)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PC_Cooling");

            entity.HasOne(d => d.IdCpuNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdCpu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PC_CPU");

            entity.HasOne(d => d.IdHddNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdHdd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PC_HDD");

            entity.HasOne(d => d.IdMotherboardNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdMotherboard)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PC_Motherboard");

            entity.HasOne(d => d.IdPcpowersupplyUnitNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdPcpowersupplyUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PC_pcpowersupply");

            entity.HasOne(d => d.IdRamNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdRam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PC_RAM");

            entity.HasOne(d => d.IdSsdNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdSsd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PC_SSD");

            entity.HasOne(d => d.IdVideocardNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdVideocard)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PC_Videocard");

            entity.HasOne(d => d.RelNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.Rel)
                .HasConstraintName("FK_PC_User");
        });

        modelBuilder.Entity<Pcpowersupply>(entity =>
        {
            entity.ToTable("pcpowersupply");

            entity.Property(e => e.Certificate)
                .HasMaxLength(50)
                .HasColumnName("certificate");
            entity.Property(e => e.Fansize).HasMaxLength(50);
            entity.Property(e => e.FormFactor).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Pfc)
                .HasMaxLength(50)
                .HasColumnName("PFC");
            entity.Property(e => e.Power).HasMaxLength(50);
            entity.Property(e => e.Sataconnectors).HasColumnName("SATAConnectors");
        });

        modelBuilder.Entity<Ram>(entity =>
        {
            entity.ToTable("RAM");

            entity.Property(e => e.Capacity).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Ramspeed)
                .HasMaxLength(50)
                .HasColumnName("RAMSpeed");
            entity.Property(e => e.Type).HasMaxLength(50);

            entity.HasOne(d => d.IdtypeNavigation).WithMany(p => p.Rams)
                .HasForeignKey(d => d.Idtype)
                .HasConstraintName("FK_RAM_memorytype");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Ssd>(entity =>
        {
            entity.ToTable("SSD");

            entity.Property(e => e.Formfactor).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ReadingSpeed).HasMaxLength(50);
            entity.Property(e => e.Writingspeed).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Idpc).HasColumnName("idpc");
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");

            entity.HasOne(d => d.IdpcNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Idpc)
                .HasConstraintName("FK_User_PC");
        });

        modelBuilder.Entity<Videocard>(entity =>
        {
            entity.ToTable("Videocard");

            entity.Property(e => e.GpubaseClock)
                .HasMaxLength(50)
                .HasColumnName("GPUBaseClock");
            entity.Property(e => e.GpuboostClock)
                .HasMaxLength(50)
                .HasColumnName("GPUBoostClock");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Recommendedpowersupply).HasMaxLength(50);
            entity.Property(e => e.Vram)
                .HasMaxLength(50)
                .HasColumnName("VRAM");
            entity.Property(e => e.Vramtype)
                .HasMaxLength(50)
                .HasColumnName("VRAMType");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
