using QuickSale.BLL.Managers;
using QuickSale.DAL;
using QuickSale.DAL.Repositories;

namespace _20240305307_QuickSale;

public partial class frmRegister : Form
{
    private readonly UserManager _userManager;

    private static readonly Color PrimaryBlue     = Color.FromArgb(37, 99, 235);
    private static readonly Color PrimaryBlueDark = Color.FromArgb(29, 78, 216);

    public frmRegister()
    {
        InitializeComponent();
        var context  = new AppDbContext();
        _userManager = new UserManager(new UserRepository(context));
    }

    // ── Register logic ───────────────────────────────────────────────────────

    private void btnRegister_Click(object sender, EventArgs e)
    {
        var username = txtUsername.Text.Trim();
        var password = txtPassword.Text;
        var confirm  = txtConfirm.Text;
        var role     = cboRole.SelectedItem?.ToString() ?? "Cashier";

        if (string.IsNullOrWhiteSpace(username))
        {
            ShowError("Username cannot be empty.");
            txtUsername.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            ShowError("Password cannot be empty.");
            txtPassword.Focus();
            return;
        }

        if (password.Length < 6)
        {
            ShowError("Password must be at least 6 characters.");
            txtPassword.Focus();
            return;
        }

        if (password != confirm)
        {
            ShowError("Passwords do not match.");
            txtConfirm.Clear();
            txtConfirm.Focus();
            return;
        }

        try
        {
            _userManager.AddUser(username, password, role);
            MessageBox.Show(
                $"Account '{username}' created successfully!\nYou can now log in.",
                "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    // ── Button hover ─────────────────────────────────────────────────────────

    private void btnRegister_MouseEnter(object sender, EventArgs e)
        => btnRegister.BackColor = PrimaryBlueDark;

    private void btnRegister_MouseLeave(object sender, EventArgs e)
        => btnRegister.BackColor = PrimaryBlue;

    // ── Clear error on typing ────────────────────────────────────────────────

    private void txt_TextChanged(object sender, EventArgs e)
        => lblError.Visible = false;

    // ── Enter key navigation ─────────────────────────────────────────────────

    private void txtUsername_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; txtPassword.Focus(); }
    }

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; txtConfirm.Focus(); }
    }

    private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; btnRegister_Click(sender, e); }
    }

    // ── Helpers ──────────────────────────────────────────────────────────────

    private void ShowError(string message)
    {
        lblError.Text    = message;
        lblError.Visible = true;
    }
}
