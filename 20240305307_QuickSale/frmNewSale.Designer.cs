namespace _20240305307_QuickSale
{
    partial class frmNewSale
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ── Declare controls ──────────────────────────────────────────────
            pnlToolbar       = new Panel();
            pnlToolbarBorder = new Panel();
            lblTitle         = new Label();
            pnlBody          = new Panel();
            // Left panel
            pnlLeft          = new Panel();
            pnlLeftTop       = new Panel();
            lblCustomerLabel = new Label();
            cboCustomer      = new ComboBox();
            lblSearchLabel   = new Label();
            txtSearch        = new TextBox();
            pnlProductsGrid  = new Panel();
            dgvProducts      = new DataGridView();
            pnlAddBar        = new Panel();
            pnlAddBarBorder  = new Panel();
            lblQty           = new Label();
            nudQty           = new NumericUpDown();
            btnAddToCart     = new Button();
            // Divider
            pnlBodyDivider   = new Panel();
            // Right panel
            pnlRight         = new Panel();
            pnlCartHeader    = new Panel();
            pnlCartHdrBorder = new Panel();
            lblCartTitle     = new Label();
            btnRemove        = new Button();
            pnlCartGrid      = new Panel();
            dgvCart          = new DataGridView();
            pnlSummary       = new Panel();
            pnlSummaryBorder = new Panel();
            lblDiscountLabel = new Label();
            lblLoyalty       = new Label();
            nudDiscount      = new NumericUpDown();
            lblPaymentLabel  = new Label();
            cboPayment       = new ComboBox();
            lblTotalCaption  = new Label();
            lblTotal         = new Label();
            btnCompleteSale  = new Button();

            // ── Begin init ────────────────────────────────────────────────────
            pnlToolbar.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlLeftTop.SuspendLayout();
            pnlProductsGrid.SuspendLayout();
            pnlAddBar.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlCartHeader.SuspendLayout();
            pnlCartGrid.SuspendLayout();
            pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            SuspendLayout();

            // ── pnlToolbar ───────────────────────────────────────────────────
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(lblTitle);
            pnlToolbar.Dock     = DockStyle.Top;
            pnlToolbar.Name     = "pnlToolbar";
            pnlToolbar.Size     = new Size(1100, 56);
            pnlToolbar.TabIndex = 0;

            // ── lblTitle ─────────────────────────────────────────────────────
            lblTitle.AutoSize  = false;
            lblTitle.Font      = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location  = new Point(20, 0);
            lblTitle.Name      = "lblTitle";
            lblTitle.Size      = new Size(400, 56);
            lblTitle.TabIndex  = 0;
            lblTitle.Text      = "New Sale";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;

            // ── pnlToolbarBorder ─────────────────────────────────────────────
            pnlToolbarBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlToolbarBorder.Dock      = DockStyle.Top;
            pnlToolbarBorder.Name      = "pnlToolbarBorder";
            pnlToolbarBorder.Size      = new Size(1100, 1);
            pnlToolbarBorder.TabIndex  = 1;

            // ── pnlBody ──────────────────────────────────────────────────────
            pnlBody.BackColor = Color.FromArgb(241, 245, 249);
            pnlBody.Controls.Add(pnlRight);
            pnlBody.Controls.Add(pnlBodyDivider);
            pnlBody.Controls.Add(pnlLeft);
            pnlBody.Dock      = DockStyle.Fill;
            pnlBody.Name      = "pnlBody";
            pnlBody.TabIndex  = 2;

            // ── pnlLeft ──────────────────────────────────────────────────────
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(pnlProductsGrid);
            pnlLeft.Controls.Add(pnlAddBar);
            pnlLeft.Controls.Add(pnlLeftTop);
            pnlLeft.Dock      = DockStyle.Left;
            pnlLeft.Name      = "pnlLeft";
            pnlLeft.Width     = 420;
            pnlLeft.TabIndex  = 0;

            // ── pnlLeftTop ───────────────────────────────────────────────────
            pnlLeftTop.BackColor = Color.White;
            pnlLeftTop.Controls.Add(lblCustomerLabel);
            pnlLeftTop.Controls.Add(cboCustomer);
            pnlLeftTop.Controls.Add(lblSearchLabel);
            pnlLeftTop.Controls.Add(txtSearch);
            pnlLeftTop.Dock     = DockStyle.Top;
            pnlLeftTop.Name     = "pnlLeftTop";
            pnlLeftTop.Size     = new Size(420, 90);
            pnlLeftTop.TabIndex = 0;
            pnlLeftTop.Padding  = new Padding(0, 0, 0, 4);

            // ── lblCustomerLabel ─────────────────────────────────────────────
            lblCustomerLabel.AutoSize  = false;
            lblCustomerLabel.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustomerLabel.ForeColor = Color.FromArgb(100, 116, 139);
            lblCustomerLabel.Location  = new Point(12, 10);
            lblCustomerLabel.Name      = "lblCustomerLabel";
            lblCustomerLabel.Size      = new Size(72, 26);
            lblCustomerLabel.TabIndex  = 0;
            lblCustomerLabel.Text      = "Customer:";
            lblCustomerLabel.TextAlign = ContentAlignment.MiddleRight;

            // ── cboCustomer ──────────────────────────────────────────────────
            cboCustomer.DropDownStyle         = ComboBoxStyle.DropDownList;
            cboCustomer.SelectedIndexChanged += new EventHandler(cboCustomer_SelectedIndexChanged);
            cboCustomer.Font          = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            cboCustomer.FlatStyle     = FlatStyle.Flat;
            cboCustomer.Location      = new Point(88, 9);
            cboCustomer.Name          = "cboCustomer";
            cboCustomer.Size          = new Size(316, 27);
            cboCustomer.TabIndex      = 1;

            // ── lblSearchLabel ───────────────────────────────────────────────
            lblSearchLabel.AutoSize  = false;
            lblSearchLabel.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearchLabel.ForeColor = Color.FromArgb(100, 116, 139);
            lblSearchLabel.Location  = new Point(12, 50);
            lblSearchLabel.Name      = "lblSearchLabel";
            lblSearchLabel.Size      = new Size(72, 26);
            lblSearchLabel.TabIndex  = 2;
            lblSearchLabel.Text      = "Search:";
            lblSearchLabel.TextAlign = ContentAlignment.MiddleRight;

            // ── txtSearch ────────────────────────────────────────────────────
            txtSearch.BorderStyle     = BorderStyle.FixedSingle;
            txtSearch.Font            = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location        = new Point(88, 49);
            txtSearch.Name            = "txtSearch";
            txtSearch.PlaceholderText = "Search products…";
            txtSearch.Size            = new Size(316, 27);
            txtSearch.TabIndex        = 3;
            txtSearch.TextChanged    += new EventHandler(txtSearch_TextChanged);

            // ── pnlProductsGrid ──────────────────────────────────────────────
            pnlProductsGrid.BackColor = Color.FromArgb(241, 245, 249);
            pnlProductsGrid.Controls.Add(dgvProducts);
            pnlProductsGrid.Dock      = DockStyle.Fill;
            pnlProductsGrid.Name      = "pnlProductsGrid";
            pnlProductsGrid.Padding   = new Padding(10, 8, 10, 6);
            pnlProductsGrid.TabIndex  = 1;

            // ── dgvProducts ──────────────────────────────────────────────────
            dgvProducts.AllowUserToAddRows            = false;
            dgvProducts.AllowUserToDeleteRows         = false;
            dgvProducts.AllowUserToResizeRows         = false;
            dgvProducts.BackgroundColor               = Color.White;
            dgvProducts.BorderStyle                   = BorderStyle.None;
            dgvProducts.CellBorderStyle               = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersBorderStyle      = DataGridViewHeaderBorderStyle.None;
            dgvProducts.ColumnHeadersHeight           = 36;
            dgvProducts.ColumnHeadersHeightSizeMode   = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.Dock                          = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles     = false;
            dgvProducts.GridColor                     = Color.FromArgb(226, 232, 240);
            dgvProducts.MultiSelect                   = false;
            dgvProducts.Name                          = "dgvProducts";
            dgvProducts.ReadOnly                      = true;
            dgvProducts.RowHeadersVisible             = false;
            dgvProducts.RowTemplate.Height            = 36;
            dgvProducts.SelectionMode                 = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.TabIndex                      = 0;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor          = Color.FromArgb(241, 245, 249);
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor          = Color.FromArgb(100, 116, 139);
            dgvProducts.ColumnHeadersDefaultCellStyle.Font               = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvProducts.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dgvProducts.ColumnHeadersDefaultCellStyle.Padding            = new Padding(6, 0, 0, 0);
            dgvProducts.DefaultCellStyle.Font                            = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvProducts.DefaultCellStyle.Padding                         = new Padding(4, 0, 4, 0);
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor        = Color.FromArgb(248, 250, 252);
            dgvProducts.CellDoubleClick += new DataGridViewCellEventHandler(dgvProducts_CellDoubleClick);

            // ── pnlAddBar ────────────────────────────────────────────────────
            pnlAddBar.BackColor = Color.White;
            pnlAddBar.Controls.Add(lblQty);
            pnlAddBar.Controls.Add(nudQty);
            pnlAddBar.Controls.Add(btnAddToCart);
            pnlAddBar.Controls.Add(pnlAddBarBorder);
            pnlAddBar.Dock      = DockStyle.Bottom;
            pnlAddBar.Name      = "pnlAddBar";
            pnlAddBar.Size      = new Size(420, 54);
            pnlAddBar.TabIndex  = 2;

            // ── pnlAddBarBorder ──────────────────────────────────────────────
            pnlAddBarBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlAddBarBorder.Dock      = DockStyle.Top;
            pnlAddBarBorder.Name      = "pnlAddBarBorder";
            pnlAddBarBorder.Size      = new Size(420, 1);
            pnlAddBarBorder.TabIndex  = 0;

            // ── lblQty ───────────────────────────────────────────────────────
            lblQty.AutoSize  = false;
            lblQty.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblQty.ForeColor = Color.FromArgb(100, 116, 139);
            lblQty.Location  = new Point(12, 14);
            lblQty.Name      = "lblQty";
            lblQty.Size      = new Size(30, 28);
            lblQty.TabIndex  = 1;
            lblQty.Text      = "Qty:";
            lblQty.TextAlign = ContentAlignment.MiddleLeft;

            // ── nudQty ───────────────────────────────────────────────────────
            nudQty.Font      = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nudQty.Location  = new Point(46, 12);
            nudQty.Minimum   = 1;
            nudQty.Maximum   = 9999;
            nudQty.Value     = 1;
            nudQty.Name      = "nudQty";
            nudQty.Size      = new Size(68, 30);
            nudQty.TabIndex  = 2;

            // ── btnAddToCart ─────────────────────────────────────────────────
            btnAddToCart.BackColor                    = Color.FromArgb(5, 150, 105);
            btnAddToCart.FlatStyle                    = FlatStyle.Flat;
            btnAddToCart.FlatAppearance.BorderSize    = 0;
            btnAddToCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 120, 87);
            btnAddToCart.Font                         = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddToCart.ForeColor                    = Color.White;
            btnAddToCart.Location                     = new Point(124, 11);
            btnAddToCart.Name                         = "btnAddToCart";
            btnAddToCart.Size                         = new Size(282, 32);
            btnAddToCart.TabIndex                     = 3;
            btnAddToCart.Text                         = "+ Add to Cart";
            btnAddToCart.UseVisualStyleBackColor      = false;
            btnAddToCart.Cursor                       = Cursors.Hand;
            btnAddToCart.Click                       += new EventHandler(btnAddToCart_Click);

            // ── pnlBodyDivider ───────────────────────────────────────────────
            pnlBodyDivider.BackColor = Color.FromArgb(226, 232, 240);
            pnlBodyDivider.Dock      = DockStyle.Left;
            pnlBodyDivider.Name      = "pnlBodyDivider";
            pnlBodyDivider.Width     = 1;
            pnlBodyDivider.TabIndex  = 1;

            // ── pnlRight ─────────────────────────────────────────────────────
            pnlRight.BackColor = Color.FromArgb(241, 245, 249);
            pnlRight.Controls.Add(pnlCartGrid);
            pnlRight.Controls.Add(pnlSummary);
            pnlRight.Controls.Add(pnlCartHdrBorder);
            pnlRight.Controls.Add(pnlCartHeader);
            pnlRight.Dock      = DockStyle.Fill;
            pnlRight.Name      = "pnlRight";
            pnlRight.TabIndex  = 2;

            // ── pnlCartHeader ────────────────────────────────────────────────
            pnlCartHeader.BackColor = Color.White;
            pnlCartHeader.Controls.Add(lblCartTitle);
            pnlCartHeader.Controls.Add(btnRemove);
            pnlCartHeader.Dock      = DockStyle.Top;
            pnlCartHeader.Name      = "pnlCartHeader";
            pnlCartHeader.Size      = new Size(679, 48);
            pnlCartHeader.TabIndex  = 3;

            // ── pnlCartHdrBorder ─────────────────────────────────────────────
            pnlCartHdrBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlCartHdrBorder.Dock      = DockStyle.Top;
            pnlCartHdrBorder.Name      = "pnlCartHdrBorder";
            pnlCartHdrBorder.Size      = new Size(679, 1);
            pnlCartHdrBorder.TabIndex  = 2;

            // ── lblCartTitle ─────────────────────────────────────────────────
            lblCartTitle.AutoSize  = false;
            lblCartTitle.Font      = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCartTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblCartTitle.Location  = new Point(14, 0);
            lblCartTitle.Name      = "lblCartTitle";
            lblCartTitle.Size      = new Size(200, 48);
            lblCartTitle.TabIndex  = 0;
            lblCartTitle.Text      = "Cart";
            lblCartTitle.TextAlign = ContentAlignment.MiddleLeft;

            // ── btnRemove ────────────────────────────────────────────────────
            btnRemove.Anchor                          = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.BackColor                       = Color.White;
            btnRemove.FlatStyle                       = FlatStyle.Flat;
            btnRemove.FlatAppearance.BorderColor      = Color.FromArgb(220, 38, 38);
            btnRemove.FlatAppearance.BorderSize       = 1;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
            btnRemove.Font                            = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.ForeColor                       = Color.FromArgb(220, 38, 38);
            btnRemove.Location                        = new Point(565, 9);
            btnRemove.Name                            = "btnRemove";
            btnRemove.Size                            = new Size(100, 30);
            btnRemove.TabIndex                        = 1;
            btnRemove.Text                            = "Remove Item";
            btnRemove.UseVisualStyleBackColor         = false;
            btnRemove.Cursor                          = Cursors.Hand;
            btnRemove.Click                          += new EventHandler(btnRemove_Click);

            // ── pnlCartGrid ──────────────────────────────────────────────────
            pnlCartGrid.BackColor = Color.FromArgb(241, 245, 249);
            pnlCartGrid.Controls.Add(dgvCart);
            pnlCartGrid.Dock      = DockStyle.Fill;
            pnlCartGrid.Name      = "pnlCartGrid";
            pnlCartGrid.Padding   = new Padding(10, 8, 10, 6);
            pnlCartGrid.TabIndex  = 0;

            // ── dgvCart ──────────────────────────────────────────────────────
            dgvCart.AllowUserToAddRows            = false;
            dgvCart.AllowUserToDeleteRows         = false;
            dgvCart.AllowUserToResizeRows         = false;
            dgvCart.BackgroundColor               = Color.White;
            dgvCart.BorderStyle                   = BorderStyle.None;
            dgvCart.CellBorderStyle               = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCart.ColumnHeadersBorderStyle      = DataGridViewHeaderBorderStyle.None;
            dgvCart.ColumnHeadersHeight           = 36;
            dgvCart.ColumnHeadersHeightSizeMode   = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCart.Dock                          = DockStyle.Fill;
            dgvCart.EnableHeadersVisualStyles     = false;
            dgvCart.GridColor                     = Color.FromArgb(226, 232, 240);
            dgvCart.MultiSelect                   = false;
            dgvCart.Name                          = "dgvCart";
            dgvCart.ReadOnly                      = true;
            dgvCart.RowHeadersVisible             = false;
            dgvCart.RowTemplate.Height            = 36;
            dgvCart.SelectionMode                 = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.TabIndex                      = 0;
            dgvCart.ColumnHeadersDefaultCellStyle.BackColor          = Color.FromArgb(241, 245, 249);
            dgvCart.ColumnHeadersDefaultCellStyle.ForeColor          = Color.FromArgb(100, 116, 139);
            dgvCart.ColumnHeadersDefaultCellStyle.Font               = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvCart.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dgvCart.ColumnHeadersDefaultCellStyle.Padding            = new Padding(6, 0, 0, 0);
            dgvCart.DefaultCellStyle.Font                            = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvCart.DefaultCellStyle.Padding                         = new Padding(4, 0, 4, 0);
            dgvCart.AlternatingRowsDefaultCellStyle.BackColor        = Color.FromArgb(248, 250, 252);

            // ── pnlSummary ───────────────────────────────────────────────────
            pnlSummary.BackColor = Color.White;
            pnlSummary.Controls.Add(lblDiscountLabel);
            pnlSummary.Controls.Add(nudDiscount);
            pnlSummary.Controls.Add(lblLoyalty);
            pnlSummary.Controls.Add(lblPaymentLabel);
            pnlSummary.Controls.Add(cboPayment);
            pnlSummary.Controls.Add(lblTotalCaption);
            pnlSummary.Controls.Add(lblTotal);
            pnlSummary.Controls.Add(btnCompleteSale);
            pnlSummary.Controls.Add(pnlSummaryBorder);
            pnlSummary.Dock      = DockStyle.Bottom;
            pnlSummary.Name      = "pnlSummary";
            pnlSummary.Size      = new Size(679, 185);
            pnlSummary.TabIndex  = 1;

            // ── pnlSummaryBorder ─────────────────────────────────────────────
            pnlSummaryBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlSummaryBorder.Dock      = DockStyle.Top;
            pnlSummaryBorder.Name      = "pnlSummaryBorder";
            pnlSummaryBorder.Size      = new Size(679, 1);
            pnlSummaryBorder.TabIndex  = 0;

            // ── lblDiscountLabel ─────────────────────────────────────────────
            lblDiscountLabel.AutoSize  = false;
            lblDiscountLabel.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscountLabel.ForeColor = Color.FromArgb(100, 116, 139);
            lblDiscountLabel.Location  = new Point(14, 16);
            lblDiscountLabel.Name      = "lblDiscountLabel";
            lblDiscountLabel.Size      = new Size(80, 26);
            lblDiscountLabel.TabIndex  = 1;
            lblDiscountLabel.Text      = "Discount:";
            lblDiscountLabel.TextAlign = ContentAlignment.MiddleRight;

            // ── lblLoyalty ───────────────────────────────────────────────────
            lblLoyalty.AutoSize  = true;
            lblLoyalty.Font      = new Font("Segoe UI", 8.5F, FontStyle.Italic, GraphicsUnit.Point);
            lblLoyalty.ForeColor = Color.FromArgb(22, 163, 74);
            lblLoyalty.Location  = new Point(236, 19);
            lblLoyalty.Name      = "lblLoyalty";
            lblLoyalty.TabIndex  = 10;
            lblLoyalty.Text      = "✓ 5% loyalty discount";
            lblLoyalty.Visible   = false;

            // ── nudDiscount ──────────────────────────────────────────────────
            nudDiscount.DecimalPlaces    = 2;
            nudDiscount.Font             = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nudDiscount.Location         = new Point(98, 14);
            nudDiscount.Maximum          = 999999;
            nudDiscount.Minimum          = 0;
            nudDiscount.Name             = "nudDiscount";
            nudDiscount.Size             = new Size(130, 28);
            nudDiscount.TabIndex         = 2;
            nudDiscount.ThousandsSeparator = true;
            nudDiscount.ValueChanged    += new EventHandler(nudDiscount_ValueChanged);

            // ── lblPaymentLabel ──────────────────────────────────────────────
            lblPaymentLabel.AutoSize  = false;
            lblPaymentLabel.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentLabel.ForeColor = Color.FromArgb(100, 116, 139);
            lblPaymentLabel.Location  = new Point(14, 54);
            lblPaymentLabel.Name      = "lblPaymentLabel";
            lblPaymentLabel.Size      = new Size(80, 26);
            lblPaymentLabel.TabIndex  = 3;
            lblPaymentLabel.Text      = "Payment:";
            lblPaymentLabel.TextAlign = ContentAlignment.MiddleRight;

            // ── cboPayment ───────────────────────────────────────────────────
            cboPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPayment.Font          = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            cboPayment.FlatStyle     = FlatStyle.Flat;
            cboPayment.Items.AddRange(new object[] { "Cash", "Card" });
            cboPayment.Location      = new Point(98, 52);
            cboPayment.Name          = "cboPayment";
            cboPayment.Size          = new Size(160, 27);
            cboPayment.TabIndex      = 4;

            // ── lblTotalCaption ──────────────────────────────────────────────
            lblTotalCaption.AutoSize  = false;
            lblTotalCaption.Font      = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCaption.ForeColor = Color.FromArgb(30, 41, 59);
            lblTotalCaption.Location  = new Point(14, 96);
            lblTotalCaption.Name      = "lblTotalCaption";
            lblTotalCaption.Size      = new Size(80, 36);
            lblTotalCaption.TabIndex  = 5;
            lblTotalCaption.Text      = "TOTAL";
            lblTotalCaption.TextAlign = ContentAlignment.MiddleLeft;

            // ── lblTotal ─────────────────────────────────────────────────────
            lblTotal.Anchor    = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize  = false;
            lblTotal.Font      = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(5, 150, 105);
            lblTotal.Location  = new Point(98, 88);
            lblTotal.Name      = "lblTotal";
            lblTotal.Size      = new Size(565, 46);
            lblTotal.TabIndex  = 6;
            lblTotal.Text      = "$0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;

            // ── btnCompleteSale ──────────────────────────────────────────────
            btnCompleteSale.BackColor                    = Color.FromArgb(5, 150, 105);
            btnCompleteSale.Dock                         = DockStyle.Bottom;
            btnCompleteSale.FlatStyle                    = FlatStyle.Flat;
            btnCompleteSale.FlatAppearance.BorderSize    = 0;
            btnCompleteSale.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 120, 87);
            btnCompleteSale.Font                         = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompleteSale.ForeColor                    = Color.White;
            btnCompleteSale.Name                         = "btnCompleteSale";
            btnCompleteSale.Size                         = new Size(679, 46);
            btnCompleteSale.TabIndex                     = 7;
            btnCompleteSale.Text                         = "Complete Sale";
            btnCompleteSale.UseVisualStyleBackColor      = false;
            btnCompleteSale.Cursor                       = Cursors.Hand;
            btnCompleteSale.Click                       += new EventHandler(btnCompleteSale_Click);

            // ── frmNewSale ───────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.FromArgb(241, 245, 249);
            ClientSize          = new Size(1100, 700);
            // Dock order: Fill → Top-border → Top
            Controls.Add(pnlBody);
            Controls.Add(pnlToolbarBorder);
            Controls.Add(pnlToolbar);
            Name = "frmNewSale";
            Text = "New Sale";

            pnlToolbar.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlLeftTop.ResumeLayout(false);
            pnlProductsGrid.ResumeLayout(false);
            pnlAddBar.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlCartHeader.ResumeLayout(false);
            pnlCartGrid.ResumeLayout(false);
            pnlSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ResumeLayout(false);
        }

        private Panel           pnlToolbar;
        private Panel           pnlToolbarBorder;
        private Label           lblTitle;
        private Panel           pnlBody;
        private Panel           pnlLeft;
        private Panel           pnlLeftTop;
        private Label           lblCustomerLabel;
        private ComboBox        cboCustomer;
        private Label           lblSearchLabel;
        private TextBox         txtSearch;
        private Panel           pnlProductsGrid;
        private DataGridView    dgvProducts;
        private Panel           pnlAddBar;
        private Panel           pnlAddBarBorder;
        private Label           lblQty;
        private NumericUpDown   nudQty;
        private Button          btnAddToCart;
        private Panel           pnlBodyDivider;
        private Panel           pnlRight;
        private Panel           pnlCartHeader;
        private Panel           pnlCartHdrBorder;
        private Label           lblCartTitle;
        private Button          btnRemove;
        private Panel           pnlCartGrid;
        private DataGridView    dgvCart;
        private Panel           pnlSummary;
        private Panel           pnlSummaryBorder;
        private Label           lblDiscountLabel;
        private Label           lblLoyalty;
        private NumericUpDown   nudDiscount;
        private Label           lblPaymentLabel;
        private ComboBox        cboPayment;
        private Label           lblTotalCaption;
        private Label           lblTotal;
        private Button          btnCompleteSale;
    }
}
