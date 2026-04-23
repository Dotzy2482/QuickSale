using QuickSale.DAL.Models;

namespace QuickSale.DAL.Interfaces;

public interface IUserRepository : IRepository<User>
{
    User? GetByUsername(string username);
    bool ValidateUser(string username, string passwordHash);
    Task<User?> GetByUsernameAsync(string username);
    Task<bool> ValidateUserAsync(string username, string passwordHash);
}
