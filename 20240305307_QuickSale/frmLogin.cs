using System.Diagnostics;
using System.Text.Json;
using QuickSale.BLL.Managers;
using QuickSale.DAL;
using QuickSale.DAL.Repositories;

namespace _20240305307_QuickSale;

public partial class frmLogin : Form
{
    private readonly UserManager _userManager;
    private readonly AppDbContext _context;
    private Label _lblCapsWarning = null!;

    // Logo placeholder: white circle with "QS" monogram painted directly on the PictureBox
    private static readonly Color PrimaryBlue     = Color.FromArgb(37, 99, 235);
    private static readonly Color PrimaryBlueDark = Color.FromArgb(29, 78, 216);

    private bool _showPassword = false;

    // Failed-attempt throttling (in-memory, resets on app restart)
    private const int MaxAttempts    = 5;
    private const int LockoutSeconds = 60;
    private static readonly Dictionary<string, (int Count, DateTime LastAttempt)> _failedAttempts = new();

    // Remember Me settings path
    private static readonly string SettingsPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "QuickSale", "login.json");
    private record LoginSettings(bool RememberMe, string SavedUsername);

    public frmLogin()
    {
        InitializeComponent();

        _context     = new AppDbContext();
        var userRepo = new UserRepository(_context);
        _userManager = new UserManager(userRepo);

        // Repaint on events
        txtUsername.GotFocus += (s, e) => pnlUsername.Invalidate();
        txtUsername.LostFocus += (s, e) => pnlUsername.Invalidate();
        txtPassword.GotFocus  += (s, e) => { pnlPassword.Invalidate(); _lblCapsWarning.Visible = Control.IsKeyLocked(Keys.CapsLock); };
        txtPassword.LostFocus += (s, e) => pnlPassword.Invalidate();

        btnLogin.MouseEnter += (s, e) => btnLogin.Invalidate();
        btnLogin.MouseLeave += (s, e) => btnLogin.Invalidate();

        // Password visibility toggle
        pnlPassword.Click += TogglePasswordVisibility;
        txtPassword.PasswordChar = '●';

        // Caps Lock warning label (fits in the gap between password panel and Remember Me row)
        _lblCapsWarning = new Label
        {
            Text      = "⚠ Caps Lock is on",
            Font      = new Font("Segoe UI", 8F),
            ForeColor = Color.FromArgb(180, 100, 0),
            Location  = new Point(65, 269),
            Size      = new Size(200, 13),
            Visible   = false
        };
        pnlForm.Controls.Add(_lblCapsWarning);
        txtPassword.KeyUp += (s, e) => _lblCapsWarning.Visible = Control.IsKeyLocked(Keys.CapsLock);

        // Forgot Password — no email server, so direct to admin
        lblForgot.Click += (s, e) => MessageBox.Show(
            "Please contact your system administrator to reset your password.",
            "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Debug-only UI elements — hidden in Release builds
        pnlDemoBox.Visible  = Debugger.IsAttached;
        lblRegister.Visible = Debugger.IsAttached;

        // Remember Me — restore saved username
        LoadRememberMe();

        // Set application icon from logo
        LoadLogoAsIcon();
    }

    private void LoadLogoAsIcon()
    {
        try
        {
            using var bmp = new Bitmap(64, 64);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                var rect = new Rectangle(4, 4, 56, 56);
                using var path = CreateRoundedPath(rect, 12);
                using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    rect, Color.FromArgb(59, 130, 246), Color.FromArgb(14, 165, 233), 135F);
                g.FillPath(brush, path);
                using var font = new Font("Segoe UI", 28F, FontStyle.Bold);
                var sz = g.MeasureString("Q", font);
                g.DrawString("Q", font, Brushes.White, (64 - sz.Width) / 2f, (64 - sz.Height) / 2f);
            }
            this.Icon = Icon.FromHandle(bmp.GetHicon());
        }
        catch { /* Fallback to default */ }
    }

    private void TogglePasswordVisibility(object sender, EventArgs e)
    {
        // Check if click was in the eye icon area (right side of panel)
        var mousePos = pnlPassword.PointToClient(Control.MousePosition);
        if (mousePos.X >= pnlPassword.Width - 40)
        {
            _showPassword = !_showPassword;
            txtPassword.PasswordChar = _showPassword ? '\0' : '●';
            pnlPassword.Invalidate();
        }
    }

    // ── Demo credentials box painting ───────────────────────────────────────

    private void pnlDemoBox_Paint(object sender, PaintEventArgs e)
    {
        var g    = e.Graphics;
        var rect = pnlDemoBox.ClientRectangle;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        // Clear background (matches form)
        g.Clear(Color.White);

        // Background and Border (Radius 6 for sharper edges)
        using var path = CreateRoundedPath(new Rectangle(0, 0, rect.Width - 1, rect.Height - 1), 6);
        using var bg   = new SolidBrush(Color.FromArgb(239, 246, 255));
        g.FillPath(bg, path);
        using var pen = new Pen(Color.FromArgb(191, 219, 254), 1);
        g.DrawPath(pen, path);

        // Shield Icon
        using var iconPen = new Pen(Color.FromArgb(30, 64, 175), 1.5f);
        var iconX = 15;
        var iconY = 14;
        g.DrawArc(iconPen, iconX, iconY, 12, 6, 180, 180);
        g.DrawLine(iconPen, iconX, iconY + 3, iconX, iconY + 10);
        g.DrawLine(iconPen, iconX + 12, iconY + 3, iconX + 12, iconY + 10);
        g.DrawLine(iconPen, iconX, iconY + 10, iconX + 6, iconY + 15);
        g.DrawLine(iconPen, iconX + 12, iconY + 10, iconX + 6, iconY + 15);
    }

    // ── Input field painting (rounded borders + icons + focus glow) ──────────

    private void pnlInput_Paint(object sender, PaintEventArgs e)
    {
        var pnl  = (Panel)sender;
        var g    = e.Graphics;
        var rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        var isFocused = pnl.ContainsFocus;

        // 1. Clear background
        g.Clear(Color.White);

        // 2. Focus Glow
        if (isFocused)
        {
            using var glowPath = CreateRoundedPath(new Rectangle(1, 1, pnl.Width - 3, pnl.Height - 3), 7);
            using var glowPen  = new Pen(Color.FromArgb(40, 37, 99, 235), 4);
            g.DrawPath(glowPen, glowPath);
        }

        // 3. Rounded Border (Radius 6)
        using var path = CreateRoundedPath(new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1), 6);
        var borderColor = isFocused ? Color.FromArgb(37, 99, 235) : Color.FromArgb(203, 213, 225);
        using var pen = new Pen(borderColor, isFocused ? 1.5f : 1);
        g.DrawPath(pen, path);

        // 4. Icons
        using var iconPen = new Pen(Color.FromArgb(148, 163, 184), 1.2f);
        if (pnl.Name == "pnlUsername")
        {
            // User head and shoulders
            g.DrawEllipse(iconPen, 16, 12, 8, 8);
            g.DrawArc(iconPen, 13, 21, 14, 10, 180, 180);
        }
        else
        {
            // Lock body and shackle
            g.DrawRectangle(iconPen, 15, 19, 10, 8);
            g.DrawArc(iconPen, 16, 14, 8, 10, 180, 180);
            
            // Eye icon on right
            var eyeX = pnl.Width - 30;
            var eyeY = 16;
            g.DrawArc(iconPen, eyeX, eyeY, 16, 10, 0, 360);
            if (!_showPassword)
            {
                g.FillEllipse(new SolidBrush(iconPen.Color), eyeX + 6, eyeY + 3, 4, 4);
            }
            else
            {
                // Slashed eye for visible password
                g.DrawLine(iconPen, eyeX + 2, eyeY + 1, eyeX + 14, eyeY + 9);
            }
        }
    }

    // ── Sign in button painting ─────────────────────────────────────────────

    private void btnLogin_Paint(object sender, PaintEventArgs e)
    {
        var btn  = (Button)sender;
        var g    = e.Graphics;
        var rect = new Rectangle(0, 0, btn.Width - 1, btn.Height - 1);
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        // Clear background with form color to allow smooth anti-aliased rounding
        g.Clear(Color.White);

        var isHovered = btn.ClientRectangle.Contains(btn.PointToClient(Control.MousePosition));
        var baseColor = btn.Enabled ? Color.FromArgb(37, 99, 235) : Color.FromArgb(148, 163, 184);
        if (isHovered && btn.Enabled) baseColor = Color.FromArgb(29, 78, 216);

        using var path = CreateRoundedPath(rect, 6);
        using var brush = new SolidBrush(baseColor);
        g.FillPath(brush, path);

        // Focus rectangle for keyboard navigation
        if (btn.Focused && btn.Enabled)
        {
            using var focusPen = new Pen(Color.White) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot };
            g.DrawRectangle(focusPen, new Rectangle(4, 4, btn.Width - 9, btn.Height - 9));
        }

        // Centered text with arrow — reads btn.Text so "Signing in…" renders correctly
        var text = btn.Text;
        using var font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
        var sz = g.MeasureString(text, font);
        
        var totalWidth = sz.Width + 20; // text + spacing + arrow
        var startX = (btn.Width - totalWidth) / 2;
        var startY = (btn.Height - sz.Height) / 2;
        
        g.DrawString(text, font, Brushes.White, startX, startY);
        
        // Arrow (->)
        using var arrowPen = new Pen(Color.White, 2);
        var ax = startX + sz.Width + 8;
        var ay = btn.Height / 2;
        g.DrawLine(arrowPen, ax, ay, ax + 10, ay);
        g.DrawLine(arrowPen, ax + 6, ay - 4, ax + 10, ay);
        g.DrawLine(arrowPen, ax + 6, ay + 4, ax + 10, ay);
    }

    // ── Brand panel gradient background ─────────────────────────────────────

    private void pnlBrand_Paint(object sender, PaintEventArgs e)
    {
        var g    = e.Graphics;
        var rect = pnlBrand.ClientRectangle;
        using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
            rect,
            Color.FromArgb(12, 21, 41),    // #0c1529 (Dark blue)
            Color.FromArgb(30, 58, 138),   // #1e3a8a (Vibrant blue at bottom-right)
            45F);
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

    // ── Remember Me helpers ──────────────────────────────────────────────────

    private void LoadRememberMe()
    {
        try
        {
            if (!File.Exists(SettingsPath)) return;
            var s = JsonSerializer.Deserialize<LoginSettings>(File.ReadAllText(SettingsPath));
            if (s?.RememberMe == true)
            {
                chkRemember.Checked = true;
                txtUsername.Text    = s.SavedUsername;
            }
        }
        catch { /* ignore corrupt settings file */ }
    }

    private void SaveRememberMe(string displayUsername)
    {
        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(SettingsPath)!);
            var s = new LoginSettings(chkRemember.Checked, chkRemember.Checked ? displayUsername : string.Empty);
            File.WriteAllText(SettingsPath, JsonSerializer.Serialize(s));
        }
        catch { /* ignore save failure */ }
    }

    // ── Login logic ──────────────────────────────────────────────────────────

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        var displayUsername = txtUsername.Text.Trim();
        var username        = displayUsername.ToLower();   // normalize for case-insensitive match
        var password        = txtPassword.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            ShowError("Please enter your username and password.");
            return;
        }

        // Lockout check
        if (_failedAttempts.TryGetValue(username, out var record) &&
            record.Count >= MaxAttempts &&
            DateTime.Now - record.LastAttempt < TimeSpan.FromSeconds(LockoutSeconds))
        {
            var remaining = LockoutSeconds - (int)(DateTime.Now - record.LastAttempt).TotalSeconds;
            ShowError($"Too many failed attempts. Try again in {remaining}s.");
            return;
        }

        btnLogin.Enabled = false;
        btnLogin.Text    = "Signing in…";
        btnLogin.Invalidate();

        try
        {
            var user = await _userManager.LoginAsync(username, password);

            if (user is null)
            {
                _failedAttempts[username] = _failedAttempts.TryGetValue(username, out var r)
                    ? (r.Count + 1, DateTime.Now)
                    : (1, DateTime.Now);

                ShowError("Invalid username or password.");
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            _failedAttempts.Remove(username);
            SaveRememberMe(displayUsername);

            Session.CurrentUser = user;
            DialogResult = DialogResult.OK;
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
            btnLogin.Invalidate();
        }
    }

    // ── Button hover ─────────────────────────────────────────────────────────

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
