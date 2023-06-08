using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.DbModels;

public partial class HistoryZfContext : DbContext
{
    public HistoryZfContext()
    {
    }

    public HistoryZfContext(DbContextOptions<HistoryZfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<HistoryEvent> Events { get; set; }

    public virtual DbSet<Person> People { get; set; }
    public object HistoryEvent { get; internal set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=TZIPILAPTOP\\SQLEXPRESS;Initial Catalog=HistoryZF;Trusted_Connection=True;trustserverCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Country__10D1609F0DAE7E3E");

            entity.ToTable("Country");

            entity.HasIndex(e => e.CountryName, "UQ__Country__E056F20197D93E2C").IsUnique();

            entity.Property(e => e.CountryName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.StateBorders).HasMaxLength(3000);
        });

        modelBuilder.Entity<HistoryEvent>(entity =>
        {
            entity.ToTable("HistoryEvents");
            entity.HasKey(e => e.EventId).HasName("PK__Events__7944C810033C6CC2");

            entity.HasIndex(e => e.TiteleEvent, "UQ__Events__86C17744AEF4CE68").IsUnique();

            entity.Property(e => e.Ecity)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ECity");
            entity.Property(e => e.Edescription)
                .HasMaxLength(3000)
                .HasColumnName("EDescription");
            entity.Property(e => e.EventDate).HasColumnType("date");
            entity.Property(e => e.Eyear).HasColumnName("EYear");
            entity.Property(e => e.TiteleEvent)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PeopleId).HasName("PK__People__2B24391C3B8A9B2E");

            entity.HasIndex(e => e.PeopleName, "UQ__People__2DC9F30E0FD0D2F5").IsUnique();

            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.DeathDate).HasColumnType("date");
            entity.Property(e => e.PeopleName)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PeopleRole)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
