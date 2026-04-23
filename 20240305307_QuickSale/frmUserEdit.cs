using QuickSale.DAL.Models;

namespace _20240305307_QuickSale;

public partial class frmUserEdit : Form
{
    public string  UserName { get; private set; } = string.Empty;
    public string? Password { get; private set; }
    public string  Role     { get; private set; } = "Cashier";

    private readonly bool _isEdit;

    public frmUserEdit(User? user = null)
    {
        InitializeComponent();
        _isEdit = user is not null;
        Text    = _isEdit ? "Edit User" : "Add User";

        cboRole.Items.AddRange(["Cashier", "Admin"]);
        cboRole.SelectedIndex = 0;

        if (_isEdit)
        {
            txtUsername.Text      = user!.Username;
            cboRole.SelectedItem  = user.Role;
            lblPassword.Text      = "Password (leave blank to keep)";
        }
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsername.Text))
        {
            ShowError("Username is required.");
            txtUsername.Focus();
            return;
        }

        var pwd = txtPassword.Text;

        if (!_isEdit && string.IsNullOrWhiteSpace(pwd))
        {
            ShowError("Password is required.");
            txtPassword.Focus();
            return;
        }

        if (!string.IsNullOrWhiteSpace(pwd) && pwd.Length < 6)
        {
            ShowError("Password must be at least 6 characters.");
            txtPassword.Focus();
            return;
        }

        UserName = txtUsername.Text.Trim();
        Password = string.IsNullOrWhiteSpace(pwd) ? null : pwd;
        Role     = cboRole.SelectedItem?.ToString() ?? "Cashier";

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

    private void ShowError(string message)
    {
        lblError.Text    = message;
        lblError.Visible = true;
    }
}
