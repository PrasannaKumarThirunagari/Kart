using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyVillageKartAPI.EntityModels;

namespace MyVillageKartAPI.Data;

public partial class KartContext : DbContext
{
    public KartContext()
    {
    }

    public KartContext(DbContextOptions<KartContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserDetail> UserDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("SERVER=SAHASRATHIRUNAG;DATABASE=Kart;Integrated Security=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserDetail>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("UserID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Mobile2)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
