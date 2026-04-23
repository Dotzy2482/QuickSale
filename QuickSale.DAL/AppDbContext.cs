using Microsoft.EntityFrameworkCore;
using QuickSale.DAL.Models;
using System.Security.Cryptography;
using System.Text;

namespace QuickSale.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SaleItems { get; set; }
    public DbSet<Invoice> Invoices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=quicksale.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // ── Relationships & cascade behaviour ────────────────────────────────

        // Category → Products: restrict (must delete/re-assign products first)
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        // Customer → Sales: restrict (preserve sales history)
        modelBuilder.Entity<Sale>()
            .HasOne(s => s.Customer)
            .WithMany(c => c.Sales)
            .HasForeignKey(s => s.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        // User → Sales: restrict (preserve sales history)
        modelBuilder.Entity<Sale>()
            .HasOne(s => s.User)
            .WithMany(u => u.Sales)
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        // Sale → SaleItems: cascade (remove line items when sale deleted)
        modelBuilder.Entity<SaleItem>()
            .HasOne(si => si.Sale)
            .WithMany(s => s.SaleItems)
            .HasForeignKey(si => si.SaleId)
            .OnDelete(DeleteBehavior.Cascade);

        // Product → SaleItems: restrict (can't delete product with existing sales)
        modelBuilder.Entity<SaleItem>()
            .HasOne(si => si.Product)
            .WithMany(p => p.SaleItems)
            .HasForeignKey(si => si.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        // Sale → Invoice: cascade (invoice is owned by the sale)
        modelBuilder.Entity<Invoice>()
            .HasOne(i => i.Sale)
            .WithOne(s => s.Invoice)
            .HasForeignKey<Invoice>(i => i.SaleId)
            .OnDelete(DeleteBehavior.Cascade);

        // ── Seed data ─────────────────────────────────────────────────────────

        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Electronics" },
            new Category { CategoryId = 2, Name = "Food & Beverage" }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, Name = "Laptop",       Price = 999.99m, Stock = 10, CategoryId = 1 },
            new Product { ProductId = 2, Name = "USB Cable",    Price =   9.99m, Stock = 50, CategoryId = 1 },
            new Product { ProductId = 3, Name = "Headphones",   Price =  49.99m, Stock = 20, CategoryId = 1 },
            new Product { ProductId = 4, Name = "Coffee",       Price =   3.99m, Stock = 100, CategoryId = 2 },
            new Product { ProductId = 5, Name = "Sandwich",     Price =   5.99m, Stock = 30, CategoryId = 2 }
        );

        modelBuilder.Entity<User>().HasData(
            new User { UserId = 1, Username = "admin",   PasswordHash = ComputeSha256("admin123"),   Role = "Admin"   },
            new User { UserId = 2, Username = "cashier", PasswordHash = ComputeSha256("cashier123"), Role = "Cashier" }
        );

        modelBuilder.Entity<Customer>().HasData(
            new Customer { CustomerId = 1, Name = "Walk-in Customer", Phone = "", Email = "" }
        );
    }

    private static string ComputeSha256(string input)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));
        return Convert.ToHexString(bytes).ToLower();
    }
}
