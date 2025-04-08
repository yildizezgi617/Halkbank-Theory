using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _26_DBFirst;

public partial class DbRehberContext : DbContext
{
    public DbRehberContext()
    {
    }

    public DbRehberContext(DbContextOptions<DbRehberContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TelefonRehberi> TelefonRehberis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbRehber;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TelefonRehberi>(entity =>
        {
            entity.HasKey(e => e.KisiId).HasName("PK__TelefonR__110EDCE945FB25DC");

            entity.ToTable("TelefonRehberi");

            entity.Property(e => e.KisiAd).HasMaxLength(50);
            entity.Property(e => e.KisiSoyadi).HasMaxLength(50);
            entity.Property(e => e.KisiTelefon).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
