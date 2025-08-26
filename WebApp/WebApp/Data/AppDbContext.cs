using Microsoft.EntityFrameworkCore;



public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<TblProduct> TblProduct { get; set; }
    public DbSet<TblCategory> TblCategory { get; set; }

    //public DbSet<TblSocials> TblSocials { get; set; }
    //public DbSet<TblBusiness> TblBusiness { get; set; }
    //public DbSet<TblMenus> TblMenus { get; set; }
    //public DbSet<TblAddress> TblAddress { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblProduct>()
            .HasKey(p => p.ProductId);

        modelBuilder.Entity<TblCategory>()
            .HasKey(c => c.CategoryId);

        modelBuilder.Entity<TblProduct>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);
    }
}
