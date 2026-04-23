using QuickSale.BLL.Managers;
using QuickSale.DAL;
using QuickSale.DAL.Repositories;

namespace _20240305307_QuickSale;

public partial class frmLogin : Form
{
    private readonly UserManager _userManager;

    // Logo placeholder: white circle with "QS" monogram painted directly on the PictureBox
    private static readonly Color PrimaryBlue     = Color.FromArgb(37, 99, 235);
    private static readonly Color PrimaryBlueDark = Color.FromArgb(29, 78, 216);

    public frmLogin()
    {
        InitializeComponent();

        var context  = new AppDbContext();
        var userRepo = new UserRepository(context);
        _userManager = new UserManager(userRepo);
    }

    // ── Demo credentials box border ─────────────────────────────────────────

    private void pnlDemoBox_Paint(object sender, PaintEventArgs e)
    {
        ControlPaint.DrawBorder(e.Graphics, pnlDemoBox.ClientRectangle,
            Color.FromArgb(191, 219, 254), ButtonBorderStyle.Solid);  // #bfdbfe
    }

    // ── Brand panel gradient background ─────────────────────────────────────

    private void pnlBrand_Paint(object sender, PaintEventArgs e)
    {
        var g    = e.Graphics;
        var rect = pnlBrand.ClientRectangle;
        using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
            rect,
            Color.FromArgb(12, 21, 41),    // #0c1529  top
            Color.FromArgb(20, 34, 68),    // #14224 4 bottom (subtle blue tint)
            90F);
        g.FillRectangle(brush, rect);
    }

    // ── "Q" badge painting ───────────────────────────────────────────────────

    private void picLogo_Paint(object sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        // Blue gradient rounded-rectangle badge
        var rect = new Rectangle(0, 0, 43, 43);
        using var path  = CreateRoundedPath(rect, 10);
        using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
            rect,
            Color.FromArgb(59, 130, 246),   // #3b82f6
            Color.FromArgb(14, 165, 233),   // #0ea5e9
            135F);
        g.FillPath(brush, path);

        // "Q" in white, centred
        using var font      = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
        using var textBrush = new SolidBrush(Color.White);
        const string text   = "Q";
        var sz = g.MeasureString(text, font);
        g.DrawString(text, font, textBrush, (44 - sz.Width) / 2f, (44 - sz.Height) / 2f);
    }

    private static System.Drawing.Drawing2D.GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
    {
        var path = new System.Drawing.Drawing2D.GraphicsPath();
        path.AddArc(rect.X,                     rect.Y,                      radius * 2, radius * 2, 180, 90);
        path.AddArc(rect.Right - radius * 2,    rect.Y,                      radius * 2, radius * 2, 270, 90);
        path.AddArc(rect.Right - radius * 2,    rect.Bottom - radius * 2,    radius * 2, radius * 2,   0, 90);
        path.AddArc(rect.X,                     rect.Bottom - radius * 2,    radius * 2, radius * 2,  90, 90);
        path.CloseFigure();
        return path;
    }

    // ── Login logic ──────────────────────────────────────────────────────────

    private void btnLogin_Click(object sender, EventArgs e)
    {
        var username = txtUsername.Text.Trim();
        var password = txtPassword.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            ShowError("Please enter your username and password.");
            return;
        }

        btnLogin.Enabled = false;
        btnLogin.Text    = "Signing in…";

        try
        {
            var user = _userManager.Login(username, password);

            if (user is null)
            {
                ShowError("Invalid username or password.");
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            Session.CurrentUser = user;

            var main = new frmMain();
            main.Show();
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An unexpected error occurred:\n{ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnLogin.Enabled = true;
            btnLogin.Text    = "Sign in";
        }
    }

    // ── Button hover ─────────────────────────────────────────────────────────

    private void btnLogin_MouseEnter(object sender, EventArgs e)
        => btnLogin.BackColor = PrimaryBlueDark;

    private void btnLogin_MouseLeave(object sender, EventArgs e)
        => btnLogin.BackColor = PrimaryBlue;

    // ── Clear error on typing ────────────────────────────────────────────────

    private void txtUsername_TextChanged(object sender, EventArgs e)
        => lblError.Visible = false;

    private void txtPassword_TextChanged(object sender, EventArgs e)
        => lblError.Visible = false;

    // ── Enter key submits ────────────────────────────────────────────────────

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            btnLogin_Click(sender, e);
        }
    }

    private void txtUsername_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            txtPassword.Focus();
        }
    }

    // ── Register link ────────────────────────────────────────────────────────

    private void lblRegister_Click(object sender, EventArgs e)
    {
        using var reg = new frmRegister();
        reg.ShowDialog(this);
    }

    // ── Helpers ──────────────────────────────────────────────────────────────

    private void ShowError(string message)
    {
        lblError.Text    = message;
        lblError.Visible = true;
    }
}
