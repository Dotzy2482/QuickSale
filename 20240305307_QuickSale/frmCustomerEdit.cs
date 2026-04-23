using QuickSale.DAL.Models;

namespace _20240305307_QuickSale;

public partial class frmCustomerEdit : Form
{
    public string CustomerName { get; private set; } = string.Empty;
    public string Phone        { get; private set; } = string.Empty;
    public string Email        { get; private set; } = string.Empty;

    private readonly bool _isEdit;

    public frmCustomerEdit(Customer? customer = null)
    {
        InitializeComponent();
        _isEdit = customer is not null;
        Text    = _isEdit ? "Edit Customer" : "Add Customer";

        if (_isEdit)
        {
            txtName.Text  = customer!.Name;
            txtPhone.Text = customer.Phone;
            txtEmail.Text = customer.Email;
        }
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            lblError.Text    = "Name is required.";
            lblError.Visible = true;
            txtName.Focus();
            return;
        }

        CustomerName = txtName.Text.Trim();
        Phone        = txtPhone.Text.Trim();
        Email        = txtEmail.Text.Trim();
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void txt_TextChanged(object sender, EventArgs e)
        => lblError.Visible = false;
}
