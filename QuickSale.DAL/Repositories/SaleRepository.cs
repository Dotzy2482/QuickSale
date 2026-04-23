using Microsoft.EntityFrameworkCore;
using QuickSale.DAL.Interfaces;
using QuickSale.DAL.Models;

namespace QuickSale.DAL.Repositories;

public class SaleRepository : Repository<Sale>, ISaleRepository
{
    public SaleRepository(AppDbContext context) : base(context) { }

    /// <summary>Returns all sales that fall on the given calendar date.</summary>
    public IEnumerable<Sale> GetSalesByDate(DateTime date)
    {
        var start = date.Date;
        var end = start.AddDays(1);

        return _context.Sales
            .Where(s => s.Date >= start && s.Date < end)
            .OrderBy(s => s.Date)
            .ToList();
    }

    /// <summary>Returns all sales for a customer, newest first.</summary>
    public IEnumerable<Sale> GetSalesByCustomer(int customerId)
        => _context.Sales
            .Include(s => s.SaleItems)
                .ThenInclude(si => si.Product)
            .Where(s => s.CustomerId == customerId)
            .OrderByDescending(s => s.Date)
            .ToList();

    /// <summary>Returns full sale details (customer, cashier, items) for a given day — used in daily reports.</summary>
    public IEnumerable<Sale> GetDailySales(DateTime date)
    {
        var start = date.Date;
        var end = start.AddDays(1);

        return _context.Sales
            .Include(s => s.Customer)
            .Include(s => s.User)
            .Include(s => s.SaleItems)
                .ThenInclude(si => si.Product)
            .Where(s => s.Date >= start && s.Date < end)
            .OrderBy(s => s.Date)
            .ToList();
    }
}
