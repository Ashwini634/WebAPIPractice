//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace WebAPIPractice.Models;

//public partial class SurveyDatabaseContext : DbContext
//{
//    public SurveyDatabaseContext()
//    {
//    }

//    public SurveyDatabaseContext(DbContextOptions<SurveyDatabaseContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<EmpTable> EmpTables { get; set; }

//    public virtual DbSet<Student12> Student12s { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-VMPVC8G\\SQLEXPRESS;Database=SurveyDatabase;Trusted_Connection=True;TrustServerCertificate=true;");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<EmpTable>(entity =>
//        {
//            entity.ToTable("Emp_table");

//            entity.Property(e => e.Id)
//                .ValueGeneratedNever()
//                .HasColumnName("ID");
//            entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");
//        });

//        modelBuilder.Entity<Student12>(entity =>
//        {
//            entity
//                .HasNoKey()
//                .ToTable("Student12");

//            entity.Property(e => e.Id).HasColumnName("ID");
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
