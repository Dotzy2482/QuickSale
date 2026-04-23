using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickSale.DAL.Models;

public class Sale
{
    [Key]
    public int SaleId { get; set; }

    public int CustomerId { get; set; }

    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; set; } = null!;

    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public User User { get; set; } = null!;

    public DateTime Date { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Total { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Discount { get; set; }

    [Required]
    [MaxLength(50)]
    public string PaymentType { get; set; } = string.Empty;

    public ICollection<SaleItem> SaleItems { get; set; } = new List<SaleItem>();
    public Invoice? Invoice { get; set; }
}
