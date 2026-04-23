using System.Drawing.Printing;
using QuickSale.DAL.Models;

namespace _20240305307_QuickSale;

public partial class frmInvoice : Form
{
    private readonly Sale        _sale;
    private readonly PrintDocument _printDoc = new();

    public frmInvoice(Sale sale)
    {
        InitializeComponent();
        _sale = sale;
        _printDoc.PrintPage += PrintDoc_PrintPage;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        SetupGrid();
        PopulateInvoice();
    }

    // ── Grid setup ────────────────────────────────────────────────────────────

    private void SetupGrid()
    {
        dgvItems.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colProduct", HeaderText = "Product",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 50
        });
        dgvItems.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colQty", HeaderText = "Qty", Width = 65,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
        dgvItems.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colUnit", HeaderText = "Unit Price", Width = 110,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "C2" }
        });
        dgvItems.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colSubtotal", HeaderText = "Subtotal", Width = 110,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "C2" }
        });
    }

    // ── Populate ──────────────────────────────────────────────────────────────

    private void PopulateInvoice()
    {
        lblSaleId.Text   = $"Invoice #{_sale.SaleId}";
        lblDate.Text     = _sale.Date.ToString("dddd, MMMM d, yyyy  h:mm tt");
        lblCustomer.Text = _sale.Customer?.Name ?? "—";
        lblCashier.Text  = _sale.User?.Username ?? "—";
        lblPayment.Text  = _sale.PaymentType;

        dgvItems.Rows.Clear();
        foreach (var item in _sale.SaleItems)
        {
            string productName = item.Product?.Name ?? $"Product #{item.ProductId}";
            dgvItems.Rows.Add(productName, item.Quantity, item.UnitPrice, item.UnitPrice * item.Quantity);
        }

        decimal subtotal = _sale.Total + _sale.Discount;
        lblSubtotal.Text = subtotal.ToString("C2");
        lblDiscount.Text = _sale.Discount > 0 ? $"- {_sale.Discount:C2}" : "—";
        lblTotal.Text    = _sale.Total.ToString("C2");
    }

    // ── Print ─────────────────────────────────────────────────────────────────

    private void btnPrint_Click(object sender, EventArgs e)
    {
        using var dlg = new PrintDialog { Document = _printDoc };
        if (dlg.ShowDialog(this) == DialogResult.OK)
            _printDoc.Print();
    }

    private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
    {
        var g         = e.Graphics!;
        float left    = 50f;
        float right   = e.PageBounds.Width - 50f;
        float width   = right - left;
        float y       = 40f;
        float lh      = 20f;

        using var fontTitle   = new Font("Segoe UI", 18, FontStyle.Bold);
        using var fontBold    = new Font("Segoe UI", 9,  FontStyle.Bold);
        using var fontNormal  = new Font("Segoe UI", 9,  FontStyle.Regular);
        using var fontTotal   = new Font("Segoe UI", 11, FontStyle.Bold);

        var black = Brushes.Black;
        var grey  = Brushes.Gray;

        // ── Title ─────────────────────────────────────────────────────────────
        var titleSz = g.MeasureString("QuickSale", fontTitle);
        g.DrawString("QuickSale", fontTitle, black, left + (width - titleSz.Width) / 2f, y);
        y += titleSz.Height + 2;

        var subSz = g.MeasureString("INVOICE RECEIPT", fontBold);
        g.DrawString("INVOICE RECEIPT", fontBold, grey, left + (width - subSz.Width) / 2f, y);
        y += subSz.Height + 12;

        // ── Header info ───────────────────────────────────────────────────────
        g.DrawLine(Pens.Black, left, y, right, y); y += 6;
        g.DrawString($"Invoice No: #{_sale.SaleId}", fontBold, black, left, y);
        g.DrawString($"Date: {_sale.Date:dd/MM/yyyy HH:mm}", fontNormal, black, left + width / 2f, y);
        y += lh;
        g.DrawString($"Customer: {_sale.Customer?.Name ?? "—"}", fontNormal, black, left, y);
        g.DrawString($"Cashier: {_sale.User?.Username ?? "—"}", fontNormal, black, left + width / 2f, y);
        y += lh;
        g.DrawString($"Payment: {_sale.PaymentType}", fontNormal, black, left, y);
        y += lh + 4;
        g.DrawLine(Pens.Black, left, y, right, y); y += 6;

        // ── Column headers ────────────────────────────────────────────────────
        g.DrawString("Product",    fontBold, black, left,           y);
        g.DrawString("Qty",        fontBold, black, left + 230,     y);
        g.DrawString("Unit Price", fontBold, black, left + 275,     y);
        g.DrawString("Subtotal",   fontBold, black, right - 65,     y);
        y += lh;
        g.DrawLine(Pens.DarkGray, left, y, right, y); y += 4;

        // ── Items ─────────────────────────────────────────────────────────────
        foreach (var item in _sale.SaleItems)
        {
            string name = item.Product?.Name ?? $"#{item.ProductId}";
            if (name.Length > 28) name = name[..28];
            decimal lineTotal = item.UnitPrice * item.Quantity;

            g.DrawString(name,                         fontNormal, black, left,       y);
            g.DrawString(item.Quantity.ToString(),     fontNormal, black, left + 230, y);
            g.DrawString(item.UnitPrice.ToString("C2"),fontNormal, black, left + 275, y);
            g.DrawString(lineTotal.ToString("C2"),     fontNormal, black, right - 65, y);
            y += lh;
        }

        y += 4;
        g.DrawLine(Pens.Black, left, y, right, y); y += 8;

        // ── Totals ────────────────────────────────────────────────────────────
        decimal subtotal = _sale.Total + _sale.Discount;
        g.DrawString("Subtotal:",  fontBold,   black, left + 250, y);
        g.DrawString(subtotal.ToString("C2"), fontNormal, black, right - 65, y); y += lh;

        if (_sale.Discount > 0)
        {
            g.DrawString("Discount:", fontBold, black, left + 250, y);
            g.DrawString($"- {_sale.Discount:C2}", fontNormal, black, right - 65, y); y += lh;
        }

        g.DrawLine(Pens.Black, left + 245, y, right, y); y += 4;
        g.DrawString("TOTAL:", fontTotal, black, left + 250, y);
        g.DrawString(_sale.Total.ToString("C2"), fontTotal, black, right - 65, y);
        y += fontTotal.Height + 16;

        // ── Footer ────────────────────────────────────────────────────────────
        g.DrawLine(Pens.LightGray, left, y, right, y); y += 8;
        var thanks = "Thank you for your purchase!";
        var thanksSz = g.MeasureString(thanks, fontNormal);
        g.DrawString(thanks, fontNormal, grey, left + (width - thanksSz.Width) / 2f, y);

        e.HasMorePages = false;
    }

    // ── Close ─────────────────────────────────────────────────────────────────

    private void btnClose_Click(object sender, EventArgs e) => Close();
}
