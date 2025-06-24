using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NqdLesson10.Models;

public partial class NqdK23cnt2Lesson10Context : DbContext
{
    public NqdK23cnt2Lesson10Context()
    {
    }

    public NqdK23cnt2Lesson10Context(DbContextOptions<NqdK23cnt2Lesson10Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NqdCategory> NqdCategories { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DUYNGUYEN\\DUYNGUYEN;Database=NqdK23cnt2Lesson10;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NqdCategory>(entity =>
        {
            entity.HasKey(e => e.CateId);

            entity.ToTable("NqdCategory");

            entity.Property(e => e.CateId).HasColumnName("CateID");
            entity.Property(e => e.CateName).HasMaxLength(150);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
