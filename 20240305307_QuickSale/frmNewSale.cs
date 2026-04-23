using Microsoft.EntityFrameworkCore;
using QuickSale.BLL.Managers;
using QuickSale.DAL;
using QuickSale.DAL.Models;
using QuickSale.DAL.Repositories;

namespace _20240305307_QuickSale;

public partial class frmNewSale : Form
{
    private readonly AppDbContext    _ctx;
    private readonly SaleManager     _saleManager;
    private readonly CustomerManager _customerManager;
    private readonly ProductManager  _productManager;

    private List<Product>  _allProducts = new();
    private List<Customer> _customers   = new();

    private const int WalkInCustomerId = 1;

    private bool _loyaltyActive; // true = auto 5% is controlling nudDiscount

    private sealed class CartItem
    {
        public int     ProductId   { get; init; }
        public string  ProductName { get; init; } = string.Empty;
        public decimal UnitPrice   { get; init; }
        public int     Qty         { get; set; }
        public decimal Subtotal    => UnitPrice * Qty;
    }

    private readonly List<CartItem> _cart = new();

    public frmNewSale()
    {
        InitializeComponent();
        _ctx             = new AppDbContext();
        _productManager  = new ProductManager(new ProductRepository(_ctx));
        _customerManager = new CustomerManager(new Repository<Customer>(_ctx));
        _saleManager     = new SaleManager(_ctx, new SaleRepository(_ctx), new ProductRepository(_ctx));
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        SetupProductGrid();
        SetupCartGrid();
        LoadCustomers();
        LoadProducts();
        cboPayment.SelectedIndex = 0;
    }

    // ── Grid setup ────────────────────────────────────────────────────────────

    private void SetupProductGrid()
    {
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colProdId", HeaderText = "ID", Width = 50,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colProdName", HeaderText = "Product",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 55
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colProdPrice", HeaderText = "Price", Width = 85,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "C2" }
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colProdStock", HeaderText = "Stock", Width = 60,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
    }

