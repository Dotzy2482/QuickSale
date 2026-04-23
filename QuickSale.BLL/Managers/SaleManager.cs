using QuickSale.DAL;
using QuickSale.DAL.Interfaces;
using QuickSale.DAL.Models;

namespace QuickSale.BLL.Managers;

public class SaleManager
{
    private readonly AppDbContext _context;
    private readonly ISaleRepository _saleRepo;
    private readonly IProductRepository _productRepo;

    public SaleManager(AppDbContext context, ISaleRepository saleRepo, IProductRepository productRepo)
    {
        _context = context;
        _saleRepo = saleRepo;
        _productRepo = productRepo;
    }

    /// <summary>
    /// Creates a complete sale: validates stock, builds SaleItems, deducts stock,
    /// and generates the Invoice — all inside a single database transaction.
    /// </summary>
    public Sale CreateSale(
        int customerId,
        int userId,
        List<(int productId, int quantity)> items,
        decimal discount,
        string paymentType)
    {
        if (items is null || items.Count == 0)
            throw new ArgumentException("Sale must contain at least one item.", nameof(items));
        if (discount < 0)
            throw new ArgumentException("Discount cannot be negative.", nameof(discount));
        if (string.IsNullOrWhiteSpace(paymentType))
            throw new ArgumentException("Payment type is required.", nameof(paymentType));

        using var transaction = _context.Database.BeginTransaction();
        try
        {
            // --- Validate stock and build sale items ---
            decimal subtotal = 0;
            var saleItems = new List<SaleItem>();

            foreach (var (productId, quantity) in items)
            {
                if (quantity <= 0)
                    throw new ArgumentException($"Quantity for product ID {productId} must be greater than zero.");

                var product = _productRepo.GetById(productId)
                    ?? throw new KeyNotFoundException($"Product with ID {productId} not found.");

                if (product.Stock < quantity)
                    throw new InvalidOperationException(
                        $"Insufficient stock for '{product.Name}'. Available: {product.Stock}, requested: {quantity}.");

                subtotal += product.Price * quantity;
                saleItems.Add(new SaleItem
                {
                    ProductId = productId,
                    Quantity = quantity,
                    UnitPrice = product.Price
                });
            }

            var total = subtotal - discount;
            if (total < 0)
                throw new InvalidOperationException("Discount cannot exceed the sale subtotal.");

            // --- Persist sale with items ---
            var sale = new Sale
            {
                CustomerId = customerId,
                UserId = userId,
                Date = DateTime.Now,
                Total = total,
                Discount = discount,
                PaymentType = paymentType.Trim(),
                SaleItems = saleItems
            };

            _context.Sales.Add(sale);
            _context.SaveChanges(); // materialises SaleId

            // --- Deduct stock ---
            foreach (var (productId, quantity) in items)
            {
                var product = _productRepo.GetById(productId)!;
                product.Stock -= quantity;
                _context.Products.Update(product);
            }

            // --- Generate invoice ---
            _context.Invoices.Add(new Invoice
            {
                SaleId = sale.SaleId,
                Date = sale.Date
            });

            _context.SaveChanges();
            transaction.Commit();

            return sale;
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

    /// <summary>Returns total revenue and transaction count for a given day.</summary>
    public (decimal totalRevenue, int transactionCount) GetDailySummary(DateTime date)
    {
        var sales = _saleRepo.GetSalesByDate(date).ToList();
        return (sales.Sum(s => s.Total), sales.Count);
    }

    /// <summary>Returns full sale details for a given day (customer, cashier, items, products).</summary>
    public IEnumerable<Sale> GetDailySales(DateTime date)
        => _saleRepo.GetDailySales(date);
}
