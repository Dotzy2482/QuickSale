namespace _20240305307_QuickSale
{
    partial class frmUserEdit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRole     = new Label();
            cboRole     = new ComboBox();
            lblError    = new Label();
            btnOk       = new Button();
            btnCancel   = new Button();

            SuspendLayout();

            lblUsername.AutoSize  = false;
            lblUsername.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.FromArgb(51, 65, 85);
            lblUsername.Location  = new Point(20, 20);
            lblUsername.Name      = "lblUsername";
            lblUsername.Size      = new Size(360, 18);
            lblUsername.TabIndex  = 0;
            lblUsername.Text      = "Username *";

            txtUsername.BorderStyle  = BorderStyle.FixedSingle;
            txtUsername.Font         = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location     = new Point(20, 41);
            txtUsername.Name         = "txtUsername";
            txtUsername.Size         = new Size(360, 26);
            txtUsername.TabIndex     = 1;
            txtUsername.TextChanged += new EventHandler(txt_TextChanged);

            lblPassword.AutoSize  = false;
            lblPassword.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.FromArgb(51, 65, 85);
            lblPassword.Location  = new Point(20, 82);
            lblPassword.Name      = "lblPassword";
            lblPassword.Size      = new Size(360, 18);
            lblPassword.TabIndex  = 2;
            lblPassword.Text      = "Password *";

            txtPassword.BorderStyle  = BorderStyle.FixedSingle;
            txtPassword.Font         = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location     = new Point(20, 103);
            txtPassword.Name         = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size         = new Size(360, 26);
            txtPassword.TabIndex     = 3;
            txtPassword.TextChanged += new EventHandler(txt_TextChanged);

            lblRole.AutoSize  = false;
            lblRole.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.ForeColor = Color.FromArgb(51, 65, 85);
            lblRole.Location  = new Point(20, 144);
            lblRole.Name      = "lblRole";
            lblRole.Size      = new Size(360, 18);
            lblRole.TabIndex  = 4;
            lblRole.Text      = "Role *";

            cboRole.DropDownStyle    = ComboBoxStyle.DropDownList;
            cboRole.FlatStyle        = FlatStyle.Flat;
            cboRole.Font             = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboRole.Location         = new Point(20, 165);
            cboRole.Name             = "cboRole";
            cboRole.Size             = new Size(360, 26);
            cboRole.TabIndex         = 5;

            lblError.AutoSize  = false;
            lblError.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.FromArgb(220, 38, 38);
            lblError.Location  = new Point(20, 204);
            lblError.Name      = "lblError";
            lblError.Size      = new Size(360, 18);
            lblError.TabIndex  = 6;
            lblError.Visible   = false;

            btnOk.BackColor                    = Color.FromArgb(37, 99, 235);
            btnOk.FlatStyle                    = FlatStyle.Flat;
            btnOk.FlatAppearance.BorderSize    = 0;
            btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnOk.Font                         = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.ForeColor                    = Color.White;
            btnOk.Location                     = new Point(218, 232);
            btnOk.Name                         = "btnOk";
            btnOk.Size                         = new Size(76, 32);
            btnOk.TabIndex                     = 7;
            btnOk.Text                         = "Save";
            btnOk.UseVisualStyleBackColor      = false;
            btnOk.Cursor                       = Cursors.Hand;
            btnOk.Click                       += new EventHandler(btnOk_Click);

            btnCancel.BackColor                       = Color.White;
            btnCancel.FlatStyle                       = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderColor      = Color.FromArgb(226, 232, 240);
            btnCancel.FlatAppearance.BorderSize       = 1;
            btnCancel.Font                            = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor                       = Color.FromArgb(100, 116, 139);
            btnCancel.Location                        = new Point(304, 232);
            btnCancel.Name                            = "btnCancel";
            btnCancel.Size                            = new Size(76, 32);
            btnCancel.TabIndex                        = 8;
            btnCancel.Text                            = "Cancel";
            btnCancel.UseVisualStyleBackColor         = false;
            btnCancel.Cursor                          = Cursors.Hand;
            btnCancel.Click                          += new EventHandler(btnCancel_Click);

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.White;
            ClientSize          = new Size(400, 280);
            AcceptButton        = btnOk;
            CancelButton        = btnCancel;
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblError);
            Controls.Add(cboRole);
            Controls.Add(lblRole);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox     = false;
            MinimizeBox     = false;
            Name            = "frmUserEdit";
            StartPosition   = FormStartPosition.CenterParent;

            ResumeLayout(false);
        }

        private Label    lblUsername;
        private TextBox  txtUsername;
        private Label    lblPassword;
        private TextBox  txtPassword;
        private Label    lblRole;
        private ComboBox cboRole;
        private Label    lblError;
        private Button   btnOk;
        private Button   btnCancel;
    }
}
