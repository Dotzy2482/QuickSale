namespace _20240305307_QuickSale
{
    partial class frmCustomerEdit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName   = new Label();
            txtName   = new TextBox();
            lblPhone  = new Label();
            txtPhone  = new TextBox();
            lblEmail  = new Label();
            txtEmail  = new TextBox();
            lblError  = new Label();
            btnOk     = new Button();
            btnCancel = new Button();

            SuspendLayout();

            lblName.AutoSize  = false;
            lblName.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(51, 65, 85);
            lblName.Location  = new Point(20, 20);
            lblName.Name      = "lblName";
            lblName.Size      = new Size(360, 18);
            lblName.TabIndex  = 0;
            lblName.Text      = "Name *";

            txtName.BorderStyle  = BorderStyle.FixedSingle;
            txtName.Font         = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location     = new Point(20, 41);
            txtName.Name         = "txtName";
            txtName.Size         = new Size(360, 26);
            txtName.TabIndex     = 1;
            txtName.TextChanged += new EventHandler(txt_TextChanged);

            lblPhone.AutoSize  = false;
            lblPhone.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.FromArgb(51, 65, 85);
            lblPhone.Location  = new Point(20, 82);
            lblPhone.Name      = "lblPhone";
            lblPhone.Size      = new Size(360, 18);
            lblPhone.TabIndex  = 2;
            lblPhone.Text      = "Phone";

            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font        = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location    = new Point(20, 103);
            txtPhone.Name        = "txtPhone";
            txtPhone.Size        = new Size(360, 26);
            txtPhone.TabIndex    = 3;

            lblEmail.AutoSize  = false;
            lblEmail.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(51, 65, 85);
            lblEmail.Location  = new Point(20, 144);
            lblEmail.Name      = "lblEmail";
            lblEmail.Size      = new Size(360, 18);
            lblEmail.TabIndex  = 4;
            lblEmail.Text      = "Email";

            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font        = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location    = new Point(20, 165);
            txtEmail.Name        = "txtEmail";
            txtEmail.Size        = new Size(360, 26);
            txtEmail.TabIndex    = 5;

            lblError.AutoSize  = false;
            lblError.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.FromArgb(220, 38, 38);
            lblError.Location  = new Point(20, 202);
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
            btnOk.Location                     = new Point(218, 230);
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
            btnCancel.Location                        = new Point(304, 230);
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
            ClientSize          = new Size(400, 278);
            AcceptButton        = btnOk;
            CancelButton        = btnCancel;
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblError);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox     = false;
            MinimizeBox     = false;
            Name            = "frmCustomerEdit";
            StartPosition   = FormStartPosition.CenterParent;

            ResumeLayout(false);
        }

        private Label   lblName;
        private TextBox txtName;
        private Label   lblPhone;
        private TextBox txtPhone;
        private Label   lblEmail;
        private TextBox txtEmail;
        private Label   lblError;
        private Button  btnOk;
        private Button  btnCancel;
    }
}
