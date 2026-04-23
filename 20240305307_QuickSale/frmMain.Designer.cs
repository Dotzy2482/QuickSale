namespace _20240305307_QuickSale
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlTop          = new Panel();
            pnlTopBorder    = new Panel();
            lblTitle        = new Label();
            lblUserName     = new Label();
            lblRole         = new Label();
            btnLogout       = new Button();
            pnlNav          = new Panel();
            pnlNavBrand     = new Panel();
            pnlNavBrandBorder = new Panel();
            lblNavBadge     = new Label();
            lblNavTitle     = new Label();
            lblNavStore     = new Label();
            lblNavMenu      = new Label();
            btnProducts     = new Button();
            btnNewSale      = new Button();
            btnCustomers    = new Button();
            btnReports      = new Button();
            btnUsers        = new Button();
            pnlNavDivider   = new Panel();
            lblF2Badge      = new Label();
            pnlNavStatus    = new Panel();
            lblNavDot       = new Label();
            lblNavStatusText = new Label();
            lblNavPOS       = new Label();
            lblNavFooter    = new Label();
            pnlContent      = new Panel();

            pnlTop.SuspendLayout();
            pnlNav.SuspendLayout();
            pnlNavBrand.SuspendLayout();
            pnlNavStatus.SuspendLayout();
            SuspendLayout();

            // ── pnlTop ───────────────────────────────────────────────────────
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(lblUserName);
            pnlTop.Controls.Add(lblRole);
            pnlTop.Controls.Add(btnLogout);
            pnlTop.Dock     = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name     = "pnlTop";
            pnlTop.Size     = new Size(1280, 64);
            pnlTop.TabIndex = 0;

            // ── lblTitle ─────────────────────────────────────────────────────
            lblTitle.AutoSize  = false;
            lblTitle.Font      = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(37, 99, 235);
            lblTitle.Location  = new Point(20, 0);
            lblTitle.Name      = "lblTitle";
            lblTitle.Size      = new Size(200, 64);
            lblTitle.TabIndex  = 0;
            lblTitle.Text      = "QuickSale";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;

            // ── lblUserName ──────────────────────────────────────────────────
            lblUserName.Anchor    = AnchorStyles.Top | AnchorStyles.Right;
            lblUserName.AutoSize  = false;
            lblUserName.Font      = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.FromArgb(30, 41, 59);
            lblUserName.Location  = new Point(988, 14);
            lblUserName.Name      = "lblUserName";
            lblUserName.Size      = new Size(180, 18);
            lblUserName.TabIndex  = 1;
            lblUserName.TextAlign = ContentAlignment.MiddleRight;

            // ── lblRole ──────────────────────────────────────────────────────
            lblRole.Anchor    = AnchorStyles.Top | AnchorStyles.Right;
            lblRole.AutoSize  = false;
            lblRole.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblRole.ForeColor = Color.FromArgb(100, 116, 139);
            lblRole.Location  = new Point(988, 34);
            lblRole.Name      = "lblRole";
            lblRole.Size      = new Size(180, 16);
            lblRole.TabIndex  = 2;
            lblRole.TextAlign = ContentAlignment.MiddleRight;

            // ── btnLogout ────────────────────────────────────────────────────
            btnLogout.Anchor                         = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.FlatStyle                      = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderColor     = Color.FromArgb(220, 38, 38);
            btnLogout.FlatAppearance.BorderSize      = 1;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 226, 226);
            btnLogout.Font                           = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor                      = Color.FromArgb(220, 38, 38);
            btnLogout.Location                       = new Point(1174, 14);
            btnLogout.Name                           = "btnLogout";
            btnLogout.Size                           = new Size(90, 36);
            btnLogout.TabIndex                       = 3;
            btnLogout.Text                           = "Logout";
            btnLogout.UseVisualStyleBackColor        = false;
            btnLogout.Cursor                         = Cursors.Hand;
            btnLogout.Click                         += new EventHandler(btnLogout_Click);

            // ── pnlTopBorder ─────────────────────────────────────────────────
            pnlTopBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlTopBorder.Dock      = DockStyle.Top;
            pnlTopBorder.Location  = new Point(0, 64);
            pnlTopBorder.Name      = "pnlTopBorder";
            pnlTopBorder.Size      = new Size(1280, 1);
            pnlTopBorder.TabIndex  = 1;

            // ── pnlNav ───────────────────────────────────────────────────────
            pnlNav.BackColor = Color.FromArgb(17, 28, 54);
            pnlNav.Controls.Add(pnlNavBrand);
            pnlNav.Controls.Add(lblNavMenu);
            pnlNav.Controls.Add(btnProducts);
            pnlNav.Controls.Add(btnNewSale);
            pnlNav.Controls.Add(btnCustomers);
            pnlNav.Controls.Add(btnReports);
            pnlNav.Controls.Add(btnUsers);
            pnlNav.Controls.Add(pnlNavDivider);
            pnlNav.Controls.Add(lblF2Badge);
            pnlNav.Controls.Add(pnlNavStatus);
            pnlNav.Controls.Add(lblNavFooter);
            pnlNav.Dock     = DockStyle.Left;
            pnlNav.Location = new Point(0, 65);
            pnlNav.Name     = "pnlNav";
            pnlNav.Size     = new Size(220, 703);
            pnlNav.TabIndex = 2;

            // ── pnlNavBrand ──────────────────────────────────────────────────
            pnlNavBrand.BackColor = Color.FromArgb(12, 21, 41);
            pnlNavBrand.Controls.Add(lblNavBadge);
            pnlNavBrand.Controls.Add(lblNavTitle);
            pnlNavBrand.Controls.Add(lblNavStore);
            pnlNavBrand.Controls.Add(pnlNavBrandBorder);
            pnlNavBrand.Dock     = DockStyle.Top;
            pnlNavBrand.Name     = "pnlNavBrand";
            pnlNavBrand.Size     = new Size(220, 72);
            pnlNavBrand.TabIndex = 8;

            // ── pnlNavBrandBorder ────────────────────────────────────────────
            pnlNavBrandBorder.BackColor = Color.FromArgb(31, 42, 72);
            pnlNavBrandBorder.Dock      = DockStyle.Bottom;
            pnlNavBrandBorder.Name      = "pnlNavBrandBorder";
            pnlNavBrandBorder.Size      = new Size(220, 1);
            pnlNavBrandBorder.TabIndex  = 3;

            // ── lblNavBadge ──────────────────────────────────────────────────
            lblNavBadge.AutoSize        = false;
            lblNavBadge.BackColor       = Color.FromArgb(37, 99, 235);
            lblNavBadge.Font            = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblNavBadge.ForeColor       = Color.White;
            lblNavBadge.Location        = new Point(18, 20);
            lblNavBadge.Name            = "lblNavBadge";
            lblNavBadge.Size            = new Size(32, 32);
            lblNavBadge.TabIndex        = 0;
            lblNavBadge.Text            = "Q";
            lblNavBadge.TextAlign       = ContentAlignment.MiddleCenter;

            // ── lblNavTitle ──────────────────────────────────────────────────
            lblNavTitle.AutoSize  = false;
            lblNavTitle.BackColor = Color.Transparent;
            lblNavTitle.Font      = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblNavTitle.ForeColor = Color.White;
            lblNavTitle.Location  = new Point(58, 18);
            lblNavTitle.Name      = "lblNavTitle";
            lblNavTitle.Size      = new Size(150, 20);
            lblNavTitle.TabIndex  = 1;
            lblNavTitle.Text      = "QuickSale";

            // ── lblNavStore ──────────────────────────────────────────────────
            lblNavStore.AutoSize  = false;
            lblNavStore.BackColor = Color.Transparent;
            lblNavStore.Font      = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNavStore.ForeColor = Color.FromArgb(71, 85, 105);
            lblNavStore.Location  = new Point(58, 40);
            lblNavStore.Name      = "lblNavStore";
            lblNavStore.Size      = new Size(150, 16);
            lblNavStore.TabIndex  = 2;
            lblNavStore.Text      = "Maple Street Goods";

            // ── lblNavMenu ───────────────────────────────────────────────────
            lblNavMenu.AutoSize  = false;
            lblNavMenu.Font      = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblNavMenu.ForeColor = Color.FromArgb(71, 85, 105);
            lblNavMenu.Location  = new Point(20, 72);
            lblNavMenu.Name      = "lblNavMenu";
            lblNavMenu.Size      = new Size(200, 40);
            lblNavMenu.TabIndex  = 0;
            lblNavMenu.Text      = "MAIN";
            lblNavMenu.TextAlign = ContentAlignment.BottomLeft;

            // ── btnProducts ──────────────────────────────────────────────────
            btnProducts.FlatStyle                   = FlatStyle.Flat;
            btnProducts.FlatAppearance.BorderSize   = 0;
            btnProducts.BackColor                   = Color.Transparent;
            btnProducts.ForeColor                   = Color.FromArgb(148, 163, 184);
            btnProducts.Font                        = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.Location                    = new Point(0, 112);
            btnProducts.Name                        = "btnProducts";
            btnProducts.Padding                     = new Padding(22, 0, 0, 0);
            btnProducts.Size                        = new Size(220, 52);
            btnProducts.TabIndex                    = 1;
            btnProducts.Text                        = "Products";
            btnProducts.TextAlign                   = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor     = false;
            btnProducts.Cursor                      = Cursors.Hand;
            btnProducts.Click                      += new EventHandler(btnProducts_Click);
            btnProducts.MouseEnter                 += new EventHandler(NavBtn_MouseEnter);
            btnProducts.MouseLeave                 += new EventHandler(NavBtn_MouseLeave);

            // ── btnNewSale ───────────────────────────────────────────────────
            btnNewSale.FlatStyle                   = FlatStyle.Flat;
            btnNewSale.FlatAppearance.BorderSize   = 0;
            btnNewSale.BackColor                   = Color.Transparent;
            btnNewSale.ForeColor                   = Color.FromArgb(148, 163, 184);
            btnNewSale.Font                        = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewSale.Location                    = new Point(0, 164);
            btnNewSale.Name                        = "btnNewSale";
            btnNewSale.Padding                     = new Padding(22, 0, 0, 0);
            btnNewSale.Size                        = new Size(220, 52);
            btnNewSale.TabIndex                    = 2;
            btnNewSale.Text                        = "New Sale";
            btnNewSale.TextAlign                   = ContentAlignment.MiddleLeft;
            btnNewSale.UseVisualStyleBackColor     = false;
            btnNewSale.Cursor                      = Cursors.Hand;
            btnNewSale.Click                      += new EventHandler(btnNewSale_Click);
            btnNewSale.MouseEnter                 += new EventHandler(NavBtn_MouseEnter);
            btnNewSale.MouseLeave                 += new EventHandler(NavBtn_MouseLeave);

            // ── btnCustomers ─────────────────────────────────────────────────
            btnCustomers.FlatStyle                   = FlatStyle.Flat;
            btnCustomers.FlatAppearance.BorderSize   = 0;
            btnCustomers.BackColor                   = Color.Transparent;
            btnCustomers.ForeColor                   = Color.FromArgb(148, 163, 184);
            btnCustomers.Font                        = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomers.Location                    = new Point(0, 216);
            btnCustomers.Name                        = "btnCustomers";
            btnCustomers.Padding                     = new Padding(22, 0, 0, 0);
            btnCustomers.Size                        = new Size(220, 52);
            btnCustomers.TabIndex                    = 3;
            btnCustomers.Text                        = "Customers";
            btnCustomers.TextAlign                   = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor     = false;
            btnCustomers.Cursor                      = Cursors.Hand;
            btnCustomers.Click                      += new EventHandler(btnCustomers_Click);
            btnCustomers.MouseEnter                 += new EventHandler(NavBtn_MouseEnter);
            btnCustomers.MouseLeave                 += new EventHandler(NavBtn_MouseLeave);

            // ── btnReports ───────────────────────────────────────────────────
            btnReports.FlatStyle                   = FlatStyle.Flat;
            btnReports.FlatAppearance.BorderSize   = 0;
            btnReports.BackColor                   = Color.Transparent;
            btnReports.ForeColor                   = Color.FromArgb(148, 163, 184);
            btnReports.Font                        = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnReports.Location                    = new Point(0, 268);
            btnReports.Name                        = "btnReports";
            btnReports.Padding                     = new Padding(22, 0, 0, 0);
            btnReports.Size                        = new Size(220, 52);
            btnReports.TabIndex                    = 4;
            btnReports.Text                        = "Reports";
            btnReports.TextAlign                   = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor     = false;
            btnReports.Cursor                      = Cursors.Hand;
            btnReports.Click                      += new EventHandler(btnReports_Click);
            btnReports.MouseEnter                 += new EventHandler(NavBtn_MouseEnter);
            btnReports.MouseLeave                 += new EventHandler(NavBtn_MouseLeave);

            // ── btnUsers ─────────────────────────────────────────────────────
            btnUsers.FlatStyle                   = FlatStyle.Flat;
            btnUsers.FlatAppearance.BorderSize   = 0;
            btnUsers.BackColor                   = Color.Transparent;
            btnUsers.ForeColor                   = Color.FromArgb(148, 163, 184);
            btnUsers.Font                        = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.Location                    = new Point(0, 320);
            btnUsers.Name                        = "btnUsers";
            btnUsers.Padding                     = new Padding(22, 0, 0, 0);
            btnUsers.Size                        = new Size(220, 52);
            btnUsers.TabIndex                    = 5;
            btnUsers.Text                        = "Users";
            btnUsers.TextAlign                   = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor     = false;
            btnUsers.Visible                     = false;  // shown at runtime for Admins
            btnUsers.Cursor                      = Cursors.Hand;
            btnUsers.Click                      += new EventHandler(btnUsers_Click);
            btnUsers.MouseEnter                 += new EventHandler(NavBtn_MouseEnter);
            btnUsers.MouseLeave                 += new EventHandler(NavBtn_MouseLeave);

            // ── pnlNavDivider ─────────────────────────────────────────────────
            pnlNavDivider.BackColor = Color.FromArgb(31, 42, 72);
            pnlNavDivider.Location  = new Point(16, 384);
            pnlNavDivider.Name      = "pnlNavDivider";
            pnlNavDivider.Size      = new Size(188, 1);
            pnlNavDivider.TabIndex  = 6;

            // ── lblF2Badge ────────────────────────────────────────────────────
            lblF2Badge.AutoSize  = false;
            lblF2Badge.BackColor = Color.FromArgb(37, 99, 235);
            lblF2Badge.Font      = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblF2Badge.ForeColor = Color.White;
            lblF2Badge.Location  = new Point(168, 176);
            lblF2Badge.Name      = "lblF2Badge";
            lblF2Badge.Size      = new Size(28, 18);
            lblF2Badge.TabIndex  = 9;
            lblF2Badge.Text      = "F2";
            lblF2Badge.TextAlign = ContentAlignment.MiddleCenter;

            // ── pnlNavStatus ─────────────────────────────────────────────────
            pnlNavStatus.Anchor   = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlNavStatus.BackColor = Color.Transparent;
            pnlNavStatus.Controls.Add(lblNavDot);
            pnlNavStatus.Controls.Add(lblNavStatusText);
            pnlNavStatus.Controls.Add(lblNavPOS);
            pnlNavStatus.Location = new Point(0, 656);
            pnlNavStatus.Name     = "pnlNavStatus";
            pnlNavStatus.Size     = new Size(220, 44);
            pnlNavStatus.TabIndex = 10;

            // ── lblNavDot ─────────────────────────────────────────────────────
            lblNavDot.AutoSize  = false;
            lblNavDot.Font      = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNavDot.ForeColor = Color.FromArgb(22, 163, 74);
            lblNavDot.Location  = new Point(16, 4);
            lblNavDot.Name      = "lblNavDot";
            lblNavDot.Size      = new Size(12, 14);
            lblNavDot.TabIndex  = 0;
            lblNavDot.Text      = "●";

            // ── lblNavStatusText ──────────────────────────────────────────────
            lblNavStatusText.AutoSize  = false;
            lblNavStatusText.Font      = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNavStatusText.ForeColor = Color.FromArgb(100, 116, 139);
            lblNavStatusText.Location  = new Point(28, 2);
            lblNavStatusText.Name      = "lblNavStatusText";
            lblNavStatusText.Size      = new Size(180, 18);
            lblNavStatusText.TabIndex  = 1;
            lblNavStatusText.Text      = "Register online";

            // ── lblNavPOS ─────────────────────────────────────────────────────
            lblNavPOS.AutoSize  = false;
            lblNavPOS.Font      = new Font("Consolas", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblNavPOS.ForeColor = Color.FromArgb(71, 85, 105);
            lblNavPOS.Location  = new Point(16, 20);
            lblNavPOS.Name      = "lblNavPOS";
            lblNavPOS.Size      = new Size(190, 16);
            lblNavPOS.TabIndex  = 2;
            lblNavPOS.Text      = "POS-SRV-01  ·  REG #3";

            // ── lblNavFooter ──────────────────────────────────────────────────
            lblNavFooter.Anchor    = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNavFooter.AutoSize  = false;
            lblNavFooter.Font      = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNavFooter.ForeColor = Color.FromArgb(71, 85, 105);
            lblNavFooter.Location  = new Point(0, 668);
            lblNavFooter.Name      = "lblNavFooter";
            lblNavFooter.Size      = new Size(220, 32);
            lblNavFooter.TabIndex  = 7;
            lblNavFooter.Text      = string.Empty;
            lblNavFooter.TextAlign = ContentAlignment.MiddleCenter;

            // ── pnlContent ───────────────────────────────────────────────────
            pnlContent.BackColor = Color.FromArgb(241, 245, 249);
            pnlContent.Dock      = DockStyle.Fill;
            pnlContent.Location  = new Point(220, 65);
            pnlContent.Name      = "pnlContent";
            pnlContent.Size      = new Size(1060, 703);
            pnlContent.TabIndex  = 3;

            // ── frmMain ───────────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            KeyPreview          = true;
            BackColor           = Color.White;
            ClientSize          = new Size(1280, 768);
            // Controls added in reverse dock-priority order:
            // Fill → Left → Top borders → Top (last added = first docked)
            Controls.Add(pnlContent);
            Controls.Add(pnlNav);
            Controls.Add(pnlTopBorder);
            Controls.Add(pnlTop);
            MinimumSize     = new Size(900, 600);
            Name            = "frmMain";
            StartPosition   = FormStartPosition.CenterScreen;
            Text            = "QuickSale";
            WindowState     = FormWindowState.Maximized;

            pnlTop.ResumeLayout(false);
            pnlNav.ResumeLayout(false);
            pnlNavBrand.ResumeLayout(false);
            pnlNavStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        // ── Field declarations ────────────────────────────────────────────────
        private Panel  pnlTop;
        private Panel  pnlTopBorder;
        private Label  lblTitle;
        private Label  lblUserName;
        private Label  lblRole;
        private Button btnLogout;
        private Panel  pnlNav;
        private Panel  pnlNavBrand;
        private Panel  pnlNavBrandBorder;
        private Label  lblNavBadge;
        private Label  lblNavTitle;
        private Label  lblNavStore;
        private Label  lblNavMenu;
        private Button btnProducts;
        private Button btnNewSale;
        private Button btnCustomers;
        private Button btnReports;
        private Button btnUsers;
        private Panel  pnlNavDivider;
        private Label  lblF2Badge;
        private Panel  pnlNavStatus;
        private Label  lblNavDot;
        private Label  lblNavStatusText;
        private Label  lblNavPOS;
        private Label  lblNavFooter;
        private Panel  pnlContent;
    }
}
