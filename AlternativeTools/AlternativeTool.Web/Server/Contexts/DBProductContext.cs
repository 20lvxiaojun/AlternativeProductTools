using AlternativeTool.Web.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlternativeTool.Web.Server.Contexts
{
    public class DBProductContext:DbContext
    {
        public DBProductContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("T_Product");
            modelBuilder.Entity<Product>().HasMany(c=>c.CompetitiveProducts).WithMany(p=>p.Products)
                                            .UsingEntity(m =>m.ToTable("T_CPP"));
            modelBuilder.Entity<CompetitiveProduct>().ToTable("T_CompetitiveProduct");
            //modelBuilder.Entity<CompetitiveProductProduct>().HasKey(p => new { p.ProductId, p.CompetitiveId });
            //modelBuilder.Entity<Product>().HasMany<CompetitiveProduct>();
            //modelBuilder.Entity<CompetitiveProduct>().HasMany<Product>();
        }
        public  DbSet<Product> Products { get; set; }
        public DbSet<CompetitiveProduct> CompetitiveProducts { get; set; }
    }
}
