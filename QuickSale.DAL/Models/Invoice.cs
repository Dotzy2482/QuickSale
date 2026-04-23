using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickSale.DAL.Models;

[Index(nameof(SaleId), IsUnique = true)]
public class Invoice
{
    [Key]
    public int InvoiceId { get; set; }

    public int SaleId { get; set; }

    [ForeignKey(nameof(SaleId))]
    public Sale Sale { get; set; } = null!;

    public DateTime Date { get; set; }
}
