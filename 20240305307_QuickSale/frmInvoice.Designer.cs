namespace _20240305307_QuickSale
{
    partial class frmInvoice
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader      = new Panel();
            lblSaleId      = new Label();
            lblDate        = new Label();
            pnlInfo        = new Panel();
            lblCustCaption = new Label();
            lblCustomer    = new Label();
            lblCashCaption = new Label();
            lblCashier     = new Label();
            lblPayCaption  = new Label();
            lblPayment     = new Label();
            pnlInfoBorder  = new Panel();
            pnlGrid        = new Panel();
            dgvItems       = new DataGridView();
            pnlSummary     = new Panel();
            pnlSummBorder  = new Panel();
            lblSubtotalCap = new Label();
            lblSubtotal    = new Label();
            lblDiscountCap = new Label();
            lblDiscount    = new Label();
            pnlTotalLine   = new Panel();
            lblTotalCap    = new Label();
            lblTotal       = new Label();
            pnlButtons     = new Panel();
            pnlBtnBorder   = new Panel();
            btnPrint       = new Button();
            btnClose       = new Button();

            pnlHeader.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlGrid.SuspendLayout();
            pnlSummary.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();

            // ── pnlHeader ────────────────────────────────────────────────────
            pnlHeader.BackColor = Color.FromArgb(37, 99, 235);
            pnlHeader.Controls.Add(lblSaleId);
            pnlHeader.Controls.Add(lblDate);
            pnlHeader.Dock      = DockStyle.Top;
            pnlHeader.Name      = "pnlHeader";
            pnlHeader.Size      = new Size(640, 68);
            pnlHeader.TabIndex  = 0;

            lblSaleId.AutoSize  = false;
            lblSaleId.Font      = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaleId.ForeColor = Color.White;
            lblSaleId.Location  = new Point(20, 6);
            lblSaleId.Name      = "lblSaleId";
            lblSaleId.Size      = new Size(600, 32);
            lblSaleId.TabIndex  = 0;
            lblSaleId.Text      = "Invoice #";

            lblDate.AutoSize  = false;
            lblDate.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.FromArgb(191, 219, 254);
            lblDate.Location  = new Point(20, 40);
            lblDate.Name      = "lblDate";
            lblDate.Size      = new Size(600, 20);
            lblDate.TabIndex  = 1;

            // ── pnlInfo ──────────────────────────────────────────────────────
            pnlInfo.BackColor = Color.FromArgb(248, 250, 252);
            pnlInfo.Controls.Add(lblCustCaption);
            pnlInfo.Controls.Add(lblCustomer);
            pnlInfo.Controls.Add(lblCashCaption);
            pnlInfo.Controls.Add(lblCashier);
            pnlInfo.Controls.Add(lblPayCaption);
            pnlInfo.Controls.Add(lblPayment);
            pnlInfo.Controls.Add(pnlInfoBorder);
            pnlInfo.Dock      = DockStyle.Top;
            pnlInfo.Name      = "pnlInfo";
            pnlInfo.Size      = new Size(640, 58);
            pnlInfo.TabIndex  = 1;

            pnlInfoBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlInfoBorder.Dock      = DockStyle.Bottom;
            pnlInfoBorder.Name      = "pnlInfoBorder";
            pnlInfoBorder.Size      = new Size(640, 1);
            pnlInfoBorder.TabIndex  = 5;

            void InfoLabel(Label lbl, string name, int x, bool bold = false)
            {
                lbl.AutoSize  = false;
                lbl.Font      = new Font("Segoe UI", 8.5F,
                    bold ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point);
                lbl.ForeColor = bold ? Color.FromArgb(100, 116, 139) : Color.FromArgb(30, 41, 59);
                lbl.Location  = new Point(x, 12);
                lbl.Name      = name;
                lbl.Size      = new Size(bold ? 72 : 130, 34);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
            }

            InfoLabel(lblCustCaption, "lblCustCaption", 14,  true);  lblCustCaption.Text = "Customer";
            InfoLabel(lblCustomer,    "lblCustomer",    88,  false);
            InfoLabel(lblCashCaption, "lblCashCaption", 240, true);   lblCashCaption.Text = "Cashier";  lblCashCaption.Size = new Size(65, 34);
            InfoLabel(lblCashier,     "lblCashier",     308, false);  lblCashier.Size = new Size(110, 34);
            InfoLabel(lblPayCaption,  "lblPayCaption",  430, true);   lblPayCaption.Text = "Payment";
            InfoLabel(lblPayment,     "lblPayment",     504, false);

            // ── pnlGrid ──────────────────────────────────────────────────────
            pnlGrid.BackColor = Color.FromArgb(241, 245, 249);
            pnlGrid.Controls.Add(dgvItems);
            pnlGrid.Dock      = DockStyle.Fill;
            pnlGrid.Name      = "pnlGrid";
            pnlGrid.Padding   = new Padding(10, 8, 10, 6);
            pnlGrid.TabIndex  = 2;

            dgvItems.AllowUserToAddRows            = false;
            dgvItems.AllowUserToDeleteRows         = false;
            dgvItems.AllowUserToResizeRows         = false;
            dgvItems.BackgroundColor               = Color.White;
            dgvItems.BorderStyle                   = BorderStyle.None;
            dgvItems.CellBorderStyle               = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItems.ColumnHeadersBorderStyle      = DataGridViewHeaderBorderStyle.None;
            dgvItems.ColumnHeadersHeight           = 36;
            dgvItems.ColumnHeadersHeightSizeMode   = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItems.Dock                          = DockStyle.Fill;
            dgvItems.EnableHeadersVisualStyles     = false;
            dgvItems.GridColor                     = Color.FromArgb(226, 232, 240);
            dgvItems.MultiSelect                   = false;
            dgvItems.Name                          = "dgvItems";
            dgvItems.ReadOnly                      = true;
            dgvItems.RowHeadersVisible             = false;
            dgvItems.RowTemplate.Height            = 36;
            dgvItems.SelectionMode                 = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.TabIndex                      = 0;
            dgvItems.ColumnHeadersDefaultCellStyle.BackColor          = Color.FromArgb(30, 41, 59);
            dgvItems.ColumnHeadersDefaultCellStyle.ForeColor          = Color.White;
            dgvItems.ColumnHeadersDefaultCellStyle.Font               = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvItems.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dgvItems.ColumnHeadersDefaultCellStyle.Padding            = new Padding(6, 0, 0, 0);
            dgvItems.DefaultCellStyle.Font                            = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvItems.DefaultCellStyle.Padding                         = new Padding(4, 0, 4, 0);
            dgvItems.AlternatingRowsDefaultCellStyle.BackColor        = Color.FromArgb(248, 250, 252);

            // ── pnlSummary ───────────────────────────────────────────────────
            pnlSummary.BackColor = Color.White;
            pnlSummary.Controls.Add(lblSubtotalCap);
            pnlSummary.Controls.Add(lblSubtotal);
            pnlSummary.Controls.Add(lblDiscountCap);
            pnlSummary.Controls.Add(lblDiscount);
            pnlSummary.Controls.Add(pnlTotalLine);
            pnlSummary.Controls.Add(lblTotalCap);
            pnlSummary.Controls.Add(lblTotal);
            pnlSummary.Controls.Add(pnlSummBorder);
            pnlSummary.Dock      = DockStyle.Bottom;
            pnlSummary.Name      = "pnlSummary";
            pnlSummary.Size      = new Size(640, 120);
            pnlSummary.TabIndex  = 3;

            pnlSummBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlSummBorder.Dock      = DockStyle.Top;
            pnlSummBorder.Name      = "pnlSummBorder";
            pnlSummBorder.Size      = new Size(640, 1);
            pnlSummBorder.TabIndex  = 0;

            void SummLabel(Label lbl, string name, int y, bool bold, bool right)
            {
                lbl.AutoSize  = false;
                lbl.Font      = new Font("Segoe UI", bold ? 9F : 9F,
                    bold ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point);
                lbl.ForeColor = Color.FromArgb(bold ? 100 : 30, bold ? 116 : 41, bold ? 139 : 59);
                lbl.Location  = new Point(right ? 500 : 370, y);
                lbl.Name      = name;
                lbl.Size      = new Size(right ? 128 : 128, 22);
                lbl.TextAlign = right ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;
                lbl.TabIndex  = 1;
            }

            SummLabel(lblSubtotalCap, "lblSubtotalCap", 14, true,  false); lblSubtotalCap.Text = "Subtotal";
            SummLabel(lblSubtotal,    "lblSubtotal",    14, false, true);
            SummLabel(lblDiscountCap, "lblDiscountCap", 40, true,  false); lblDiscountCap.Text = "Discount";
            SummLabel(lblDiscount,    "lblDiscount",    40, false, true);
            lblDiscount.ForeColor = Color.FromArgb(220, 38, 38);

            pnlTotalLine.BackColor = Color.FromArgb(226, 232, 240);
            pnlTotalLine.Location  = new Point(365, 68);
            pnlTotalLine.Name      = "pnlTotalLine";
            pnlTotalLine.Size      = new Size(268, 1);
            pnlTotalLine.TabIndex  = 5;

            lblTotalCap.AutoSize  = false;
            lblTotalCap.Font      = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCap.ForeColor = Color.FromArgb(30, 41, 59);
            lblTotalCap.Location  = new Point(370, 74);
            lblTotalCap.Name      = "lblTotalCap";
            lblTotalCap.Size      = new Size(120, 34);
            lblTotalCap.TabIndex  = 6;
            lblTotalCap.Text      = "TOTAL";
            lblTotalCap.TextAlign = ContentAlignment.MiddleLeft;

            lblTotal.AutoSize  = false;
            lblTotal.Font      = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(5, 150, 105);
            lblTotal.Location  = new Point(370, 68);
            lblTotal.Name      = "lblTotal";
            lblTotal.Size      = new Size(258, 44);
            lblTotal.TabIndex  = 7;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;

            // ── pnlButtons ───────────────────────────────────────────────────
            pnlButtons.BackColor = Color.White;
            pnlButtons.Controls.Add(btnClose);
            pnlButtons.Controls.Add(btnPrint);
            pnlButtons.Controls.Add(pnlBtnBorder);
            pnlButtons.Dock      = DockStyle.Bottom;
            pnlButtons.Name      = "pnlButtons";
            pnlButtons.Size      = new Size(640, 54);
            pnlButtons.TabIndex  = 4;

            pnlBtnBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlBtnBorder.Dock      = DockStyle.Top;
            pnlBtnBorder.Name      = "pnlBtnBorder";
            pnlBtnBorder.Size      = new Size(640, 1);
            pnlBtnBorder.TabIndex  = 0;

            btnPrint.BackColor                    = Color.White;
            btnPrint.FlatStyle                    = FlatStyle.Flat;
            btnPrint.FlatAppearance.BorderColor   = Color.FromArgb(37, 99, 235);
            btnPrint.FlatAppearance.BorderSize    = 1;
            btnPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 246, 255);
            btnPrint.Font                         = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor                    = Color.FromArgb(37, 99, 235);
            btnPrint.Location                     = new Point(14, 10);
            btnPrint.Name                         = "btnPrint";
            btnPrint.Size                         = new Size(120, 34);
            btnPrint.TabIndex                     = 1;
            btnPrint.Text                         = "Print";
            btnPrint.UseVisualStyleBackColor      = false;
            btnPrint.Cursor                       = Cursors.Hand;
            btnPrint.Click                       += new EventHandler(btnPrint_Click);

            btnClose.Anchor                          = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor                       = Color.FromArgb(37, 99, 235);
            btnClose.FlatStyle                       = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize       = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnClose.Font                            = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor                       = Color.White;
            btnClose.Location                        = new Point(500, 10);
            btnClose.Name                            = "btnClose";
            btnClose.Size                            = new Size(126, 34);
            btnClose.TabIndex                        = 2;
            btnClose.Text                            = "Close";
            btnClose.UseVisualStyleBackColor         = false;
            btnClose.Cursor                          = Cursors.Hand;
            btnClose.Click                          += new EventHandler(btnClose_Click);

            // ── frmInvoice ───────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.White;
            ClientSize          = new Size(640, 580);
            Controls.Add(pnlGrid);
            Controls.Add(pnlSummary);
            Controls.Add(pnlButtons);
            Controls.Add(pnlInfo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox     = false;
            Name            = "frmInvoice";
            StartPosition   = FormStartPosition.CenterParent;
            Text            = "Invoice";

            pnlHeader.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            pnlSummary.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        private Panel        pnlHeader;
        private Label        lblSaleId;
        private Label        lblDate;
        private Panel        pnlInfo;
        private Label        lblCustCaption;
        private Label        lblCustomer;
        private Label        lblCashCaption;
        private Label        lblCashier;
        private Label        lblPayCaption;
        private Label        lblPayment;
        private Panel        pnlInfoBorder;
        private Panel        pnlGrid;
        private DataGridView dgvItems;
        private Panel        pnlSummary;
        private Panel        pnlSummBorder;
        private Label        lblSubtotalCap;
        private Label        lblSubtotal;
        private Label        lblDiscountCap;
        private Label        lblDiscount;
        private Panel        pnlTotalLine;
        private Label        lblTotalCap;
        private Label        lblTotal;
        private Panel        pnlButtons;
        private Panel        pnlBtnBorder;
        private Button       btnPrint;
        private Button       btnClose;
    }
}
