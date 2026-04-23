using QuickSale.DAL.Models;

namespace QuickSale.DAL.Interfaces;

public interface IProductRepository : IRepository<Product>
{
    IEnumerable<Product> GetByCategory(int categoryId);
    IEnumerable<Product> SearchByName(string name);
    void UpdateStock(int productId, int quantity);
}
