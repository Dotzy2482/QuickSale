using QuickSale.DAL.Interfaces;
using QuickSale.DAL.Models;

namespace QuickSale.BLL.Managers;

public class ProductManager
{
    private readonly IProductRepository _productRepo;

    public ProductManager(IProductRepository productRepo)
    {
        _productRepo = productRepo;
    }

    public void AddProduct(string name, decimal price, int stock, int categoryId)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Product name cannot be empty.", nameof(name));
        if (price < 0)
            throw new ArgumentException("Price cannot be negative.", nameof(price));
        if (stock < 0)
            throw new ArgumentException("Stock cannot be negative.", nameof(stock));

        _productRepo.Add(new Product
        {
            Name = name.Trim(),
            Price = price,
            Stock = stock,
            CategoryId = categoryId
        });
        _productRepo.Save();
    }

    public void UpdateProduct(int id, string name, decimal price, int stock, int categoryId)
    {
        var product = _productRepo.GetById(id)
            ?? throw new KeyNotFoundException($"Product with ID {id} not found.");

        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Product name cannot be empty.", nameof(name));
        if (price < 0)
            throw new ArgumentException("Price cannot be negative.", nameof(price));
        if (stock < 0)
            throw new ArgumentException("Stock cannot be negative.", nameof(stock));

        product.Name       = name.Trim();
        product.Price      = price;
        product.Stock      = stock;
        product.CategoryId = categoryId;

        _productRepo.Update(product);
        _productRepo.Save();
    }

    public void DeleteProduct(int id)
    {
        _ = _productRepo.GetById(id)
            ?? throw new KeyNotFoundException($"Product with ID {id} not found.");

        _productRepo.Delete(id);
        _productRepo.Save();
    }

    public List<Product> GetAllProducts()
        => _productRepo.GetAll().ToList();

    public List<Product> SearchProducts(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
            return GetAllProducts();

        return _productRepo.SearchByName(keyword.Trim()).ToList();
    }

    public List<Product> GetLowStockProducts(int threshold = 5)
    {
        if (threshold < 0)
            throw new ArgumentException("Threshold cannot be negative.", nameof(threshold));

        return _productRepo.GetAll()
            .Where(p => p.Stock <= threshold)
            .OrderBy(p => p.Stock)
            .ToList();
    }
}
