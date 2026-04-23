using QuickSale.DAL.Models;

namespace QuickSale.DAL.Interfaces;

public interface IUserRepository : IRepository<User>
{
    User? GetByUsername(string username);
    bool ValidateUser(string username, string passwordHash);
}
