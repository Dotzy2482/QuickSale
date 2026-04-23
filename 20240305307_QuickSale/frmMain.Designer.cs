namespace _20240305307_QuickSale
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            _statusTimer?.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ── Declarations ─────────────────────────────────────────────────
            pnlTop           = new Panel();
            lblBreadcrumb    = new Label();
            pnlSearch        = new Panel();
            btnSettings      = new Button();
            btnNotification  = new Button();
            pnlNotifDot      = new Panel();
            pnlAvatar        = new Panel();
            lblTopUserName   = new Label();
            lblTopRole       = new Label();
            btnSignOut       = new Button();
            pnlNav           = new Panel();
            pnlNavBrand      = new Panel();
            pnlNavBadge      = new Panel();
            lblNavTitle      = new Label();
            lblNavStore      = new Label();
            pnlNavBrandBorder = new Panel();
            lblNavMenu       = new Label();
            btnDashboard     = new Button();
            btnProducts      = new Button();
            btnNewSale       = new Button();
            btnCustomers     = new Button();
            btnReports       = new Button();
            btnUsers         = new Button();
            pnlNavDivider    = new Panel();
            lblF2Badge       = new Label();
            pnlStatusBar     = new Panel();
            lblStatusDot     = new Label();
            lblStatusBar     = new Label();
            pnlContent       = new Panel();

            pnlTop.SuspendLayout();
            pnlNav.SuspendLayout();
            pnlNavBrand.SuspendLayout();
            pnlStatusBar.SuspendLayout();
            SuspendLayout();

            // ── pnlTop — dark header bar ──────────────────────────────────────
            pnlTop.BackColor = Color.FromArgb(17, 28, 54);
            pnlTop.Controls.Add(lblBreadcrumb);
            pnlTop.Controls.Add(pnlSearch);
            pnlTop.Controls.Add(btnSettings);
            pnlTop.Controls.Add(btnNotification);
            pnlTop.Controls.Add(pnlNotifDot);
            pnlTop.Controls.Add(pnlAvatar);
            pnlTop.Controls.Add(lblTopUserName);
            pnlTop.Controls.Add(lblTopRole);
            pnlTop.Controls.Add(btnSignOut);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1280, 64);
            pnlTop.TabIndex = 0;
            //
            // lblBreadcrumb
            //
            lblBreadcrumb.Font = new Font("Segoe UI", 11F);
            lblBreadcrumb.ForeColor = Color.White;
            lblBreadcrumb.Location = new Point(20, 0);
            lblBreadcrumb.Name = "lblBreadcrumb";
            lblBreadcrumb.Size = new Size(420, 64);
            lblBreadcrumb.TabIndex = 0;
            lblBreadcrumb.Text = "QuickSale  ›  Products";
            lblBreadcrumb.TextAlign = ContentAlignment.MiddleLeft;
            //
            // pnlSearch — custom-painted rounded search bar
            //
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlSearch.BackColor = Color.FromArgb(17, 28, 54);
            pnlSearch.Cursor = Cursors.IBeam;
            pnlSearch.Location = new Point(642, 15);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(220, 34);
            pnlSearch.TabIndex = 1;
            pnlSearch.Paint += pnlSearch_Paint;
            //
            // btnSettings — gear icon
            //
            btnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 44, 80);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe MDL2 Assets", 14, GraphicsUnit.Pixel);
            btnSettings.ForeColor = Color.FromArgb(148, 163, 184);
            btnSettings.Location = new Point(878, 14);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(36, 36);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "\uE713";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            //
            // btnNotification — bell icon
            //
            btnNotification.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNotification.BackColor = Color.Transparent;
            btnNotification.Cursor = Cursors.Hand;
            btnNotification.FlatAppearance.BorderSize = 0;
            btnNotification.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 44, 80);
            btnNotification.FlatStyle = FlatStyle.Flat;
            btnNotification.Font = new Font("Segoe MDL2 Assets", 14, GraphicsUnit.Pixel);
            btnNotification.ForeColor = Color.FromArgb(148, 163, 184);
            btnNotification.Location = new Point(918, 14);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(36, 36);
            btnNotification.TabIndex = 3;
            btnNotification.Text = "\uEA8F";
            btnNotification.UseVisualStyleBackColor = false;
            btnNotification.Click += btnNotification_Click;
            //
            // pnlNotifDot — small red dot over bell
            //
            pnlNotifDot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlNotifDot.BackColor = Color.FromArgb(220, 38, 38);
            pnlNotifDot.Location = new Point(944, 12);
            pnlNotifDot.Name = "pnlNotifDot";
            pnlNotifDot.Size = new Size(8, 8);
            pnlNotifDot.TabIndex = 8;
            //
            // pnlAvatar — user initial circle
            //
            pnlAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlAvatar.BackColor = Color.Transparent;
            pnlAvatar.Location = new Point(966, 14);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.Size = new Size(36, 36);
            pnlAvatar.TabIndex = 4;
            pnlAvatar.Paint += pnlAvatar_Paint;
            //
            // lblTopUserName
            //
            lblTopUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTopUserName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTopUserName.ForeColor = Color.White;
            lblTopUserName.Location = new Point(1010, 13);
            lblTopUserName.Name = "lblTopUserName";
            lblTopUserName.Size = new Size(150, 18);
            lblTopUserName.TabIndex = 5;
            lblTopUserName.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblTopRole
            //
            lblTopRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTopRole.Font = new Font("Segoe UI", 8F);
            lblTopRole.ForeColor = Color.FromArgb(148, 163, 184);
            lblTopRole.Location = new Point(1010, 33);
            lblTopRole.Name = "lblTopRole";
            lblTopRole.Size = new Size(150, 16);
            lblTopRole.TabIndex = 6;
            lblTopRole.TextAlign = ContentAlignment.MiddleLeft;
            //
            // btnSignOut
            //
            btnSignOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSignOut.Cursor = Cursors.Hand;
            btnSignOut.FlatAppearance.BorderColor = Color.FromArgb(51, 65, 85);
            btnSignOut.FlatAppearance.BorderSize = 1;
            btnSignOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 44, 80);
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Segoe UI", 9F);
            btnSignOut.ForeColor = Color.FromArgb(148, 163, 184);
            btnSignOut.Location = new Point(1168, 14);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(100, 36);
            btnSignOut.TabIndex = 7;
            btnSignOut.Text = "Sign out";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnLogout_Click;

            // ── pnlNav — sidebar ──────────────────────────────────────────────
            pnlNav.BackColor = Color.FromArgb(17, 28, 54);
            pnlNav.Controls.Add(pnlNavBrand);
            pnlNav.Controls.Add(lblNavMenu);
            pnlNav.Controls.Add(btnDashboard);
            pnlNav.Controls.Add(btnProducts);
            pnlNav.Controls.Add(btnNewSale);
            pnlNav.Controls.Add(btnCustomers);
            pnlNav.Controls.Add(btnReports);
            pnlNav.Controls.Add(btnUsers);
            pnlNav.Controls.Add(pnlNavDivider);
            pnlNav.Controls.Add(lblF2Badge);
            pnlNav.Dock = DockStyle.Left;
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(220, 703);
            pnlNav.TabIndex = 2;
            //
            // pnlNavBrand
            //
            pnlNavBrand.BackColor = Color.FromArgb(12, 21, 41);
            pnlNavBrand.Controls.Add(pnlNavBadge);
            pnlNavBrand.Controls.Add(lblNavTitle);
            pnlNavBrand.Controls.Add(lblNavStore);
            pnlNavBrand.Controls.Add(pnlNavBrandBorder);
            pnlNavBrand.Dock = DockStyle.Top;
            pnlNavBrand.Name = "pnlNavBrand";
            pnlNavBrand.Size = new Size(220, 72);
            pnlNavBrand.TabIndex = 8;
            //
            // pnlNavBadge — gradient Q logo (custom painted)
            //
            pnlNavBadge.BackColor = Color.Transparent;
            pnlNavBadge.Location = new Point(18, 20);
            pnlNavBadge.Name = "pnlNavBadge";
            pnlNavBadge.Size = new Size(32, 32);
            pnlNavBadge.TabIndex = 0;
            pnlNavBadge.Paint += pnlNavBadge_Paint;
            //
            // lblNavTitle
            //
            lblNavTitle.BackColor = Color.Transparent;
            lblNavTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblNavTitle.ForeColor = Color.White;
            lblNavTitle.Location = new Point(58, 18);
            lblNavTitle.Name = "lblNavTitle";
            lblNavTitle.Size = new Size(150, 20);
            lblNavTitle.TabIndex = 1;
            lblNavTitle.Text = "QuickSale";
            //
            // lblNavStore
            //
            lblNavStore.BackColor = Color.Transparent;
            lblNavStore.Font = new Font("Segoe UI", 8F);
            lblNavStore.ForeColor = Color.FromArgb(71, 85, 105);
            lblNavStore.Location = new Point(58, 40);
            lblNavStore.Name = "lblNavStore";
            lblNavStore.Size = new Size(150, 16);
            lblNavStore.TabIndex = 2;
            lblNavStore.Text = "Maple Street Goods";
            //
            // pnlNavBrandBorder
            //
            pnlNavBrandBorder.BackColor = Color.FromArgb(31, 42, 72);
            pnlNavBrandBorder.Dock = DockStyle.Bottom;
            pnlNavBrandBorder.Name = "pnlNavBrandBorder";
            pnlNavBrandBorder.Size = new Size(220, 1);
            pnlNavBrandBorder.TabIndex = 3;
            //
            // lblNavMenu
            //
            lblNavMenu.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblNavMenu.ForeColor = Color.FromArgb(71, 85, 105);
            lblNavMenu.Location = new Point(20, 72);
            lblNavMenu.Name = "lblNavMenu";
            lblNavMenu.Size = new Size(200, 40);
            lblNavMenu.TabIndex = 0;
            lblNavMenu.Text = "MAIN";
            lblNavMenu.TextAlign = ContentAlignment.BottomLeft;
            //
            // btnDashboard — first nav item
            //
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.FromArgb(148, 163, 184);
            btnDashboard.Location = new Point(0, 112);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(22, 0, 0, 0);
            btnDashboard.Size = new Size(220, 52);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.MouseEnter += NavBtn_MouseEnter;
            btnDashboard.MouseLeave += NavBtn_MouseLeave;
            //
            // btnProducts (shifted to Y=164)
            //
            btnProducts.BackColor = Color.Transparent;
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 10F);
            btnProducts.ForeColor = Color.FromArgb(148, 163, 184);
            btnProducts.Location = new Point(0, 164);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(22, 0, 0, 0);
            btnProducts.Size = new Size(220, 52);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            btnProducts.MouseEnter += NavBtn_MouseEnter;
            btnProducts.MouseLeave += NavBtn_MouseLeave;
            //
            // btnNewSale (shifted to Y=216)
            //
            btnNewSale.BackColor = Color.Transparent;
            btnNewSale.Cursor = Cursors.Hand;
            btnNewSale.FlatAppearance.BorderSize = 0;
            btnNewSale.FlatStyle = FlatStyle.Flat;
            btnNewSale.Font = new Font("Segoe UI", 10F);
            btnNewSale.ForeColor = Color.FromArgb(148, 163, 184);
            btnNewSale.Location = new Point(0, 216);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Padding = new Padding(22, 0, 0, 0);
            btnNewSale.Size = new Size(220, 52);
            btnNewSale.TabIndex = 2;
            btnNewSale.Text = "New Sale";
            btnNewSale.TextAlign = ContentAlignment.MiddleLeft;
            btnNewSale.UseVisualStyleBackColor = false;
            btnNewSale.Click += btnNewSale_Click;
            btnNewSale.MouseEnter += NavBtn_MouseEnter;
            btnNewSale.MouseLeave += NavBtn_MouseLeave;
            //
            // btnCustomers (shifted to Y=268)
            //
            btnCustomers.BackColor = Color.Transparent;
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 10F);
            btnCustomers.ForeColor = Color.FromArgb(148, 163, 184);
            btnCustomers.Location = new Point(0, 268);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(22, 0, 0, 0);
            btnCustomers.Size = new Size(220, 52);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            btnCustomers.MouseEnter += NavBtn_MouseEnter;
            btnCustomers.MouseLeave += NavBtn_MouseLeave;
            //
            // btnReports (shifted to Y=320)
            //
            btnReports.BackColor = Color.Transparent;
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F);
            btnReports.ForeColor = Color.FromArgb(148, 163, 184);
            btnReports.Location = new Point(0, 320);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(22, 0, 0, 0);
            btnReports.Size = new Size(220, 52);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            btnReports.MouseEnter += NavBtn_MouseEnter;
            btnReports.MouseLeave += NavBtn_MouseLeave;
            //
            // btnUsers (shifted to Y=372)
            //
            btnUsers.BackColor = Color.Transparent;
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 10F);
            btnUsers.ForeColor = Color.FromArgb(148, 163, 184);
            btnUsers.Location = new Point(0, 372);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(22, 0, 0, 0);
            btnUsers.Size = new Size(220, 52);
            btnUsers.TabIndex = 5;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Visible = false;
            btnUsers.Click += btnUsers_Click;
            btnUsers.MouseEnter += NavBtn_MouseEnter;
            btnUsers.MouseLeave += NavBtn_MouseLeave;
            //
            // pnlNavDivider (shifted to Y=436)
            //
            pnlNavDivider.BackColor = Color.FromArgb(31, 42, 72);
            pnlNavDivider.Location = new Point(16, 436);
            pnlNavDivider.Name = "pnlNavDivider";
            pnlNavDivider.Size = new Size(188, 1);
            pnlNavDivider.TabIndex = 6;
            //
            // lblF2Badge (shifted to Y=228)
            //
            lblF2Badge.BackColor = Color.FromArgb(37, 99, 235);
            lblF2Badge.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblF2Badge.ForeColor = Color.White;
            lblF2Badge.Location = new Point(168, 228);
            lblF2Badge.Name = "lblF2Badge";
            lblF2Badge.Size = new Size(28, 18);
            lblF2Badge.TabIndex = 9;
            lblF2Badge.Text = "F2";
            lblF2Badge.TextAlign = ContentAlignment.MiddleCenter;

            // ── pnlStatusBar — bottom status bar ──────────────────────────────
            pnlStatusBar.BackColor = Color.FromArgb(12, 21, 41);
            pnlStatusBar.Controls.Add(lblStatusDot);
            pnlStatusBar.Controls.Add(lblStatusBar);
            pnlStatusBar.Dock = DockStyle.Bottom;
            pnlStatusBar.Name = "pnlStatusBar";
            pnlStatusBar.Size = new Size(1280, 28);
            pnlStatusBar.TabIndex = 4;
            //
            // lblStatusDot
            //
            lblStatusDot.Font = new Font("Segoe UI", 8F);
            lblStatusDot.ForeColor = Color.FromArgb(22, 163, 74);
            lblStatusDot.Location = new Point(12, 7);
            lblStatusDot.Name = "lblStatusDot";
            lblStatusDot.Size = new Size(12, 14);
            lblStatusDot.TabIndex = 0;
            lblStatusDot.Text = "●";
            //
            // lblStatusBar
            //
            lblStatusBar.Font = new Font("Segoe UI", 8F);
            lblStatusBar.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatusBar.Location = new Point(28, 0);
            lblStatusBar.Name = "lblStatusBar";
            lblStatusBar.Size = new Size(1240, 28);
            lblStatusBar.TabIndex = 1;
            lblStatusBar.TextAlign = ContentAlignment.MiddleLeft;

            // ── pnlContent ────────────────────────────────────────────────────
            pnlContent.BackColor = Color.FromArgb(241, 245, 249);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1060, 703);
            pnlContent.TabIndex = 3;

            // ── frmMain ───────────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 28, 54);
            ClientSize = new Size(1280, 768);
            // Dock order: last added = first docked. pnlTop docks Top, pnlStatusBar docks Bottom,
            // pnlNav docks Left, pnlContent fills remainder.
            Controls.Add(pnlContent);
            Controls.Add(pnlNav);
            Controls.Add(pnlStatusBar);
            Controls.Add(pnlTop);
            KeyPreview = true;
            MinimumSize = new Size(900, 600);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuickSale — Dashboard";
            WindowState = FormWindowState.Maximized;

            pnlTop.ResumeLayout(false);
            pnlNav.ResumeLayout(false);
            pnlNavBrand.ResumeLayout(false);
            pnlStatusBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        // ── Field declarations ────────────────────────────────────────────────
        private Panel  pnlTop;
        private Label  lblBreadcrumb;
        private Panel  pnlSearch;
        private Button btnSettings;
        private Button btnNotification;
        private Panel  pnlNotifDot;
        private Panel  pnlAvatar;
        private Label  lblTopUserName;
        private Label  lblTopRole;
        private Button btnSignOut;
        private Panel  pnlNav;
        private Panel  pnlNavBrand;
        private Panel  pnlNavBrandBorder;
        private Panel  pnlNavBadge;
        private Label  lblNavTitle;
        private Label  lblNavStore;
        private Label  lblNavMenu;
        private Button btnDashboard;
        private Button btnProducts;
        private Button btnNewSale;
        private Button btnCustomers;
        private Button btnReports;
        private Button btnUsers;
        private Panel  pnlNavDivider;
        private Label  lblF2Badge;
        private Panel  pnlStatusBar;
        private Label  lblStatusDot;
        private Label  lblStatusBar;
        private Panel  pnlContent;
    }
}
