using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<TblProduct> TblProduct { get; set; }
    public DbSet<TblCategory> TblCategory { get; set; }

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
