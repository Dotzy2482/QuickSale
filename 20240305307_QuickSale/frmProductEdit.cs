using QuickSale.DAL.Models;

namespace _20240305307_QuickSale;

public partial class frmProductEdit : Form
{
    // ── Public output properties (read after ShowDialog == OK) ───────────────
    public new string  ProductName => txtName.Text.Trim();
    public decimal Price       => (decimal)numPrice.Value;
    public int     Stock       => (int)numStock.Value;
    public int     CategoryId  => (int)cmbCategory.SelectedValue!;

    public frmProductEdit(List<Category> categories, Product? existing = null)
    {
        InitializeComponent();

        cmbCategory.DataSource    = categories;
        cmbCategory.DisplayMember = nameof(Category.Name);
        cmbCategory.ValueMember   = nameof(Category.CategoryId);

        if (existing is not null)
        {
            Text               = $"Edit Product — {existing.Name}";
            txtName.Text       = existing.Name;
            numPrice.Value     = existing.Price;
            numStock.Value     = existing.Stock;
            cmbCategory.SelectedValue = existing.CategoryId;
        }
        else
        {
            Text = "Add Product";
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Product name is required.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtName.Focus();
            return;
        }
        if (cmbCategory.SelectedIndex < 0)
        {
            MessageBox.Show("Please select a category.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbCategory.Focus();
            return;
        }

        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    // Enter on Name field → move to Price
    private void txtName_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; numPrice.Focus(); }
    }
}
