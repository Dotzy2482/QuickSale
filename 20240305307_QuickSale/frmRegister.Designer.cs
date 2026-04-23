namespace _20240305307_QuickSale
{
    partial class frmRegister
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader     = new Panel();
            lblTitle      = new Label();
            lblSubtitle   = new Label();
            lblUsername   = new Label();
            txtUsername   = new TextBox();
            lblPassword   = new Label();
            txtPassword   = new TextBox();
            lblConfirm    = new Label();
            txtConfirm    = new TextBox();
            lblRole       = new Label();
            cboRole       = new ComboBox();
            lblError      = new Label();
            btnRegister   = new Button();
            btnCancel     = new Button();

            pnlHeader.SuspendLayout();
            SuspendLayout();

            // ── pnlHeader ────────────────────────────────────────────────────
            pnlHeader.BackColor = Color.FromArgb(37, 99, 235);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock      = DockStyle.Top;
            pnlHeader.Name      = "pnlHeader";
            pnlHeader.Size      = new Size(420, 72);
            pnlHeader.TabIndex  = 0;

            // ── lblTitle ─────────────────────────────────────────────────────
            lblTitle.AutoSize  = false;
            lblTitle.Font      = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location  = new Point(0, 0);
            lblTitle.Name      = "lblTitle";
            lblTitle.Size      = new Size(420, 72);
            lblTitle.TabIndex  = 0;
            lblTitle.Text      = "Create Account";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // ── lblSubtitle ──────────────────────────────────────────────────
            lblSubtitle.AutoSize  = false;
            lblSubtitle.Font      = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location  = new Point(60, 90);
            lblSubtitle.Name      = "lblSubtitle";
            lblSubtitle.Size      = new Size(300, 20);
            lblSubtitle.TabIndex  = 1;
            lblSubtitle.Text      = "Fill in the details to register a new account";

            // ── lblUsername ──────────────────────────────────────────────────
            lblUsername.AutoSize  = false;
            lblUsername.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(51, 65, 85);
            lblUsername.Location  = new Point(60, 126);
            lblUsername.Name      = "lblUsername";
            lblUsername.Size      = new Size(300, 18);
            lblUsername.TabIndex  = 2;
            lblUsername.Text      = "Username";

            // ── txtUsername ──────────────────────────────────────────────────
            txtUsername.BorderStyle  = BorderStyle.FixedSingle;
            txtUsername.Font         = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location     = new Point(60, 147);
            txtUsername.Name         = "txtUsername";
            txtUsername.Size         = new Size(300, 26);
            txtUsername.TabIndex     = 3;
            txtUsername.TextChanged += new EventHandler(txt_TextChanged);
            txtUsername.KeyDown     += new KeyEventHandler(txtUsername_KeyDown);

            // ── lblPassword ──────────────────────────────────────────────────
            lblPassword.AutoSize  = false;
            lblPassword.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.FromArgb(51, 65, 85);
            lblPassword.Location  = new Point(60, 188);
            lblPassword.Name      = "lblPassword";
            lblPassword.Size      = new Size(300, 18);
            lblPassword.TabIndex  = 4;
            lblPassword.Text      = "Password";

            // ── txtPassword ──────────────────────────────────────────────────
            txtPassword.BorderStyle  = BorderStyle.FixedSingle;
            txtPassword.Font         = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location     = new Point(60, 209);
            txtPassword.Name         = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size         = new Size(300, 26);
            txtPassword.TabIndex     = 5;
            txtPassword.TextChanged += new EventHandler(txt_TextChanged);
            txtPassword.KeyDown     += new KeyEventHandler(txtPassword_KeyDown);

            // ── lblConfirm ───────────────────────────────────────────────────
            lblConfirm.AutoSize  = false;
            lblConfirm.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirm.ForeColor = Color.FromArgb(51, 65, 85);
            lblConfirm.Location  = new Point(60, 250);
            lblConfirm.Name      = "lblConfirm";
            lblConfirm.Size      = new Size(300, 18);
            lblConfirm.TabIndex  = 6;
            lblConfirm.Text      = "Confirm Password";

            // ── txtConfirm ───────────────────────────────────────────────────
            txtConfirm.BorderStyle  = BorderStyle.FixedSingle;
            txtConfirm.Font         = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirm.Location     = new Point(60, 271);
            txtConfirm.Name         = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size         = new Size(300, 26);
            txtConfirm.TabIndex     = 7;
            txtConfirm.TextChanged += new EventHandler(txt_TextChanged);
            txtConfirm.KeyDown     += new KeyEventHandler(txtConfirm_KeyDown);

            // ── lblRole ──────────────────────────────────────────────────────
            lblRole.AutoSize  = false;
            lblRole.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.ForeColor = Color.FromArgb(51, 65, 85);
            lblRole.Location  = new Point(60, 312);
            lblRole.Name      = "lblRole";
            lblRole.Size      = new Size(300, 18);
            lblRole.TabIndex  = 8;
            lblRole.Text      = "Role";

            // ── cboRole ──────────────────────────────────────────────────────
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.Font          = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboRole.FlatStyle     = FlatStyle.Flat;
            cboRole.Items.AddRange(new object[] { "Cashier", "Admin" });
            cboRole.Location      = new Point(60, 333);
            cboRole.Name          = "cboRole";
            cboRole.SelectedIndex = 0;
            cboRole.Size          = new Size(300, 27);
            cboRole.TabIndex      = 9;

            // ── lblError ─────────────────────────────────────────────────────
            lblError.AutoSize  = false;
            lblError.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.FromArgb(220, 38, 38);
            lblError.Location  = new Point(60, 372);
            lblError.Name      = "lblError";
            lblError.Size      = new Size(300, 18);
            lblError.TabIndex  = 10;
            lblError.Text      = string.Empty;
            lblError.Visible   = false;

            // ── btnRegister ──────────────────────────────────────────────────
            btnRegister.BackColor                    = Color.FromArgb(37, 99, 235);
            btnRegister.FlatStyle                    = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize    = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnRegister.Font                         = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor                    = Color.White;
            btnRegister.Location                     = new Point(60, 402);
            btnRegister.Name                         = "btnRegister";
            btnRegister.Size                         = new Size(300, 44);
            btnRegister.TabIndex                     = 11;
            btnRegister.Text                         = "CREATE ACCOUNT";
            btnRegister.UseVisualStyleBackColor      = false;
            btnRegister.Cursor                       = Cursors.Hand;
            btnRegister.Click                       += new EventHandler(btnRegister_Click);
            btnRegister.MouseEnter                  += new EventHandler(btnRegister_MouseEnter);
            btnRegister.MouseLeave                  += new EventHandler(btnRegister_MouseLeave);

            // ── btnCancel ────────────────────────────────────────────────────
            btnCancel.BackColor                       = Color.White;
            btnCancel.FlatStyle                       = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderColor      = Color.FromArgb(226, 232, 240);
            btnCancel.FlatAppearance.BorderSize       = 1;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 250, 252);
            btnCancel.Font                            = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor                       = Color.FromArgb(100, 116, 139);
            btnCancel.Location                        = new Point(60, 455);
            btnCancel.Name                            = "btnCancel";
            btnCancel.Size                            = new Size(300, 36);
            btnCancel.TabIndex                        = 12;
            btnCancel.Text                            = "Back to Login";
            btnCancel.UseVisualStyleBackColor         = false;
            btnCancel.Cursor                          = Cursors.Hand;
            btnCancel.Click                          += new EventHandler(btnCancel_Click);

            // ── frmRegister ──────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.White;
            ClientSize          = new Size(420, 510);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(lblError);
            Controls.Add(cboRole);
            Controls.Add(lblRole);
            Controls.Add(txtConfirm);
            Controls.Add(lblConfirm);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox     = false;
            MinimizeBox     = false;
            Name            = "frmRegister";
            StartPosition   = FormStartPosition.CenterParent;
            Text            = "Create Account";

            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel    pnlHeader;
        private Label    lblTitle;
        private Label    lblSubtitle;
        private Label    lblUsername;
        private TextBox  txtUsername;
        private Label    lblPassword;
        private TextBox  txtPassword;
        private Label    lblConfirm;
        private TextBox  txtConfirm;
        private Label    lblRole;
        private ComboBox cboRole;
        private Label    lblError;
        private Button   btnRegister;
        private Button   btnCancel;
    }
}
