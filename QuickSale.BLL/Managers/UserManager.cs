using System.Security.Cryptography;
using System.Text;
using QuickSale.DAL.Interfaces;
using QuickSale.DAL.Models;

namespace QuickSale.BLL.Managers;

public class UserManager
{
    private readonly IUserRepository _userRepo;

    public UserManager(IUserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    /// <summary>
    /// Hashes the raw password and validates against the stored hash.
    /// Returns the matching User, or null if credentials are wrong.
    /// </summary>
    public User? Login(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            return null;

        var hash = HashPassword(password);
        return _userRepo.ValidateUser(username, hash)
            ? _userRepo.GetByUsername(username)
            : null;
    }

    public List<User> GetAllUsers()
        => _userRepo.GetAll().ToList();

    public void AddUser(string username, string password, string role)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Username cannot be empty.", nameof(username));
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password cannot be empty.", nameof(password));
        if (role != "Admin" && role != "Cashier")
            throw new ArgumentException("Role must be 'Admin' or 'Cashier'.", nameof(role));

        if (_userRepo.GetByUsername(username) is not null)
            throw new InvalidOperationException($"Username '{username}' is already taken.");

        _userRepo.Add(new User
        {
            Username = username.Trim(),
            PasswordHash = HashPassword(password),
            Role = role
        });
        _userRepo.Save();
    }

    /// <summary>
    /// Updates username and role. If newPassword is non-empty, the password is also changed.
    /// </summary>
    public void UpdateUser(int id, string username, string? newPassword, string role)
    {
        var user = _userRepo.GetById(id)
            ?? throw new KeyNotFoundException($"User with ID {id} not found.");

        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Username cannot be empty.", nameof(username));
        if (role != "Admin" && role != "Cashier")
            throw new ArgumentException("Role must be 'Admin' or 'Cashier'.", nameof(role));

        var existing = _userRepo.GetByUsername(username.Trim());
        if (existing is not null && existing.UserId != id)
            throw new InvalidOperationException($"Username '{username}' is already taken.");

        user.Username = username.Trim();
        user.Role     = role;

        if (!string.IsNullOrWhiteSpace(newPassword))
            user.PasswordHash = HashPassword(newPassword);

        _userRepo.Update(user);
        _userRepo.Save();
    }

    public void DeleteUser(int id)
    {
        _ = _userRepo.GetById(id)
            ?? throw new KeyNotFoundException($"User with ID {id} not found.");

        _userRepo.Delete(id);
        _userRepo.Save();
    }

    private static string HashPassword(string password)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
        return Convert.ToHexString(bytes).ToLower();
    }
}
