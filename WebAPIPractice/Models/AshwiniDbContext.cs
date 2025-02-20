using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPIPractice.Models;

public partial class AshwiniDbContext : DbContext
{
    public AshwiniDbContext()
    {
    }

    public AshwiniDbContext(DbContextOptions<AshwiniDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmpTable> EmpTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmpTable>(entity =>
        {
            entity.ToTable("Emp_Table");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EmpType).HasColumnName("Emp_Type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
