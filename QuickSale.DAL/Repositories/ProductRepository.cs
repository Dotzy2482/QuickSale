using Microsoft.EntityFrameworkCore;
using QuickSale.DAL.Interfaces;
using QuickSale.DAL.Models;

namespace QuickSale.DAL.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context) { }

    public IEnumerable<Product> GetByCategory(int categoryId)
        => _context.Products
            .Include(p => p.Category)
            .Where(p => p.CategoryId == categoryId)
            .OrderBy(p => p.Name)
            .ToList();

    public IEnumerable<Product> SearchByName(string name)
        => _context.Products
            .Include(p => p.Category)
            .Where(p => p.Name.Contains(name))   // SQLite LIKE — case-insensitive for ASCII
            .OrderBy(p => p.Name)
            .ToList();

    public void UpdateStock(int productId, int quantity)
    {
        var product = _dbSet.Find(productId);
        if (product is null) return;

        product.Stock = quantity;
        _context.SaveChanges();
    }
}
