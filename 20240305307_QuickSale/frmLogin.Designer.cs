namespace _20240305307_QuickSale
{
    partial class frmLogin
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
            pnlBrand        = new Panel();
            picLogo         = new PictureBox();
            lblBrandTitle   = new Label();
            lblBrandVersion = new Label();
            lblBrandTagline = new Label();
            lblBrandDesc    = new Label();
            lblBrandFooter  = new Label();
            pnlForm         = new Panel();
            lblWelcome      = new Label();
            lblSubtitle     = new Label();
            lblUsername     = new Label();
            txtUsername     = new TextBox();
            lblPassword     = new Label();
            txtPassword     = new TextBox();
            lblError        = new Label();
            btnLogin        = new Button();
            lblRegister     = new Label();
            pnlDemoBox      = new Panel();
            lblDemoTitle    = new Label();
            lblDemoCreds    = new Label();
            lblVersion      = new Label();

            pnlBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlForm.SuspendLayout();
            pnlDemoBox.SuspendLayout();
            SuspendLayout();

            // ── pnlBrand  (left dark panel) ─────────────────────────────────────
            pnlBrand.BackColor = Color.FromArgb(12, 21, 41);
            pnlBrand.Controls.Add(picLogo);
            pnlBrand.Controls.Add(lblBrandTitle);
            pnlBrand.Controls.Add(lblBrandVersion);
            pnlBrand.Controls.Add(lblBrandTagline);
            pnlBrand.Controls.Add(lblBrandDesc);
            pnlBrand.Controls.Add(lblBrandFooter);
            pnlBrand.Dock     = DockStyle.Left;
            pnlBrand.Width    = 430;
            pnlBrand.Name     = "pnlBrand";
            pnlBrand.TabIndex = 0;
            pnlBrand.Paint   += new PaintEventHandler(pnlBrand_Paint);

            // ── picLogo  ("Q" badge inside brand panel) ──────────────────────────
            picLogo.BackColor = Color.Transparent;
            picLogo.Location  = new Point(36, 36);
            picLogo.Name      = "picLogo";
            picLogo.Size      = new Size(44, 44);
            picLogo.SizeMode  = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex  = 0;
            picLogo.TabStop   = false;
            picLogo.Paint    += new PaintEventHandler(picLogo_Paint);

            // ── lblBrandTitle ────────────────────────────────────────────────────
            lblBrandTitle.AutoSize  = false;
            lblBrandTitle.BackColor = Color.Transparent;
            lblBrandTitle.Font      = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrandTitle.ForeColor = Color.White;
            lblBrandTitle.Location  = new Point(90, 30);
            lblBrandTitle.Name      = "lblBrandTitle";
            lblBrandTitle.Size      = new Size(300, 32);
            lblBrandTitle.TabIndex  = 1;
            lblBrandTitle.Text      = "QuickSale";
            lblBrandTitle.TextAlign = ContentAlignment.MiddleLeft;

            // ── lblBrandVersion ──────────────────────────────────────────────────
            lblBrandVersion.AutoSize  = false;
            lblBrandVersion.BackColor = Color.Transparent;
            lblBrandVersion.Font      = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBrandVersion.ForeColor = Color.FromArgb(100, 116, 139);
            lblBrandVersion.Location  = new Point(90, 58);
            lblBrandVersion.Name      = "lblBrandVersion";
            lblBrandVersion.Size      = new Size(300, 18);
            lblBrandVersion.TabIndex  = 2;
            lblBrandVersion.Text      = "Point of Sale · v1.0";

            // ── lblBrandTagline ──────────────────────────────────────────────────
            lblBrandTagline.AutoSize  = false;
            lblBrandTagline.BackColor = Color.Transparent;
            lblBrandTagline.Font      = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrandTagline.ForeColor = Color.White;
            lblBrandTagline.Location  = new Point(36, 180);
            lblBrandTagline.Name      = "lblBrandTagline";
            lblBrandTagline.Size      = new Size(360, 130);
            lblBrandTagline.TabIndex  = 3;
            lblBrandTagline.Text      = "Ring up the\nnext customer.";

            // ── lblBrandDesc ─────────────────────────────────────────────────────
            lblBrandDesc.AutoSize  = false;
            lblBrandDesc.BackColor = Color.Transparent;
            lblBrandDesc.Font      = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblBrandDesc.ForeColor = Color.FromArgb(148, 163, 184);
            lblBrandDesc.Location  = new Point(36, 320);
            lblBrandDesc.Name      = "lblBrandDesc";
            lblBrandDesc.Size      = new Size(358, 80);
            lblBrandDesc.TabIndex  = 4;
            lblBrandDesc.Text      = "Inventory, sales, and customers — all in one register. Fast enough to keep the line moving.";

            // ── lblBrandFooter ───────────────────────────────────────────────────
            lblBrandFooter.AutoSize  = false;
            lblBrandFooter.BackColor = Color.Transparent;
            lblBrandFooter.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblBrandFooter.ForeColor = Color.FromArgb(71, 85, 105);
            lblBrandFooter.Location  = new Point(36, 486);
            lblBrandFooter.Name      = "lblBrandFooter";
            lblBrandFooter.Size      = new Size(358, 18);
            lblBrandFooter.TabIndex  = 5;
            lblBrandFooter.Text      = "© 2026 QuickSale Systems";

            // ── pnlForm  (right white panel) ─────────────────────────────────────
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(lblWelcome);
            pnlForm.Controls.Add(lblSubtitle);
            pnlForm.Controls.Add(lblUsername);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblPassword);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(lblError);
            pnlForm.Controls.Add(btnLogin);
            pnlForm.Controls.Add(lblRegister);
            pnlForm.Controls.Add(pnlDemoBox);
            pnlForm.Controls.Add(lblVersion);
            pnlForm.Dock      = DockStyle.Fill;
            pnlForm.Name      = "pnlForm";
            pnlForm.TabIndex  = 1;

            // ── lblWelcome ──────────────────────────────────────────────────────
            lblWelcome.AutoSize  = false;
            lblWelcome.Font      = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.FromArgb(15, 23, 42);
            lblWelcome.Location  = new Point(65, 88);
            lblWelcome.Name      = "lblWelcome";
            lblWelcome.Size      = new Size(300, 36);
            lblWelcome.TabIndex  = 1;
            lblWelcome.Text      = "Sign in";

            // ── lblSubtitle ─────────────────────────────────────────────────────
            lblSubtitle.AutoSize  = false;
            lblSubtitle.Font      = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location  = new Point(65, 130);
            lblSubtitle.Name      = "lblSubtitle";
            lblSubtitle.Size      = new Size(300, 20);
            lblSubtitle.TabIndex  = 2;
            lblSubtitle.Text      = "Use your store credentials to access the register.";

            // ── lblUsername ─────────────────────────────────────────────────────
            lblUsername.AutoSize  = false;
            lblUsername.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(51, 65, 85);
            lblUsername.Location  = new Point(65, 170);
            lblUsername.Name      = "lblUsername";
            lblUsername.Size      = new Size(300, 18);
            lblUsername.TabIndex  = 3;
            lblUsername.Text      = "Username";

            // ── txtUsername ─────────────────────────────────────────────────────
            txtUsername.BorderStyle  = BorderStyle.FixedSingle;
            txtUsername.Font         = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location     = new Point(65, 190);
            txtUsername.Name         = "txtUsername";
            txtUsername.Size         = new Size(300, 30);
            txtUsername.TabIndex     = 4;
            txtUsername.TextChanged += new EventHandler(txtUsername_TextChanged);
            txtUsername.KeyDown     += new KeyEventHandler(txtUsername_KeyDown);

            // ── lblPassword ─────────────────────────────────────────────────────
            lblPassword.AutoSize  = false;
            lblPassword.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.FromArgb(51, 65, 85);
            lblPassword.Location  = new Point(65, 232);
            lblPassword.Name      = "lblPassword";
            lblPassword.Size      = new Size(300, 18);
            lblPassword.TabIndex  = 5;
            lblPassword.Text      = "Password";

            // ── txtPassword ─────────────────────────────────────────────────────
            txtPassword.BorderStyle  = BorderStyle.FixedSingle;
            txtPassword.Font         = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location     = new Point(65, 252);
            txtPassword.Name         = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size         = new Size(300, 30);
            txtPassword.TabIndex     = 6;
            txtPassword.TextChanged += new EventHandler(txtPassword_TextChanged);
            txtPassword.KeyDown     += new KeyEventHandler(txtPassword_KeyDown);

            // ── lblError ────────────────────────────────────────────────────────
            lblError.AutoSize  = false;
            lblError.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.FromArgb(220, 38, 38);
            lblError.Location  = new Point(65, 292);
            lblError.Name      = "lblError";
            lblError.Size      = new Size(300, 18);
            lblError.TabIndex  = 7;
            lblError.Text      = string.Empty;
            lblError.Visible   = false;

            // ── btnLogin ────────────────────────────────────────────────────────
            btnLogin.BackColor                        = Color.FromArgb(37, 99, 235);
            btnLogin.FlatStyle                        = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize        = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnLogin.Font                             = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor                        = Color.White;
            btnLogin.Location                         = new Point(65, 318);
            btnLogin.Name                             = "btnLogin";
            btnLogin.Size                             = new Size(300, 44);
            btnLogin.TabIndex                         = 8;
            btnLogin.Text                             = "Sign in";
            btnLogin.UseVisualStyleBackColor          = false;
            btnLogin.Cursor                           = Cursors.Hand;
            btnLogin.Click                           += new EventHandler(btnLogin_Click);
            btnLogin.MouseEnter                      += new EventHandler(btnLogin_MouseEnter);
            btnLogin.MouseLeave                      += new EventHandler(btnLogin_MouseLeave);

            // ── lblRegister ─────────────────────────────────────────────────────
            lblRegister.AutoSize   = false;
            lblRegister.Cursor     = Cursors.Hand;
            lblRegister.Font       = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.ForeColor  = Color.FromArgb(37, 99, 235);
            lblRegister.Location   = new Point(65, 374);
            lblRegister.Name       = "lblRegister";
            lblRegister.Size       = new Size(300, 24);
            lblRegister.TabIndex   = 9;
            lblRegister.Text       = "Don't have an account?  Create one";
            lblRegister.TextAlign  = ContentAlignment.MiddleCenter;
            lblRegister.Click     += new EventHandler(lblRegister_Click);

            // ── pnlDemoBox ──────────────────────────────────────────────────────
            pnlDemoBox.BackColor = Color.FromArgb(239, 246, 255);
            pnlDemoBox.Controls.Add(lblDemoTitle);
            pnlDemoBox.Controls.Add(lblDemoCreds);
            pnlDemoBox.Location  = new Point(65, 404);
            pnlDemoBox.Name      = "pnlDemoBox";
            pnlDemoBox.Padding   = new Padding(12, 10, 12, 8);
            pnlDemoBox.Size      = new Size(300, 72);
            pnlDemoBox.TabIndex  = 11;
            pnlDemoBox.Paint    += new PaintEventHandler(pnlDemoBox_Paint);

            // ── lblDemoTitle ─────────────────────────────────────────────────────
            lblDemoTitle.AutoSize  = false;
            lblDemoTitle.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDemoTitle.ForeColor = Color.FromArgb(30, 64, 175);
            lblDemoTitle.Location  = new Point(12, 10);
            lblDemoTitle.Name      = "lblDemoTitle";
            lblDemoTitle.Size      = new Size(276, 18);
            lblDemoTitle.TabIndex  = 0;
            lblDemoTitle.Text      = "Demo credentials";

            // ── lblDemoCreds ─────────────────────────────────────────────────────
            lblDemoCreds.AutoSize  = false;
            lblDemoCreds.Font      = new Font("Consolas", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblDemoCreds.ForeColor = Color.FromArgb(37, 99, 235);
            lblDemoCreds.Location  = new Point(12, 30);
            lblDemoCreds.Name      = "lblDemoCreds";
            lblDemoCreds.Size      = new Size(276, 32);
            lblDemoCreds.TabIndex  = 1;
            lblDemoCreds.Text      = "admin    ·  admin / admin123" + Environment.NewLine + "cashier  ·  cashier / cashier123";

            // ── lblVersion ──────────────────────────────────────────────────────
            lblVersion.AutoSize  = false;
            lblVersion.Font      = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.FromArgb(148, 163, 184);
            lblVersion.Location  = new Point(65, 486);
            lblVersion.Name      = "lblVersion";
            lblVersion.Size      = new Size(300, 18);
            lblVersion.TabIndex  = 10;
            lblVersion.Text      = "QuickSale v1.0";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;

            // ── frmLogin ────────────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.White;
            ClientSize          = new Size(860, 520);
            Controls.Add(pnlForm);
            Controls.Add(pnlBrand);
            FormBorderStyle     = FormBorderStyle.FixedSingle;
            MaximizeBox         = false;
            MinimizeBox         = false;
            Name                = "frmLogin";
            StartPosition       = FormStartPosition.CenterScreen;
            Text                = "QuickSale — Login";

            pnlBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlDemoBox.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel      pnlBrand;
        private Panel      pnlForm;
        private Panel      pnlDemoBox;
        private Label      lblDemoTitle;
        private Label      lblDemoCreds;
        private PictureBox picLogo;
        private Label      lblBrandTitle;
        private Label      lblBrandVersion;
        private Label      lblBrandTagline;
        private Label      lblBrandDesc;
        private Label      lblBrandFooter;
        private Label      lblWelcome;
        private Label      lblSubtitle;
        private Label      lblUsername;
        private TextBox    txtUsername;
        private Label      lblPassword;
        private TextBox    txtPassword;
        private Label      lblError;
        private Button     btnLogin;
        private Label      lblRegister;
        private Label      lblVersion;
    }
}
