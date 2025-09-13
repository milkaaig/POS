using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using POS.web.Models;


namespace POS.web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<SalesItems> SalesItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Category
            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Product
            modelBuilder.Entity<Product>()
                .Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.Quantity)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.ExpiryDate)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Stock
            modelBuilder.Entity<Stock>()
                .Property(s => s.Quantity)
                .IsRequired();

            modelBuilder.Entity<Stock>()
                .Property(s => s.StockedIn)
                .IsRequired();

            modelBuilder.Entity<Stock>()
                .HasOne(s => s.Product)
                .WithMany(p => p.Stocks)
                .HasForeignKey(s => s.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            // Employees
            modelBuilder.Entity<Employees>()
                .Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Employees>()
                .Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Employees>()
                .HasOne(e => e.Role)
                .WithMany(r => r.Employees)
                .HasForeignKey(e => e.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            // Role
            modelBuilder.Entity<Role>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Shop
            modelBuilder.Entity<Shop>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            // SalesItems
            modelBuilder.Entity<SalesItems>()
                .Property(s => s.SaleDate)
                .IsRequired();

            modelBuilder.Entity<SalesItems>()
                .Property(s => s.Quantity)
                .IsRequired();

            modelBuilder.Entity<SalesItems>()
                .Property(s => s.UnitPrice)
                .IsRequired();

            modelBuilder.Entity<SalesItems>()
                .Property(s => s.TotalPrice)
                .IsRequired();

            modelBuilder.Entity<SalesItems>()
                .HasOne(s => s.Product)
                .WithMany()
                .HasForeignKey(s => s.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SalesItems>()
                .HasOne(s => s.Employee)
                .WithMany()
                .HasForeignKey(s => s.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
    
}
