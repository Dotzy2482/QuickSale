using System.ComponentModel.DataAnnotations;

namespace QuickSale.DAL.Models;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    /// <summary>"Admin" or "Cashier"</summary>
    [Required]
    [MaxLength(10)]
    public string Role { get; set; } = string.Empty;

    public ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
