using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace WebApp.Models;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    //public virtual DbSet<HakkimizdaBilgileri> HakkimizdaBilgileri { get; set; }

    public virtual DbSet<Kategori> Kategori { get; set; }
    public virtual DbSet<Urun> Urun { get; set; }

    public virtual DbSet<IletisimBilgileri> IletisimBilgileri { get; set; }
















    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Waffle_DB;Trusted_Connection=True;TrustServerCertificate=True;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {






        //modelBuilder.Entity<HakkimizdaBilgileri>(entity =>
        //{
        //    entity.ToTable("HakkimizdaBilgileri");
        //    entity.Property(e => e.EklenmeTarihi).HasColumnType("datetime");
        //    entity.Property(e => e.GuncellenmeTarihi).HasColumnType("datetime");
        //});




        modelBuilder.Entity<IletisimBilgileri>(entity =>
        {
            entity.ToTable("IletisimBilgileri");
            entity.Property(e => e.BankaAdi).HasMaxLength(50);
            entity.Property(e => e.Email1)
                .HasMaxLength(255)
                .HasColumnName("EMail1");
            entity.Property(e => e.Email2)
                .HasMaxLength(50)
                .HasColumnName("EMail2");
            entity.Property(e => e.Faks).HasMaxLength(50);
            entity.Property(e => e.IbanNo).HasMaxLength(50);
            entity.Property(e => e.Telefon1)
                .HasMaxLength(50)
                .HasColumnName("Telefon1");
            entity.Property(e => e.Telefon2)
                .HasMaxLength(50)
                .HasColumnName("Telefon2");
            entity.Property(e => e.Telefon3)
                .HasMaxLength(50)
                .HasColumnName("Telefon3");
            entity.Property(e => e.Telefon4)
                .HasMaxLength(50)
                .HasColumnName("Telefon4");
            entity.Property(e => e.WhatsApp).HasMaxLength(50);
        });

        modelBuilder.Entity<IletisimFotograf>(entity =>
        {
            entity.ToTable("IletisimFotograf");
            entity.Property(e => e.EklenmeTarihi).HasColumnType("datetime");
            entity.Property(e => e.GuncellenmeTarihi).HasColumnType("datetime");
        });









        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
