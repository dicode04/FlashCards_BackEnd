using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities;

public partial class FlashcardsDbContext : DbContext
{
    public FlashcardsDbContext(DbContextOptions<FlashcardsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FlashCard> FlashCards { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FlashCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FlashCar__3213E83FF528C095");

            entity.ToTable("FlashCard");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answer)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("answer");
            entity.Property(e => e.Question)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("question");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
