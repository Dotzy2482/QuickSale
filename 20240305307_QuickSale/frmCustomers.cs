using QuickSale.BLL.Managers;
using QuickSale.DAL;
using QuickSale.DAL.Models;
using QuickSale.DAL.Repositories;

namespace _20240305307_QuickSale;

public partial class frmCustomers : Form
{
    private readonly CustomerManager _customerManager;
    private List<Customer> _allCustomers = new();

    private const int WalkInCustomerId = 1;

    public frmCustomers()
    {
        InitializeComponent();
        var ctx          = new AppDbContext();
        _customerManager = new CustomerManager(new Repository<Customer>(ctx));
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        SetupGrid();
        ApplyRolePermissions();
        LoadCustomers();
    }

    // ── Grid setup ────────────────────────────────────────────────────────────

    private void SetupGrid()
    {
        dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colId", HeaderText = "ID", Width = 58,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
        dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colName", HeaderText = "Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 40
        });
        dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colPhone", HeaderText = "Phone",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 25
        });
        dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colEmail", HeaderText = "Email",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 35
        });
    }

    // ── Data ─────────────────────────────────────────────────────────────────

    private void LoadCustomers()
    {
        try
        {
            // Exclude the system Walk-in Customer record
            _allCustomers = _customerManager.GetAllCustomers()
                .Where(c => c.CustomerId != WalkInCustomerId)
                .ToList();
            ApplyFilter(txtSearch.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load customers:\n{ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ApplyFilter(string keyword)
    {
        var list = string.IsNullOrWhiteSpace(keyword)
            ? _allCustomers
            : _allCustomers
                .Where(c => c.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                         || c.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                         || c.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

        PopulateGrid(list);
    }

    private void PopulateGrid(List<Customer> customers)
    {
        dgvCustomers.SuspendLayout();
        dgvCustomers.Rows.Clear();

        foreach (var c in customers)
            dgvCustomers.Rows.Add(c.CustomerId, c.Name, c.Phone, c.Email);

        dgvCustomers.ResumeLayout();
        lblStatus.Text = customers.Count == _allCustomers.Count
            ? $"{_allCustomers.Count} customers"
            : $"{customers.Count} of {_allCustomers.Count} customers";
    }

    // ── Role permissions ──────────────────────────────────────────────────────

    private void ApplyRolePermissions()
    {
        bool admin        = Session.IsAdmin;
        btnAdd.Visible    = admin;
        btnEdit.Visible   = admin;
        btnDelete.Visible = admin;
        lblReadOnly.Visible = !admin;
    }

    // ── Selection ────────────────────────────────────────────────────────────

    private Customer? GetSelectedCustomer()
    {
        if (dgvCustomers.SelectedRows.Count == 0) return null;
        var id = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["colId"].Value);
        return _allCustomers.FirstOrDefault(c => c.CustomerId == id);
    }

    // ── Events ───────────────────────────────────────────────────────────────

    private void txtSearch_TextChanged(object sender, EventArgs e)
        => ApplyFilter(txtSearch.Text);

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using var dlg = new frmCustomerEdit();
        if (dlg.ShowDialog(this) != DialogResult.OK) return;

        try
        {
            _customerManager.AddCustomer(dlg.CustomerName, dlg.Phone, dlg.Email);
            LoadCustomers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        var customer = GetSelectedCustomer();
        if (customer is null)
        {
            MessageBox.Show("Please select a customer to edit.",
                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var dlg = new frmCustomerEdit(customer);
        if (dlg.ShowDialog(this) != DialogResult.OK) return;

        try
        {
            _customerManager.UpdateCustomer(customer.CustomerId, dlg.CustomerName, dlg.Phone, dlg.Email);
            LoadCustomers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var customer = GetSelectedCustomer();
        if (customer is null)
        {
            MessageBox.Show("Please select a customer to delete.",
                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirm = MessageBox.Show(
            $"Delete \"{customer.Name}\"?\nThis cannot be undone.",
            "Confirm Delete", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

        if (confirm != DialogResult.Yes) return;

        try
        {
            _customerManager.DeleteCustomer(customer.CustomerId);
            LoadCustomers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && Session.IsAdmin)
            btnEdit_Click(sender, e);
    }
}
