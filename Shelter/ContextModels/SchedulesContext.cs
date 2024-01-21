using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Shelter.ContextModels;

public partial class SchedulesContext : DbContext
{
    public SchedulesContext()
    {
    }

    public SchedulesContext(DbContextOptions<SchedulesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Act> Acts { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<ContractsCity> ContractsCities { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-4CLJNJO8;Initial Catalog=Schedules;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Act>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Acts__3213E83F2271770D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("actNumber");
            entity.Property(e => e.CatchedCats).HasColumnName("catchedCats");
            entity.Property(e => e.CatchedDogs).HasColumnName("catchedDogs");
            entity.Property(e => e.CatchingDate).HasColumnName("catchingDate");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.ContractId).HasColumnName("contract_id");
            entity.Property(e => e.Purpose)
                .HasColumnType("text")
                .HasColumnName("purpose");

            entity.HasOne(d => d.City).WithMany(p => p.Acts)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__Acts__city_id__4316F928");

            entity.HasOne(d => d.Contract).WithMany(p => p.Acts)
                .HasForeignKey(d => d.ContractId)
                .HasConstraintName("FK__Acts__contract_i__4222D4EF");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cities__3213E83F3FE01D2A");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CityTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("cityTitle");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

            entity.HasOne(d => d.Organization).WithMany(p => p.Cities)
                .HasForeignKey(d => d.OrganizationId)
                .HasConstraintName("FK__Cities__organiza__3F466844");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__3213E83F4FF3C63C");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConclusionDate).HasColumnName("conclusionDate");
            entity.Property(e => e.ContractNumber)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            entity.Property(e => e.ValidDate).HasColumnName("validDate");

            entity.HasOne(d => d.Organization).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.OrganizationId)
                .HasConstraintName("FK__Contracts__organ__3C69FB99");
        });

        modelBuilder.Entity<ContractsCity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contract__3213E83FB2034DAA");

            entity.ToTable("Contracts_Cities");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatchingPrice).HasColumnName("catchingPrice");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.ContractId).HasColumnName("contract_id");

            entity.HasOne(d => d.City).WithMany(p => p.ContractsCities)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__Contracts__city___4AB81AF0");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractsCities)
                .HasForeignKey(d => d.ContractId)
                .HasConstraintName("FK__Contracts__contr__49C3F6B7");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Organiza__3213E83FE9673D10");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adres)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Inn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("inn");
            entity.Property(e => e.Kpp)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("kpp");
            entity.Property(e => e.OrgTitle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("orgTitle");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Schedule__3213E83FB482B6F2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnimalsToCatch).HasColumnName("animalsToCatch");
            entity.Property(e => e.CatchingMonth).HasColumnName("catchingMonth");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.ContractId).HasColumnName("contract_id");

            entity.HasOne(d => d.City).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__Schedules__city___46E78A0C");

            entity.HasOne(d => d.Contract).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.ContractId)
                .HasConstraintName("FK__Schedules__contr__45F365D3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
