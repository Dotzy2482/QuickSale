namespace _20240305307_QuickSale;

public partial class frmMain : Form
{
    // ── Sidebar colour constants ─────────────────────────────────────────────
    private static readonly Color NavNormal     = Color.Transparent;
    private static readonly Color NavNormalText = Color.FromArgb(148, 163, 184);
    private static readonly Color NavHover      = Color.FromArgb(27,  44,  80);
    private static readonly Color NavHoverText  = Color.FromArgb(203, 213, 225);
    private static readonly Color NavActive     = Color.FromArgb(37,  99,  235);
    private static readonly Color NavActiveText = Color.White;

    // ── Nav icon glyphs (Segoe MDL2 Assets) ─────────────────────────────────
    private static readonly Dictionary<string, string> NavIcons = new()
    {
        ["btnProducts"]  = "\uE7B8",   // Package
        ["btnNewSale"]   = "\uE7BF",   // Shop / cart
        ["btnCustomers"] = "\uE77B",   // People
        ["btnReports"]   = "\uE9D9",   // Chart
        ["btnUsers"]     = "\uE716",   // Person / contact
    };

    private Button? _activeNavBtn;
    private Form?   _currentChildForm;

    public frmMain()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        lblUserName.Text = Session.CurrentUser?.Username ?? string.Empty;
        lblRole.Text     = Session.CurrentUser?.Role     ?? string.Empty;

        // Users section is Admin-only
        btnUsers.Visible = Session.IsAdmin;

        // Set up nav icons and badge z-order
        SetupNavIcons();
        lblF2Badge.BringToFront();

        // Default view
        NavigateTo(btnProducts, () => new frmProducts());
    }

    // ── Nav icon helpers ─────────────────────────────────────────────────────

    private static Image MakeNavIcon(string glyph, Color color)
    {
        var bmp = new Bitmap(20, 20, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        using var g = Graphics.FromImage(bmp);
        g.SmoothingMode    = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
        g.Clear(Color.Transparent);
        using var font  = new Font("Segoe MDL2 Assets", 14, GraphicsUnit.Pixel);
        using var brush = new SolidBrush(color);
        var sf = new StringFormat
        {
            Alignment     = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
        };
        g.DrawString(glyph, font, brush, new RectangleF(0, 0, 20, 20), sf);
        return bmp;
    }

    private void SetupNavIcons()
    {
        foreach (var btn in new[] { btnProducts, btnNewSale, btnCustomers, btnReports, btnUsers })
        {
            if (!NavIcons.TryGetValue(btn.Name, out var glyph)) continue;
            btn.Image                = MakeNavIcon(glyph, NavNormalText);
            btn.ImageAlign           = ContentAlignment.MiddleLeft;
            btn.TextImageRelation    = TextImageRelation.ImageBeforeText;
            btn.Padding              = new Padding(14, 0, 0, 0);
            btn.TextAlign            = ContentAlignment.MiddleLeft;
        }
    }

    // ── Navigation ───────────────────────────────────────────────────────────

    private void NavigateTo(Button navBtn, Func<Form> factory)
    {
        SetActiveNavButton(navBtn);
        LoadChildForm(factory());
    }

    private void LoadChildForm(Form form)
    {
        _currentChildForm?.Close();
        _currentChildForm = form;

        form.TopLevel        = false;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock            = DockStyle.Fill;

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

    // ── Nav clicks ───────────────────────────────────────────────────────────

    private void btnProducts_Click(object sender, EventArgs e)
        => NavigateTo(btnProducts,  () => new frmProducts());

    private void btnNewSale_Click(object sender, EventArgs e)
        => NavigateTo(btnNewSale,   () => new frmNewSale());

    private void btnCustomers_Click(object sender, EventArgs e)
        => NavigateTo(btnCustomers, () => new frmCustomers());

    private void btnReports_Click(object sender, EventArgs e)
        => NavigateTo(btnReports,   () => new frmReports());

    private void btnUsers_Click(object sender, EventArgs e)
        => NavigateTo(btnUsers,     () => new frmUsers());

    // ── Nav hover ────────────────────────────────────────────────────────────

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

    // ── Keyboard shortcuts ───────────────────────────────────────────────

    protected override void OnKeyDown(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F2)
        {
            e.SuppressKeyPress = true;
            NavigateTo(btnNewSale, () => new frmNewSale());
        }
        base.OnKeyDown(e);
    }

    // ── Logout ───────────────────────────────────────────────────────────────

    private void btnLogout_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
            "Are you sure you want to log out?",
            "Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);  // "No" is the safe default

        if (result != DialogResult.Yes) return;

        _currentChildForm?.Close();
        Session.Clear();
        DialogResult = DialogResult.OK;   // signals Program.Main to loop back to login
    }

    // ── Alt+F4 / system close ────────────────────────────────────────────────

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        // X-close: clear session; Program.Main will exit the loop since DialogResult != OK
        Session.Clear();
    }
}
