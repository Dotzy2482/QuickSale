namespace _20240305307_QuickSale;

public partial class frmMain : Form
{
    // ── Sidebar colour constants ─────────────────────────────────────────────
    private static readonly Color NavNormal = Color.Transparent;
    private static readonly Color NavNormalText = Color.FromArgb(148, 163, 184);
    private static readonly Color NavHover = Color.FromArgb(27, 44, 80);
    private static readonly Color NavHoverText = Color.FromArgb(203, 213, 225);
    private static readonly Color NavActive = Color.FromArgb(37, 99, 235);
    private static readonly Color NavActiveText = Color.White;

    // ── Nav icon glyphs (Segoe MDL2 Assets) ─────────────────────────────────
    private static readonly Dictionary<string, string> NavIcons = new()
    {
        ["btnDashboard"] = "\uE80F",   // Home
        ["btnProducts"] = "\uE7B8",   // Package
        ["btnNewSale"] = "\uE7BF",   // Shop / cart
        ["btnCustomers"] = "\uE77B",   // People
        ["btnReports"] = "\uE9D9",   // Chart
        ["btnUsers"] = "\uE716",   // Person / contact
    };

    // ── Breadcrumb page name map ─────────────────────────────────────────────
    private static readonly Dictionary<string, string> PageNames = new()
    {
        ["btnDashboard"] = "Dashboard",
        ["btnProducts"] = "Products",
        ["btnNewSale"] = "New Sale",
        ["btnCustomers"] = "Customers",
        ["btnReports"] = "Reports",
        ["btnUsers"] = "Users",
    };

    private Button? _activeNavBtn;
    private Form? _currentChildForm;
    private System.Windows.Forms.Timer? _statusTimer;

    public frmMain()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        // Top bar user info
        lblTopUserName.Text = Session.CurrentUser?.Username ?? string.Empty;
        lblTopRole.Text = Session.CurrentUser?.Role ?? string.Empty;

        // Admin-only section
        btnUsers.Visible = Session.IsAdmin;

        // Set up nav icons
        SetupNavIcons();
        lblF2Badge.BringToFront();
        pnlNotifDot.BringToFront();

        // Status bar + clock timer
        UpdateStatusBar();
        _statusTimer = new System.Windows.Forms.Timer { Interval = 60_000 };
        _statusTimer.Tick += (s, _) => UpdateStatusBar();
        _statusTimer.Start();

