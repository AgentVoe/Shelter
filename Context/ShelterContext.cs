using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Shelter.Models;

namespace Shelter.Context;

public partial class ShelterContext : DbContext
{
    public ShelterContext()
    {
    }

    public ShelterContext(DbContextOptions<ShelterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Act> Acts { get; set; }

    public virtual DbSet<Animal> Animals { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<ContractsSettlement> ContractsSettlements { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Settlement> Settlements { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Shelter;Username=postgres;Password=admin");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Act>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("acts_pkey");

            entity.ToTable("acts");

            entity.HasIndex(e => e.Number, "acts_number_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Animals).HasColumnName("animals");
            entity.Property(e => e.Cats).HasColumnName("cats");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Dogs).HasColumnName("dogs");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.Oid).HasColumnName("oid");
            entity.Property(e => e.Request)
                .HasMaxLength(80)
                .HasColumnName("request");
            entity.Property(e => e.Target)
                .HasMaxLength(80)
                .HasColumnName("target");
            entity.Property(e => e.Uid).HasColumnName("uid");

            entity.HasOne(d => d.CidNavigation).WithMany(p => p.Acts)
                .HasForeignKey(d => d.Cid)
                .HasConstraintName("acts_cid_fkey");

            entity.HasOne(d => d.OidNavigation).WithMany(p => p.Acts)
                .HasForeignKey(d => d.Oid)
                .HasConstraintName("acts_oid_fkey");

            entity.HasOne(d => d.UidNavigation).WithMany(p => p.Acts)
                .HasForeignKey(d => d.Uid)
                .HasConstraintName("acts_uid_fkey");
        });

        modelBuilder.Entity<Animal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("animals_pkey");

            entity.ToTable("animals");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aid).HasColumnName("aid");
            entity.Property(e => e.Breed)
                .HasMaxLength(80)
                .HasColumnName("breed");
            entity.Property(e => e.Category)
                .HasMaxLength(10)
                .HasColumnName("category");
            entity.Property(e => e.Chip)
                .HasMaxLength(80)
                .HasColumnName("chip");
            entity.Property(e => e.Color)
                .HasMaxLength(80)
                .HasColumnName("color");
            entity.Property(e => e.Ears)
                .HasMaxLength(80)
                .HasColumnName("ears");
            entity.Property(e => e.Hair)
                .HasMaxLength(80)
                .HasColumnName("hair");
            entity.Property(e => e.Mark)
                .HasMaxLength(80)
                .HasColumnName("mark");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .HasColumnName("sex");
            entity.Property(e => e.Sid).HasColumnName("sid");
            entity.Property(e => e.Signs)
                .HasMaxLength(100)
                .HasColumnName("signs");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Tail)
                .HasMaxLength(80)
                .HasColumnName("tail");

            entity.HasOne(d => d.AidNavigation).WithMany(p => p.AnimalsNavigation)
                .HasForeignKey(d => d.Aid)
                .HasConstraintName("animals_aid_fkey");

            entity.HasOne(d => d.SidNavigation).WithMany(p => p.Animals)
                .HasForeignKey(d => d.Sid)
                .HasConstraintName("animals_sid_fkey");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("contracts_pkey");

            entity.ToTable("contracts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConDate).HasColumnName("con_date");
            entity.Property(e => e.Customer)
                .HasMaxLength(50)
                .HasColumnName("customer");
            entity.Property(e => e.Executor)
                .HasMaxLength(50)
                .HasColumnName("executor");
            entity.Property(e => e.Icid).HasColumnName("icid");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.ValidDate).HasColumnName("valid_date");
            entity.Property(e => e.Zcid).HasColumnName("zcid");

            entity.HasOne(d => d.Ic).WithMany(p => p.ContractIcs)
                .HasForeignKey(d => d.Icid)
                .HasConstraintName("contracts_icid_fkey");

            entity.HasOne(d => d.Zc).WithMany(p => p.ContractZcs)
                .HasForeignKey(d => d.Zcid)
                .HasConstraintName("contracts_zcid_fkey");
        });

        modelBuilder.Entity<ContractsSettlement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("contracts_settlements_pkey");

            entity.ToTable("contracts_settlements");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Sid).HasColumnName("sid");

            entity.HasOne(d => d.CidNavigation).WithMany(p => p.ContractsSettlements)
                .HasForeignKey(d => d.Cid)
                .HasConstraintName("contracts_settlements_cid_fkey");

            entity.HasOne(d => d.SidNavigation).WithMany(p => p.ContractsSettlements)
                .HasForeignKey(d => d.Sid)
                .HasConstraintName("contracts_settlements_sid_fkey");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("organizations_pkey");

            entity.ToTable("organizations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(80)
                .HasColumnName("address");
            entity.Property(e => e.Inn)
                .HasMaxLength(10)
                .HasColumnName("inn");
            entity.Property(e => e.Ip).HasColumnName("ip");
            entity.Property(e => e.Kpp)
                .HasMaxLength(9)
                .HasColumnName("kpp");
            entity.Property(e => e.Tid).HasColumnName("tid");
            entity.Property(e => e.Title)
                .HasMaxLength(80)
                .HasColumnName("title");
            entity.Property(e => e.Ur).HasColumnName("ur");

            entity.HasOne(d => d.TidNavigation).WithMany(p => p.Organizations)
                .HasForeignKey(d => d.Tid)
                .HasConstraintName("organizations_tid_fkey");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("schedules_pkey");

            entity.ToTable("schedules");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Schedule)
                .HasForeignKey<Schedule>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("schedules_id_fkey");
        });

        modelBuilder.Entity<Settlement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("settlements_pkey");

            entity.ToTable("settlements");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(80)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("types_pkey");

            entity.ToTable("types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(80)
                .HasColumnName("title");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Login, "users_login_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastName)
                .HasMaxLength(80)
                .HasColumnName("last_name");
            entity.Property(e => e.Login)
                .HasMaxLength(80)
                .HasColumnName("login");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(80)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(80)
                .HasColumnName("role");
            entity.Property(e => e.SurName)
                .HasMaxLength(80)
                .HasColumnName("sur_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
