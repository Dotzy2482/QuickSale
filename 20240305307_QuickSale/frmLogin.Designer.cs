namespace _20240305307_QuickSale
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            if (disposing)
                _context?.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlBrand = new Panel();
            picLogo = new PictureBox();
            lblBrandTitle = new Label();
            lblBrandVersion = new Label();
            lblBrandTagline = new Label();
            lblBrandDesc = new Label();
            lblBrandFooter = new Label();
            pnlForm = new Panel();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            pnlUsername = new Panel();
            txtUsername = new TextBox();
            lblPassword = new Label();
            pnlPassword = new Panel();
            txtPassword = new TextBox();
            chkRemember = new CheckBox();
            lblForgot = new Label();
            lblError = new Label();
            btnLogin = new Button();
            lblRegister = new Label();
            pnlDemoBox = new Panel();
            lblDemoTitle = new Label();
            lblDemoCreds = new Label();
            lblVersion = new Label();
            pnlBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlForm.SuspendLayout();
            pnlUsername.SuspendLayout();
            pnlPassword.SuspendLayout();
            pnlDemoBox.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(12, 21, 41);
            pnlBrand.Controls.Add(picLogo);
            pnlBrand.Controls.Add(lblBrandTitle);
            pnlBrand.Controls.Add(lblBrandVersion);
            pnlBrand.Controls.Add(lblBrandTagline);
            pnlBrand.Controls.Add(lblBrandDesc);
            pnlBrand.Controls.Add(lblBrandFooter);
            pnlBrand.Dock = DockStyle.Left;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(430, 520);
            pnlBrand.TabIndex = 0;
            pnlBrand.Paint += pnlBrand_Paint;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Location = new Point(42, 33);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(44, 44);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Paint += picLogo_Paint;
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.BackColor = Color.Transparent;
            lblBrandTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.White;
            lblBrandTitle.Location = new Point(90, 30);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(300, 32);
            lblBrandTitle.TabIndex = 1;
            lblBrandTitle.Text = "QuickSale";
            lblBrandTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBrandVersion
            // 
            lblBrandVersion.BackColor = Color.Transparent;
            lblBrandVersion.Font = new Font("Segoe UI", 9F);
            lblBrandVersion.ForeColor = Color.FromArgb(100, 116, 139);
            lblBrandVersion.Location = new Point(96, 62);
            lblBrandVersion.Name = "lblBrandVersion";
            lblBrandVersion.Size = new Size(300, 22);
            lblBrandVersion.TabIndex = 2;
            lblBrandVersion.Text = "Point of Sale · v1.0";
            // 
            // lblBrandTagline
            // 
            lblBrandTagline.BackColor = Color.Transparent;
            lblBrandTagline.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblBrandTagline.ForeColor = Color.White;
            lblBrandTagline.Location = new Point(36, 180);
            lblBrandTagline.Name = "lblBrandTagline";
            lblBrandTagline.Size = new Size(360, 130);
            lblBrandTagline.TabIndex = 3;
            lblBrandTagline.Text = "Ring up the\nnext customer.";
            // 
            // lblBrandDesc
            // 
            lblBrandDesc.BackColor = Color.Transparent;
            lblBrandDesc.Font = new Font("Segoe UI", 10F);
            lblBrandDesc.ForeColor = Color.FromArgb(148, 163, 184);
            lblBrandDesc.Location = new Point(36, 320);
            lblBrandDesc.Name = "lblBrandDesc";
            lblBrandDesc.Size = new Size(358, 80);
            lblBrandDesc.TabIndex = 4;
            lblBrandDesc.Text = "Inventory, sales, and customers — all in one register. Fast enough to keep the line moving.";
            // 
            // lblBrandFooter
            // 
            lblBrandFooter.BackColor = Color.Transparent;
            lblBrandFooter.Font = new Font("Segoe UI", 8.5F);
            lblBrandFooter.ForeColor = Color.FromArgb(71, 85, 105);
            lblBrandFooter.Location = new Point(36, 486);
            lblBrandFooter.Name = "lblBrandFooter";
            lblBrandFooter.Size = new Size(358, 18);
            lblBrandFooter.TabIndex = 5;
            lblBrandFooter.Text = "© 2026 QuickSale Systems";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(lblWelcome);
            pnlForm.Controls.Add(lblSubtitle);
            pnlForm.Controls.Add(lblUsername);
            pnlForm.Controls.Add(pnlUsername);
            pnlForm.Controls.Add(lblPassword);
            pnlForm.Controls.Add(pnlPassword);
            pnlForm.Controls.Add(chkRemember);
            pnlForm.Controls.Add(lblForgot);
            pnlForm.Controls.Add(lblError);
            pnlForm.Controls.Add(btnLogin);
            pnlForm.Controls.Add(lblRegister);
            pnlForm.Controls.Add(pnlDemoBox);
            pnlForm.Controls.Add(lblVersion);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(430, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(430, 520);
            pnlForm.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(15, 23, 42);
            lblWelcome.Location = new Point(65, 50);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(116, 41);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Sign in";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(65, 95);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(300, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Use your store credentials to access the register.";
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 9F);
            lblUsername.ForeColor = Color.FromArgb(100, 116, 139);
            lblUsername.Location = new Point(65, 135);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(300, 18);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.White;
            pnlUsername.Controls.Add(txtUsername);
            pnlUsername.Location = new Point(65, 155);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(300, 42);
            pnlUsername.TabIndex = 4;
            pnlUsername.Paint += pnlInput_Paint;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(40, 11);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 20);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.ForeColor = Color.FromArgb(100, 116, 139);
            lblPassword.Location = new Point(65, 205);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(300, 18);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.White;
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Location = new Point(65, 225);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(300, 42);
            pnlPassword.TabIndex = 6;
            pnlPassword.Paint += pnlInput_Paint;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(40, 11);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(230, 20);
            txtPassword.TabIndex = 0;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkRemember.ForeColor = Color.FromArgb(51, 65, 85);
            chkRemember.Location = new Point(65, 280);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(110, 19);
            chkRemember.TabIndex = 7;
            chkRemember.Text = "Remember me";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // lblForgot
            // 
            lblForgot.AutoSize = true;
            lblForgot.Cursor = Cursors.Hand;
            lblForgot.Font = new Font("Segoe UI", 9F);
            lblForgot.ForeColor = Color.FromArgb(37, 99, 235);
            lblForgot.Location = new Point(265, 281);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new Size(100, 15);
            lblForgot.TabIndex = 8;
            lblForgot.TabStop = false;
            lblForgot.Text = "Forgot password?";
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 8.5F);
            lblError.ForeColor = Color.FromArgb(220, 38, 38);
            lblError.Location = new Point(65, 305);
            lblError.Name = "lblError";
            lblError.Size = new Size(300, 18);
            lblError.TabIndex = 9;
            lblError.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(37, 99, 235);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(65, 330);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 48);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Paint += btnLogin_Paint;
            // 
            // lblRegister
            // 
            lblRegister.Cursor = Cursors.Hand;
            lblRegister.Font = new Font("Segoe UI", 9F);
            lblRegister.ForeColor = Color.FromArgb(37, 99, 235);
            lblRegister.Location = new Point(65, 385);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(300, 24);
            lblRegister.TabIndex = 11;
            lblRegister.TabStop = false;
            lblRegister.Text = "Don't have an account?  Create one";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            lblRegister.Visible = false;
            lblRegister.Click += lblRegister_Click;
            // 
            // pnlDemoBox
            // 
            pnlDemoBox.BackColor = Color.FromArgb(239, 246, 255);
            pnlDemoBox.Controls.Add(lblDemoTitle);
            pnlDemoBox.Controls.Add(lblDemoCreds);
            pnlDemoBox.Location = new Point(65, 415);
            pnlDemoBox.Name = "pnlDemoBox";
            pnlDemoBox.Padding = new Padding(12, 10, 12, 8);
            pnlDemoBox.Size = new Size(300, 75);
            pnlDemoBox.TabIndex = 12;
            pnlDemoBox.Paint += pnlDemoBox_Paint;
            // 
            // lblDemoTitle
            // 
            lblDemoTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDemoTitle.ForeColor = Color.FromArgb(30, 64, 175);
            lblDemoTitle.Location = new Point(40, 10);
            lblDemoTitle.Name = "lblDemoTitle";
            lblDemoTitle.Size = new Size(248, 18);
            lblDemoTitle.TabIndex = 0;
            lblDemoTitle.Text = "Demo credentials";
            // 
            // lblDemoCreds
            // 
            lblDemoCreds.Font = new Font("Consolas", 8.5F);
            lblDemoCreds.ForeColor = Color.FromArgb(30, 64, 175);
            lblDemoCreds.Location = new Point(40, 30);
            lblDemoCreds.Name = "lblDemoCreds";
            lblDemoCreds.Size = new Size(248, 35);
            lblDemoCreds.TabIndex = 1;
            lblDemoCreds.Text = "cashier · lpark / any\r\nadmin   · admin / any";
            // 
            // lblVersion
            // 
            lblVersion.Font = new Font("Segoe UI", 8F);
            lblVersion.ForeColor = Color.FromArgb(148, 163, 184);
            lblVersion.Location = new Point(65, 493);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(300, 18);
            lblVersion.TabIndex = 10;
            lblVersion.Text = "QuickSale v1.0";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(860, 520);
            Controls.Add(pnlForm);
            Controls.Add(pnlBrand);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuickSale — Login";
            pnlBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            pnlDemoBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel      pnlBrand;
        private Panel      pnlForm;
        private Panel      pnlUsername;
        private Panel      pnlPassword;
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
        private CheckBox   chkRemember;
        private Label      lblForgot;
        private Label      lblError;
        private Button     btnLogin;
        private Label      lblRegister;
        private Label      lblVersion;
    }
}
