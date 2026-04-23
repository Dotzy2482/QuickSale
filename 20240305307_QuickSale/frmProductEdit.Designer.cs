namespace _20240305307_QuickSale
{
    partial class frmProductEdit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName      = new Label();
            txtName      = new TextBox();
            lblPrice     = new Label();
            numPrice     = new NumericUpDown();
            lblStock     = new Label();
            numStock     = new NumericUpDown();
            lblCategory  = new Label();
            cmbCategory  = new ComboBox();
            pnlDivider   = new Panel();
            btnCancel    = new Button();
            btnSave      = new Button();

            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();

            // ── lblName ──────────────────────────────────────────────────────
            lblName.AutoSize  = false;
            lblName.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(51, 65, 85);
            lblName.Location  = new Point(20, 20);
            lblName.Name      = "lblName";
            lblName.Size      = new Size(380, 18);
            lblName.TabIndex  = 0;
            lblName.Text      = "Product Name";

            // ── txtName ──────────────────────────────────────────────────────
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font        = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location    = new Point(20, 42);
            txtName.MaxLength   = 200;
            txtName.Name        = "txtName";
            txtName.Size        = new Size(380, 26);
            txtName.TabIndex    = 1;
            txtName.KeyDown    += new KeyEventHandler(txtName_KeyDown);

            // ── lblPrice ─────────────────────────────────────────────────────
            lblPrice.AutoSize  = false;
            lblPrice.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.FromArgb(51, 65, 85);
            lblPrice.Location  = new Point(20, 84);
            lblPrice.Name      = "lblPrice";
            lblPrice.Size      = new Size(160, 18);
            lblPrice.TabIndex  = 2;
            lblPrice.Text      = "Price";

            // ── numPrice ─────────────────────────────────────────────────────
            numPrice.BorderStyle    = BorderStyle.FixedSingle;
            numPrice.DecimalPlaces  = 2;
            numPrice.Font           = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numPrice.Increment      = new decimal(new int[] { 1, 0, 0, 0 });
            numPrice.Location       = new Point(20, 106);
            numPrice.Maximum        = new decimal(new int[] { 9999999, 0, 0, 0 });
            numPrice.Minimum        = new decimal(new int[] { 0, 0, 0, 0 });
            numPrice.Name           = "numPrice";
            numPrice.Size           = new Size(160, 26);
            numPrice.TabIndex       = 3;
            numPrice.ThousandsSeparator = true;

            // ── lblStock ─────────────────────────────────────────────────────
            lblStock.AutoSize  = false;
            lblStock.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.ForeColor = Color.FromArgb(51, 65, 85);
            lblStock.Location  = new Point(200, 84);
            lblStock.Name      = "lblStock";
            lblStock.Size      = new Size(80, 18);
            lblStock.TabIndex  = 4;
            lblStock.Text      = "Stock";

            // ── numStock ─────────────────────────────────────────────────────
            numStock.BorderStyle = BorderStyle.FixedSingle;
            numStock.Font        = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numStock.Location    = new Point(200, 106);
            numStock.Maximum     = new decimal(new int[] { 999999, 0, 0, 0 });
            numStock.Minimum     = new decimal(new int[] { 0, 0, 0, 0 });
            numStock.Name        = "numStock";
            numStock.Size        = new Size(100, 26);
            numStock.TabIndex    = 5;

            // ── lblCategory ──────────────────────────────────────────────────
            lblCategory.AutoSize  = false;
            lblCategory.Font      = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.FromArgb(51, 65, 85);
            lblCategory.Location  = new Point(20, 148);
            lblCategory.Name      = "lblCategory";
            lblCategory.Size      = new Size(380, 18);
            lblCategory.TabIndex  = 6;
            lblCategory.Text      = "Category";

            // ── cmbCategory ──────────────────────────────────────────────────
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font          = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location      = new Point(20, 170);
            cmbCategory.Name          = "cmbCategory";
            cmbCategory.Size          = new Size(380, 28);
            cmbCategory.TabIndex      = 7;

            // ── pnlDivider ───────────────────────────────────────────────────
            pnlDivider.BackColor = Color.FromArgb(226, 232, 240);
            pnlDivider.Location  = new Point(20, 216);
            pnlDivider.Name      = "pnlDivider";
            pnlDivider.Size      = new Size(380, 1);
            pnlDivider.TabIndex  = 8;

            // ── btnCancel ────────────────────────────────────────────────────
            btnCancel.BackColor                       = Color.White;
            btnCancel.FlatStyle                       = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderColor      = Color.FromArgb(203, 213, 225);
            btnCancel.FlatAppearance.BorderSize       = 1;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 250, 252);
            btnCancel.Font                            = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor                       = Color.FromArgb(51, 65, 85);
            btnCancel.Location                        = new Point(192, 228);
            btnCancel.Name                            = "btnCancel";
            btnCancel.Size                            = new Size(100, 38);
            btnCancel.TabIndex                        = 9;
            btnCancel.Text                            = "Cancel";
            btnCancel.UseVisualStyleBackColor         = false;
            btnCancel.Cursor                          = Cursors.Hand;
            btnCancel.Click                          += new EventHandler(btnCancel_Click);

            // ── btnSave ──────────────────────────────────────────────────────
            btnSave.BackColor                    = Color.FromArgb(37, 99, 235);
            btnSave.FlatStyle                    = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize    = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnSave.Font                         = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor                    = Color.White;
            btnSave.Location                     = new Point(300, 228);
            btnSave.Name                         = "btnSave";
            btnSave.Size                         = new Size(100, 38);
            btnSave.TabIndex                     = 10;
            btnSave.Text                         = "Save";
            btnSave.UseVisualStyleBackColor      = false;
            btnSave.Cursor                       = Cursors.Hand;
            btnSave.Click                       += new EventHandler(btnSave_Click);

            // ── frmProductEdit ───────────────────────────────────────────────
            AcceptButton        = btnSave;
            CancelButton        = btnCancel;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.White;
            ClientSize          = new Size(420, 284);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(pnlDivider);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(numStock);
            Controls.Add(lblStock);
            Controls.Add(numPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle     = FormBorderStyle.FixedDialog;
            MaximizeBox         = false;
            MinimizeBox         = false;
            Name                = "frmProductEdit";
            StartPosition       = FormStartPosition.CenterParent;
            Text                = "Product";

            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
        }

        private Label          lblName;
        private TextBox        txtName;
        private Label          lblPrice;
        private NumericUpDown  numPrice;
        private Label          lblStock;
        private NumericUpDown  numStock;
        private Label          lblCategory;
        private ComboBox       cmbCategory;
        private Panel          pnlDivider;
        private Button         btnCancel;
        private Button         btnSave;
    }
}
