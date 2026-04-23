using QuickSale.DAL.Interfaces;
using QuickSale.DAL.Models;

namespace QuickSale.DAL.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context) { }

    public User? GetByUsername(string username)
        => _context.Users
            .FirstOrDefault(u => u.Username == username);

    /// <summary>
    /// Returns true when both username and the pre-hashed password match a stored record.
    /// The caller is responsible for hashing the raw password before calling this method.
    /// </summary>
    public bool ValidateUser(string username, string passwordHash)
        => _context.Users
            .Any(u => u.Username == username && u.PasswordHash == passwordHash);
}
