using QuickSale.BLL.Managers;
using QuickSale.DAL;
using QuickSale.DAL.Models;
using QuickSale.DAL.Repositories;

namespace _20240305307_QuickSale;

public partial class frmProducts : Form
{
    private readonly ProductManager       _productManager;
    private readonly Repository<Category> _categoryRepo;
    private List<Product> _allProducts = new();

    private const int LowStockThreshold = 5;

    private static readonly Color LowStockBack    = Color.FromArgb(254, 226, 226);
    private static readonly Color LowStockFore    = Color.FromArgb(185, 28,  28);
    private static readonly Color LowStockSel     = Color.FromArgb(252, 165, 165);
    private static readonly Color RowNormalBack   = Color.White;
    private static readonly Color RowNormalFore   = Color.FromArgb(30,  41,  59);
    private static readonly Color RowSelBack      = Color.FromArgb(219, 234, 254);
    private static readonly Color RowSelFore      = Color.FromArgb(30,  64,  175);

    public frmProducts()
    {
        InitializeComponent();
        var ctx         = new AppDbContext();
        _productManager = new ProductManager(new ProductRepository(ctx));
        _categoryRepo   = new Repository<Category>(ctx);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        SetupGrid();
        ApplyRolePermissions();
        LoadProducts();
    }

    // ── DataGridView column definition ───────────────────────────────────────

    private void SetupGrid()
    {
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colId", HeaderText = "ID", Width = 58,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colName", HeaderText = "Product Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 50
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCategory", HeaderText = "Category",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 25
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colPrice", HeaderText = "Price", Width = 110,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "C2" }
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colStock", HeaderText = "Stock", Width = 80,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
    }

    // ── Data ─────────────────────────────────────────────────────────────────

    private void LoadProducts()
    {
        try
        {
            _allProducts = _productManager.GetAllProducts();
            ApplyFilter(txtSearch.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load products:\n{ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ApplyFilter(string keyword)
    {
        var list = string.IsNullOrWhiteSpace(keyword)
            ? _allProducts
            : _allProducts
                .Where(p => p.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                         || (p.Category?.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ?? false))
                .ToList();

        PopulateGrid(list);
    }

    private void PopulateGrid(List<Product> products)
    {
        dgvProducts.SuspendLayout();
        dgvProducts.Rows.Clear();

        foreach (var p in products)
        {
            int idx = dgvProducts.Rows.Add(p.ProductId, p.Name, p.Category?.Name ?? "—", p.Price, p.Stock);
            var row = dgvProducts.Rows[idx];

            if (p.Stock < LowStockThreshold)
            {
                row.DefaultCellStyle.BackColor          = LowStockBack;
                row.DefaultCellStyle.ForeColor          = LowStockFore;
                row.DefaultCellStyle.SelectionBackColor = LowStockSel;
                row.DefaultCellStyle.SelectionForeColor = LowStockFore;
            }
            else
            {
                row.DefaultCellStyle.BackColor          = RowNormalBack;
                row.DefaultCellStyle.ForeColor          = RowNormalFore;
                row.DefaultCellStyle.SelectionBackColor = RowSelBack;
                row.DefaultCellStyle.SelectionForeColor = RowSelFore;
            }
        }

        dgvProducts.ResumeLayout();
        UpdateStatus(products.Count);
    }

    private void UpdateStatus(int visibleCount)
    {
        int lowCount = _allProducts.Count(p => p.Stock < LowStockThreshold);
        string countText = visibleCount == _allProducts.Count
            ? $"{_allProducts.Count} products"
            : $"{visibleCount} of {_allProducts.Count} products";

        lblStatus.Text = lowCount > 0
            ? $"{countText}   |   ⚠  {lowCount} low stock (below {LowStockThreshold})"
            : countText;

        lblStatus.ForeColor = lowCount > 0
            ? Color.FromArgb(185, 28, 28)
            : Color.FromArgb(100, 116, 139);
    }

    // ── Role permissions ──────────────────────────────────────────────────────

    private void ApplyRolePermissions()
    {
        bool admin          = Session.IsAdmin;
        btnAdd.Visible      = admin;
        btnEdit.Visible     = admin;
        btnDelete.Visible   = admin;
        lblReadOnly.Visible = !admin;
    }

    // ── Selection ────────────────────────────────────────────────────────────

    private Product? GetSelectedProduct()
    {
        if (dgvProducts.SelectedRows.Count == 0) return null;
        var id = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["colId"].Value);
        return _allProducts.FirstOrDefault(p => p.ProductId == id);
    }

    // ── Events ───────────────────────────────────────────────────────────────

    private void txtSearch_TextChanged(object sender, EventArgs e)
        => ApplyFilter(txtSearch.Text);

    private void btnAdd_Click(object sender, EventArgs e)
    {
        var categories = _categoryRepo.GetAll().ToList();
        if (categories.Count == 0)
        {
            MessageBox.Show("No categories found. Please add a category first.",
                "No Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var dlg = new frmProductEdit(categories);
        if (dlg.ShowDialog(this) != DialogResult.OK) return;

        try
        {
            _productManager.AddProduct(dlg.ProductName, dlg.Price, dlg.Stock, dlg.CategoryId);
            LoadProducts();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        var product = GetSelectedProduct();
        if (product is null)
        {
            MessageBox.Show("Please select a product to edit.",
                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var categories = _categoryRepo.GetAll().ToList();
        using var dlg  = new frmProductEdit(categories, product);
        if (dlg.ShowDialog(this) != DialogResult.OK) return;

        try
        {
            _productManager.UpdateProduct(product.ProductId, dlg.ProductName, dlg.Price, dlg.Stock, dlg.CategoryId);
            LoadProducts();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var product = GetSelectedProduct();
        if (product is null)
        {
            MessageBox.Show("Please select a product to delete.",
                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirm = MessageBox.Show(
            $"Delete \"{product.Name}\"?\nThis action cannot be undone.",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);

        if (confirm != DialogResult.Yes) return;

        try
        {
            _productManager.DeleteProduct(product.ProductId);
            LoadProducts();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && Session.IsAdmin)
            btnEdit_Click(sender, e);
    }
}
