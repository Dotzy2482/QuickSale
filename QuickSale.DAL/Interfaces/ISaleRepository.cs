using QuickSale.DAL.Models;

namespace QuickSale.DAL.Interfaces;

public interface ISaleRepository : IRepository<Sale>
{
    IEnumerable<Sale> GetSalesByDate(DateTime date);
    IEnumerable<Sale> GetSalesByCustomer(int customerId);
    IEnumerable<Sale> GetDailySales(DateTime date);
}
