using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NqdLesson11.Models;

public partial class NguyenQuocDuy2310900030Context : DbContext
{
    public NguyenQuocDuy2310900030Context()
    {
    }

    public NguyenQuocDuy2310900030Context(DbContextOptions<NguyenQuocDuy2310900030Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DUYNGUYEN\\DUYNGUYEN;\nDatabase=NguyenQuocDuy_2310900030;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.NqdEmpId);

            entity.ToTable("Category");

            entity.Property(e => e.NqdEmpId)
                .ValueGeneratedNever()
                .HasColumnName("nqdEmpId");
            entity.Property(e => e.NqdEmpLevel)
                .HasMaxLength(50)
                .HasColumnName("nqdEmpLevel");
            entity.Property(e => e.NqdEmpName)
                .HasMaxLength(150)
                .HasColumnName("nqdEmpName");
            entity.Property(e => e.NqdEmpStartDate).HasColumnName("nqdEmpStartDate");
            entity.Property(e => e.NqdEmpStatus).HasColumnName("nqdEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
