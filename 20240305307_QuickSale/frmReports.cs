using QuickSale.BLL.Managers;
using QuickSale.DAL;
using QuickSale.DAL.Models;
using QuickSale.DAL.Repositories;

namespace _20240305307_QuickSale;

public partial class frmReports : Form
{
    private readonly SaleManager _saleManager;
    private List<Sale> _dailySales = new();

    public frmReports()
    {
        InitializeComponent();
        var ctx      = new AppDbContext();
        _saleManager = new SaleManager(ctx, new SaleRepository(ctx), new ProductRepository(ctx));
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        SetupGrid();
        dtpDate.Value = DateTime.Today;
    }

    // ── Grid setup ────────────────────────────────────────────────────────────

    private void SetupGrid()
    {
        dgvSales.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colSaleId", HeaderText = "Sale #", Width = 70,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
        dgvSales.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCustomer", HeaderText = "Customer",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 40
        });
        dgvSales.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colTime", HeaderText = "Time", Width = 80,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
        dgvSales.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colTotal", HeaderText = "Total", Width = 100,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "C2" }
        });
        dgvSales.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colPayment", HeaderText = "Payment", Width = 90,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
    }

    // ── Load report ───────────────────────────────────────────────────────────

    private void btnLoad_Click(object sender, EventArgs e)
    {
        try
        {
            var date = dtpDate.Value.Date;

            var (revenue, count) = _saleManager.GetDailySummary(date);
            lblRevenue.Text      = revenue.ToString("C2");
            lblTransactions.Text = count.ToString();

            _dailySales = _saleManager.GetDailySales(date).ToList();

            dgvSales.SuspendLayout();
            dgvSales.Rows.Clear();

            foreach (var sale in _dailySales)
            {
                dgvSales.Rows.Add(
                    sale.SaleId,
                    sale.Customer?.Name ?? "—",
                    sale.Date.ToString("HH:mm"),
                    sale.Total,
                    sale.PaymentType);
            }

            dgvSales.ResumeLayout();
            lblNoData.Visible      = _dailySales.Count == 0;
            btnViewDetails.Enabled = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load report:\n{ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ── View details ──────────────────────────────────────────────────────────

    private void btnViewDetails_Click(object sender, EventArgs e)
    {
        if (dgvSales.SelectedRows.Count == 0) return;

        int saleId = Convert.ToInt32(dgvSales.SelectedRows[0].Cells["colSaleId"].Value);
        var sale   = _dailySales.FirstOrDefault(s => s.SaleId == saleId);
        if (sale is null) return;

        using var inv = new frmInvoice(sale);
        inv.ShowDialog(this);
    }

    // ── Events ────────────────────────────────────────────────────────────────

    private void dgvSales_SelectionChanged(object sender, EventArgs e)
        => btnViewDetails.Enabled = dgvSales.SelectedRows.Count > 0;

    private void dgvSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) btnViewDetails_Click(sender, e);
    }
}