    private void SetupCartGrid()
    {
        dgvCart.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCartProduct", HeaderText = "Product",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 50
        });
        dgvCart.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCartQty", HeaderText = "Qty", Width = 55,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
        dgvCart.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCartUnit", HeaderText = "Unit Price", Width = 95,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "C2" }
        });
        dgvCart.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCartSubtotal", HeaderText = "Subtotal", Width = 95,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "C2" }
        });
    }

    // ── Data ──────────────────────────────────────────────────────────────────

    private void LoadCustomers()
    {
        _customers = _customerManager.GetAllCustomers();
        cboCustomer.Items.Clear();
        cboCustomer.DisplayMember = "Name";

        var walkIn = _customers.FirstOrDefault(c => c.CustomerId == WalkInCustomerId);
        if (walkIn is not null) cboCustomer.Items.Add(walkIn);

        foreach (var c in _customers.Where(c => c.CustomerId != WalkInCustomerId))
            cboCustomer.Items.Add(c);

        if (cboCustomer.Items.Count > 0)
            cboCustomer.SelectedIndex = 0;
    }

    private void LoadProducts()
    {
        try
        {
            _allProducts = _productManager.GetAllProducts();
            ApplyProductFilter(txtSearch.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load products:\n{ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ApplyProductFilter(string keyword)
    {
        var list = string.IsNullOrWhiteSpace(keyword)
            ? _allProducts
            : _allProducts
                .Where(p => p.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

        dgvProducts.SuspendLayout();
        dgvProducts.Rows.Clear();

        foreach (var p in list)
        {
            int idx = dgvProducts.Rows.Add(p.ProductId, p.Name, p.Price, p.Stock);
            if (p.Stock <= 0)
            {
                var row = dgvProducts.Rows[idx];
                row.DefaultCellStyle.ForeColor          = Color.FromArgb(156, 163, 175);
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(156, 163, 175);
            }
        }

        dgvProducts.ResumeLayout();
    }

    // ── Cart ──────────────────────────────────────────────────────────────────

    private void AddToCart()
    {
        if (dgvProducts.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a product first.", "No Selection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["colProdId"].Value);
        int stock     = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["colProdStock"].Value);
        int qty       = (int)nudQty.Value;

        if (stock <= 0)
        {
            MessageBox.Show("This product is out of stock.", "Out of Stock",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var existing = _cart.FirstOrDefault(c => c.ProductId == productId);
        if (existing is not null)
        {
            int newQty = existing.Qty + qty;
            if (newQty > stock)
            {
                MessageBox.Show(
                    $"Only {stock} unit(s) available. Cart already has {existing.Qty}.",
                    "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            existing.Qty = newQty;
        }
        else
        {
            if (qty > stock)
            {
                MessageBox.Show($"Only {stock} unit(s) available.",
                    "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var product = _allProducts.First(p => p.ProductId == productId);
            _cart.Add(new CartItem
            {
                ProductId   = product.ProductId,
                ProductName = product.Name,
                UnitPrice   = product.Price,
                Qty         = qty
            });
        }

        RefreshCart();
        nudQty.Value = 1;
    }

    private void RefreshCart()
    {
        dgvCart.SuspendLayout();
        dgvCart.Rows.Clear();

        foreach (var item in _cart)
            dgvCart.Rows.Add(item.ProductName, item.Qty, item.UnitPrice, item.Subtotal);

        dgvCart.ResumeLayout();
        ApplyLoyaltyDiscount(); // recalcs 5% if loyalty active, then calls RecalculateTotal
        if (!_loyaltyActive) RecalculateTotal();
    }

    private void RecalculateTotal()
    {
        decimal subtotal = _cart.Sum(i => i.Subtotal);
        decimal discount = nudDiscount.Value;
        decimal total    = Math.Max(0, subtotal - discount);
        lblTotal.Text    = total.ToString("C2");
    }

    /// <summary>
    /// Recalculates the 5% loyalty discount based on the current cart subtotal.
    /// Only runs when <see cref="_loyaltyActive"/> is true.
    /// Temporarily detaches the ValueChanged event to avoid re-entrancy.
    /// </summary>
    private void ApplyLoyaltyDiscount()
    {
        if (!_loyaltyActive) return;
        decimal subtotal = _cart.Sum(i => i.Subtotal);
        nudDiscount.ValueChanged -= nudDiscount_ValueChanged;
        nudDiscount.Value         = Math.Round(subtotal * 0.05m, 2);
        nudDiscount.ValueChanged += nudDiscount_ValueChanged;
        RecalculateTotal();
    }

    // ── Complete Sale ─────────────────────────────────────────────────────────

    private void CompleteSale()
    {
        if (_cart.Count == 0)
        {
            MessageBox.Show("Cart is empty. Add at least one product before completing the sale.",
                "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cboCustomer.SelectedItem is not Customer customer)
        {
            MessageBox.Show("Please select a customer.", "No Customer",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var paymentType = cboPayment.SelectedItem?.ToString() ?? "Cash";
        var discount    = nudDiscount.Value;
        var items       = _cart.Select(c => (c.ProductId, c.Qty)).ToList();
        int userId      = Session.CurrentUser?.UserId ?? 0;

        try
        {
            var sale = _saleManager.CreateSale(
                customer.CustomerId, userId, items, discount, paymentType);

            MessageBox.Show(
                $"Sale #{sale.SaleId} completed!\nTotal charged: {sale.Total:C2}",
                "Sale Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var loadedSale = _ctx.Sales
                .Include(s => s.Customer)
                .Include(s => s.User)
                .Include(s => s.SaleItems)
                .ThenInclude(si => si.Product)
                .First(s => s.SaleId == sale.SaleId);
            using var invoice = new frmInvoice(loadedSale);
            invoice.ShowDialog(this);

            ResetForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Sale Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ResetForm()
    {
        _loyaltyActive     = false;
        lblLoyalty.Visible = false;
        _cart.Clear();
        RefreshCart();
        nudDiscount.Value         = 0;
        nudQty.Value              = 1;
        cboCustomer.SelectedIndex = 0;
        LoadProducts();
    }

    // ── Events ────────────────────────────────────────────────────────────────

    private void txtSearch_TextChanged(object sender, EventArgs e)
        => ApplyProductFilter(txtSearch.Text);

    private void btnAddToCart_Click(object sender, EventArgs e)
        => AddToCart();

    private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) AddToCart();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        if (dgvCart.SelectedRows.Count == 0) return;
        int idx = dgvCart.SelectedRows[0].Index;
        if (idx >= 0 && idx < _cart.Count)
        {
            _cart.RemoveAt(idx);
            RefreshCart();
        }
    }

    private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool isRegistered = cboCustomer.SelectedItem is Customer c
                            && c.CustomerId != WalkInCustomerId;

        if (isRegistered)
        {
            _loyaltyActive     = true;
            lblLoyalty.Visible = true;
            ApplyLoyaltyDiscount();
        }
        else
        {
            _loyaltyActive     = false;
            lblLoyalty.Visible = false;
            nudDiscount.Value  = 0;
            RecalculateTotal();
        }
    }

    private void nudDiscount_ValueChanged(object? sender, EventArgs e)
    {
        // Cashier manually edited the discount — disable auto-loyalty
        _loyaltyActive     = false;
        lblLoyalty.Visible = false;
        RecalculateTotal();
    }

    private void btnCompleteSale_Click(object sender, EventArgs e)
        => CompleteSale();
}