        // Default view
        NavigateTo(btnProducts, () => new frmProducts());
    }

    // ── Shared drawing utility ────────────────────────────────────────────────

    private static System.Drawing.Drawing2D.GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
    {
        var path = new System.Drawing.Drawing2D.GraphicsPath();
        path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
        path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
        path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
        path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
        path.CloseFigure();
        return path;
    }

    // ── Status bar ────────────────────────────────────────────────────────────

    private void UpdateStatusBar()
    {
        var user = Session.CurrentUser;
        var now = DateTime.Now;
        lblStatusBar.Text =
            $"Connected  ·  Server POS-SRV-01  |  Register #3  |  " +
            $"Shift: 08:00 – 17:00  |  Signed in as {user?.Username} ({user?.Role})  |  " +
            $"{now:dd MMM yyyy}  ·  {now:HH:mm}";
    }

    // ── Custom paint handlers ─────────────────────────────────────────────────

    private void pnlNavBadge_Paint(object sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        var rect = new Rectangle(0, 0, 31, 31);
        using var path = CreateRoundedPath(rect, 8);
        using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
            rect, Color.FromArgb(59, 130, 246), Color.FromArgb(14, 165, 233), 135F);
        g.FillPath(brush, path);
        using var font = new Font("Segoe UI", 14F, FontStyle.Bold);
        var sz = g.MeasureString("Q", font);
        g.DrawString("Q", font, Brushes.White, (32 - sz.Width) / 2f, (32 - sz.Height) / 2f);
    }

    private void pnlAvatar_Paint(object sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        using var brush = new SolidBrush(Color.FromArgb(37, 99, 235));
        g.FillEllipse(brush, 0, 0, 35, 35);
        var initial = (Session.CurrentUser?.Username ?? "U")[..1].ToUpper();
        using var font = new Font("Segoe UI", 14F, FontStyle.Bold);
        var sz = g.MeasureString(initial, font);
        g.DrawString(initial, font, Brushes.White, (36 - sz.Width) / 2f, (36 - sz.Height) / 2f);
    }

    private void pnlSearch_Paint(object sender, PaintEventArgs e)
    {
        var pnl = (Panel)sender;
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.Clear(Color.White);

        // Rounded outline
        var rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
        using var path = CreateRoundedPath(rect, 8);
        using var pen = new Pen(Color.FromArgb(226, 232, 240), 1f);
        g.DrawPath(pen, path);

        // Search icon
        using var iconFont = new Font("Segoe MDL2 Assets", 11, GraphicsUnit.Pixel);
        g.DrawString("\uE721", iconFont, new SolidBrush(Color.FromArgb(100, 116, 139)), 10, 9);

        // Placeholder text
        using var textFont = new Font("Segoe UI", 9F);
        g.DrawString("Search", textFont, new SolidBrush(Color.FromArgb(100, 116, 139)), 30, 8);

        // Ctrl+K badge
        const string badge = "Ctrl+K";
        using var badgeFont = new Font("Segoe UI", 7.5F);
        var bsz = g.MeasureString(badge, badgeFont);
        var bx = pnl.Width - (int)bsz.Width - 14;
        var by = (pnl.Height - (int)bsz.Height) / 2;
        var badgeRect = new Rectangle(bx - 4, by - 2, (int)bsz.Width + 8, (int)bsz.Height + 4);
        using var badgePath = CreateRoundedPath(badgeRect, 3);
        g.DrawPath(pen, badgePath);
        g.DrawString(badge, badgeFont, new SolidBrush(Color.FromArgb(100, 116, 139)), bx, by);
    }

    // ── Nav icon helpers ──────────────────────────────────────────────────────

    private static Image MakeNavIcon(string glyph, Color color)
    {
        var bmp = new Bitmap(20, 20, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        using var g = Graphics.FromImage(bmp);
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
        g.Clear(Color.Transparent);
        using var font = new Font("Segoe MDL2 Assets", 14, GraphicsUnit.Pixel);
        using var brush = new SolidBrush(color);
        var sf = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
        };
        g.DrawString(glyph, font, brush, new RectangleF(0, 0, 20, 20), sf);
        return bmp;
    }

    private void SetupNavIcons()
    {
        foreach (var btn in new[] { btnDashboard, btnProducts, btnNewSale, btnCustomers, btnReports, btnUsers })
        {
            if (!NavIcons.TryGetValue(btn.Name, out var glyph)) continue;
            btn.Image = MakeNavIcon(glyph, NavNormalText);
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(14, 0, 0, 0);
            btn.TextAlign = ContentAlignment.MiddleLeft;
        }
    }

    // ── Navigation ────────────────────────────────────────────────────────────

    private void NavigateTo(Button navBtn, Func<Form> factory)
    {
        SetActiveNavButton(navBtn);
        UpdateBreadcrumb(navBtn);
        LoadChildForm(factory());
    }

    private void UpdateBreadcrumb(Button navBtn)
    {
        var page = PageNames.GetValueOrDefault(navBtn.Name, navBtn.Text);
        lblBreadcrumb.Text = $"QuickSale  ›  {page}";
    }

    private void LoadChildForm(Form form)
    {
        _currentChildForm?.Close();
        _currentChildForm = form;

        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;

        pnlContent.Controls.Clear();
        pnlContent.Controls.Add(form);
        form.BringToFront();
        form.Show();
    }

    private void SetActiveNavButton(Button btn)
    {
        if (_activeNavBtn is not null)
        {
            _activeNavBtn.BackColor = NavNormal;
            _activeNavBtn.ForeColor = NavNormalText;
            UpdateNavIcon(_activeNavBtn, NavNormalText);
        }
        _activeNavBtn = btn;
        btn.BackColor = NavActive;
        btn.ForeColor = NavActiveText;
        UpdateNavIcon(btn, NavActiveText);
    }

    private static void UpdateNavIcon(Button btn, Color color)
    {
        if (NavIcons.TryGetValue(btn.Name, out var glyph))
        {
            var old = btn.Image;
            btn.Image = MakeNavIcon(glyph, color);
            old?.Dispose();
        }
    }

    // ── Nav clicks ────────────────────────────────────────────────────────────

    private void btnDashboard_Click(object sender, EventArgs e)
        => NavigateTo(btnDashboard, () => new Form
        { Text = "Dashboard", BackColor = Color.FromArgb(241, 245, 249), FormBorderStyle = FormBorderStyle.None });

    private void btnProducts_Click(object sender, EventArgs e)
        => NavigateTo(btnProducts, () => new frmProducts());

    private void btnNewSale_Click(object sender, EventArgs e)
        => NavigateTo(btnNewSale, () => new frmNewSale());

    private void btnCustomers_Click(object sender, EventArgs e)
        => NavigateTo(btnCustomers, () => new frmCustomers());

    private void btnReports_Click(object sender, EventArgs e)
        => NavigateTo(btnReports, () => new frmReports());

    private void btnUsers_Click(object sender, EventArgs e)
        => NavigateTo(btnUsers, () => new frmUsers());

    // ── Nav hover ─────────────────────────────────────────────────────────────

    private void NavBtn_MouseEnter(object sender, EventArgs e)
    {
        if (sender is Button btn && btn != _activeNavBtn)
        {
            btn.BackColor = NavHover;
            btn.ForeColor = NavHoverText;
            UpdateNavIcon(btn, NavHoverText);
        }
    }

    private void NavBtn_MouseLeave(object sender, EventArgs e)
    {
        if (sender is Button btn && btn != _activeNavBtn)
        {
            btn.BackColor = NavNormal;
            btn.ForeColor = NavNormalText;
            UpdateNavIcon(btn, NavNormalText);
        }
    }

    // ── Top bar icon buttons ──────────────────────────────────────────────────

    private void btnSettings_Click(object sender, EventArgs e)
        => MessageBox.Show("Settings coming soon.", "Settings",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

    private void btnNotification_Click(object sender, EventArgs e)
        => MessageBox.Show("No new notifications.", "Notifications",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

    // ── Keyboard shortcuts ────────────────────────────────────────────────────

    protected override void OnKeyDown(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F2)
        {
            e.SuppressKeyPress = true;
            NavigateTo(btnNewSale, () => new frmNewSale());
        }
        else if (e.Control && e.KeyCode == Keys.K)
        {
            e.SuppressKeyPress = true;
            MessageBox.Show("Search functionality coming soon.", "Search",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        base.OnKeyDown(e);
    }

    // ── Logout ────────────────────────────────────────────────────────────────

    private void btnLogout_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
            "Are you sure you want to sign out?",
            "Sign Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

        if (result != DialogResult.Yes) return;

        _statusTimer?.Stop();
        _currentChildForm?.Close();
        Session.Clear();
        DialogResult = DialogResult.OK;
    }

    // ── Alt+F4 / system close ─────────────────────────────────────────────────

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _statusTimer?.Stop();
        Session.Clear();
    }

    private void lblNavStore_Click(object sender, EventArgs e)
    {

    }
}
