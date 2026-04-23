namespace _20240305307_QuickSale
{
    partial class frmReports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlToolbar       = new Panel();
            pnlToolbarBorder = new Panel();
            lblPageTitle     = new Label();
            lblDateLabel     = new Label();
            dtpDate          = new DateTimePicker();
            btnLoad          = new Button();
            pnlSummary       = new Panel();
            pnlSummaryBorder = new Panel();
            pnlCardRevenue   = new Panel();
            lblRevCaption    = new Label();
            lblRevenue       = new Label();
            pnlCardTx        = new Panel();
            lblTxCaption     = new Label();
            lblTransactions  = new Label();
            pnlGrid          = new Panel();
            lblNoData        = new Label();
            dgvSales         = new DataGridView();
            pnlBottom        = new Panel();
            pnlBottomBorder  = new Panel();
            btnViewDetails   = new Button();

            pnlToolbar.SuspendLayout();
            pnlSummary.SuspendLayout();
            pnlCardRevenue.SuspendLayout();
            pnlCardTx.SuspendLayout();
            pnlGrid.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();

            // ── pnlToolbar ───────────────────────────────────────────────────
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(lblPageTitle);
            pnlToolbar.Controls.Add(lblDateLabel);
            pnlToolbar.Controls.Add(dtpDate);
            pnlToolbar.Controls.Add(btnLoad);
            pnlToolbar.Dock      = DockStyle.Top;
            pnlToolbar.Name      = "pnlToolbar";
            pnlToolbar.Size      = new Size(1060, 64);
            pnlToolbar.TabIndex  = 0;

            lblPageTitle.AutoSize  = false;
            lblPageTitle.Font      = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblPageTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblPageTitle.Location  = new Point(20, 0);
            lblPageTitle.Name      = "lblPageTitle";
            lblPageTitle.Size      = new Size(280, 64);
            lblPageTitle.TabIndex  = 0;
            lblPageTitle.Text      = "Daily Report";
            lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;

            lblDateLabel.Anchor    = AnchorStyles.Top | AnchorStyles.Right;
            lblDateLabel.AutoSize  = false;
            lblDateLabel.Font      = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateLabel.ForeColor = Color.FromArgb(100, 116, 139);
            lblDateLabel.Location  = new Point(530, 24);
            lblDateLabel.Name      = "lblDateLabel";
            lblDateLabel.Size      = new Size(40, 18);
            lblDateLabel.TabIndex  = 1;
            lblDateLabel.Text      = "Date:";
            lblDateLabel.TextAlign = ContentAlignment.MiddleRight;

            dtpDate.Anchor   = AnchorStyles.Top | AnchorStyles.Right;
            dtpDate.Font     = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDate.Format   = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(574, 18);
            dtpDate.Name     = "dtpDate";
            dtpDate.Size     = new Size(130, 26);
            dtpDate.TabIndex = 2;

            btnLoad.Anchor                       = AnchorStyles.Top | AnchorStyles.Right;
            btnLoad.BackColor                    = Color.FromArgb(37, 99, 235);
            btnLoad.FlatStyle                    = FlatStyle.Flat;
            btnLoad.FlatAppearance.BorderSize    = 0;
            btnLoad.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnLoad.Font                         = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ForeColor                    = Color.White;
            btnLoad.Location                     = new Point(718, 14);
            btnLoad.Name                         = "btnLoad";
            btnLoad.Size                         = new Size(110, 36);
            btnLoad.TabIndex                     = 3;
            btnLoad.Text                         = "Load Report";
            btnLoad.UseVisualStyleBackColor      = false;
            btnLoad.Cursor                       = Cursors.Hand;
            btnLoad.Click                       += new EventHandler(btnLoad_Click);

            // ── pnlToolbarBorder ─────────────────────────────────────────────
            pnlToolbarBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlToolbarBorder.Dock      = DockStyle.Top;
            pnlToolbarBorder.Name      = "pnlToolbarBorder";
            pnlToolbarBorder.Size      = new Size(1060, 1);
            pnlToolbarBorder.TabIndex  = 1;

            // ── pnlSummary ───────────────────────────────────────────────────
            pnlSummary.BackColor = Color.FromArgb(241, 245, 249);
            pnlSummary.Controls.Add(pnlCardRevenue);
            pnlSummary.Controls.Add(pnlCardTx);
            pnlSummary.Controls.Add(pnlSummaryBorder);
            pnlSummary.Dock      = DockStyle.Top;
            pnlSummary.Name      = "pnlSummary";
            pnlSummary.Padding   = new Padding(16, 12, 16, 12);
            pnlSummary.Size      = new Size(1060, 100);
            pnlSummary.TabIndex  = 2;

            pnlSummaryBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlSummaryBorder.Dock      = DockStyle.Bottom;
            pnlSummaryBorder.Name      = "pnlSummaryBorder";
            pnlSummaryBorder.Size      = new Size(1060, 1);
            pnlSummaryBorder.TabIndex  = 2;

            // ── pnlCardRevenue ───────────────────────────────────────────────
            pnlCardRevenue.BackColor  = Color.White;
            pnlCardRevenue.Controls.Add(lblRevCaption);
            pnlCardRevenue.Controls.Add(lblRevenue);
            pnlCardRevenue.Location   = new Point(16, 12);
            pnlCardRevenue.Name       = "pnlCardRevenue";
            pnlCardRevenue.Size       = new Size(220, 64);
            pnlCardRevenue.TabIndex   = 0;
            pnlCardRevenue.Paint     += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, pnlCardRevenue.ClientRectangle,
                    Color.FromArgb(226, 232, 240), ButtonBorderStyle.Solid);
            };

            lblRevCaption.AutoSize  = false;
            lblRevCaption.Font      = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRevCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblRevCaption.Location  = new Point(14, 10);
            lblRevCaption.Name      = "lblRevCaption";
            lblRevCaption.Size      = new Size(192, 16);
            lblRevCaption.TabIndex  = 0;
            lblRevCaption.Text      = "TOTAL REVENUE";

            lblRevenue.AutoSize  = false;
            lblRevenue.Font      = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRevenue.ForeColor = Color.FromArgb(5, 150, 105);
            lblRevenue.Location  = new Point(10, 28);
            lblRevenue.Name      = "lblRevenue";
            lblRevenue.Size      = new Size(200, 32);
            lblRevenue.TabIndex  = 1;
            lblRevenue.Text      = "—";

            // ── pnlCardTx ────────────────────────────────────────────────────
            pnlCardTx.BackColor  = Color.White;
            pnlCardTx.Controls.Add(lblTxCaption);
            pnlCardTx.Controls.Add(lblTransactions);
            pnlCardTx.Location   = new Point(252, 12);
            pnlCardTx.Name       = "pnlCardTx";
            pnlCardTx.Size       = new Size(180, 64);
            pnlCardTx.TabIndex   = 1;
            pnlCardTx.Paint     += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, pnlCardTx.ClientRectangle,
                    Color.FromArgb(226, 232, 240), ButtonBorderStyle.Solid);
            };

            lblTxCaption.AutoSize  = false;
            lblTxCaption.Font      = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTxCaption.ForeColor = Color.FromArgb(100, 116, 139);
            lblTxCaption.Location  = new Point(14, 10);
            lblTxCaption.Name      = "lblTxCaption";
            lblTxCaption.Size      = new Size(152, 16);
            lblTxCaption.TabIndex  = 0;
            lblTxCaption.Text      = "TRANSACTIONS";

            lblTransactions.AutoSize  = false;
            lblTransactions.Font      = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransactions.ForeColor = Color.FromArgb(37, 99, 235);
            lblTransactions.Location  = new Point(10, 28);
            lblTransactions.Name      = "lblTransactions";
            lblTransactions.Size      = new Size(160, 32);
            lblTransactions.TabIndex  = 1;
            lblTransactions.Text      = "—";

            // ── pnlBottom ────────────────────────────────────────────────────
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btnViewDetails);
            pnlBottom.Controls.Add(pnlBottomBorder);
            pnlBottom.Dock      = DockStyle.Bottom;
            pnlBottom.Name      = "pnlBottom";
            pnlBottom.Size      = new Size(1060, 52);
            pnlBottom.TabIndex  = 4;

            pnlBottomBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlBottomBorder.Dock      = DockStyle.Top;
            pnlBottomBorder.Name      = "pnlBottomBorder";
            pnlBottomBorder.Size      = new Size(1060, 1);
            pnlBottomBorder.TabIndex  = 0;

            btnViewDetails.BackColor                    = Color.White;
            btnViewDetails.Enabled                      = false;
            btnViewDetails.FlatStyle                    = FlatStyle.Flat;
            btnViewDetails.FlatAppearance.BorderColor   = Color.FromArgb(37, 99, 235);
            btnViewDetails.FlatAppearance.BorderSize    = 1;
            btnViewDetails.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 246, 255);
            btnViewDetails.Font                         = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewDetails.ForeColor                    = Color.FromArgb(37, 99, 235);
            btnViewDetails.Location                     = new Point(14, 9);
            btnViewDetails.Name                         = "btnViewDetails";
            btnViewDetails.Size                         = new Size(130, 34);
            btnViewDetails.TabIndex                     = 1;
            btnViewDetails.Text                         = "View Details";
            btnViewDetails.UseVisualStyleBackColor      = false;
            btnViewDetails.Cursor                       = Cursors.Hand;
            btnViewDetails.Click                       += new EventHandler(btnViewDetails_Click);

            // ── pnlGrid ──────────────────────────────────────────────────────
            pnlGrid.BackColor = Color.FromArgb(241, 245, 249);
            pnlGrid.Controls.Add(dgvSales);
            pnlGrid.Controls.Add(lblNoData);
            pnlGrid.Dock      = DockStyle.Fill;
            pnlGrid.Name      = "pnlGrid";
            pnlGrid.Padding   = new Padding(12, 8, 12, 8);
            pnlGrid.TabIndex  = 3;

            lblNoData.AutoSize  = false;
            lblNoData.Dock      = DockStyle.Fill;
            lblNoData.Font      = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoData.ForeColor = Color.FromArgb(148, 163, 184);
            lblNoData.Name      = "lblNoData";
            lblNoData.TabIndex  = 1;
            lblNoData.Text      = "No sales found for the selected date. Click \"Load Report\" to search.";
            lblNoData.TextAlign = ContentAlignment.MiddleCenter;
            lblNoData.Visible   = false;

            dgvSales.AllowUserToAddRows            = false;
            dgvSales.AllowUserToDeleteRows         = false;
            dgvSales.AllowUserToResizeRows         = false;
            dgvSales.BackgroundColor               = Color.White;
            dgvSales.BorderStyle                   = BorderStyle.None;
            dgvSales.CellBorderStyle               = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSales.ColumnHeadersBorderStyle      = DataGridViewHeaderBorderStyle.None;
            dgvSales.ColumnHeadersHeight           = 40;
            dgvSales.ColumnHeadersHeightSizeMode   = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSales.Dock                          = DockStyle.Fill;
            dgvSales.EnableHeadersVisualStyles     = false;
            dgvSales.GridColor                     = Color.FromArgb(226, 232, 240);
            dgvSales.MultiSelect                   = false;
            dgvSales.Name                          = "dgvSales";
            dgvSales.ReadOnly                      = true;
            dgvSales.RowHeadersVisible             = false;
            dgvSales.RowTemplate.Height            = 38;
            dgvSales.SelectionMode                 = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.TabIndex                      = 0;
            dgvSales.ColumnHeadersDefaultCellStyle.BackColor          = Color.FromArgb(241, 245, 249);
            dgvSales.ColumnHeadersDefaultCellStyle.ForeColor          = Color.FromArgb(100, 116, 139);
            dgvSales.ColumnHeadersDefaultCellStyle.Font               = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvSales.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dgvSales.ColumnHeadersDefaultCellStyle.Padding            = new Padding(6, 0, 0, 0);
            dgvSales.DefaultCellStyle.Font                            = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dgvSales.DefaultCellStyle.Padding                         = new Padding(6, 0, 6, 0);
            dgvSales.AlternatingRowsDefaultCellStyle.BackColor        = Color.FromArgb(248, 250, 252);
            dgvSales.SelectionChanged  += new EventHandler(dgvSales_SelectionChanged);
            dgvSales.CellDoubleClick   += new DataGridViewCellEventHandler(dgvSales_CellDoubleClick);

            // ── frmReports ───────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.FromArgb(241, 245, 249);
            ClientSize          = new Size(1060, 703);
            Controls.Add(pnlGrid);
            Controls.Add(pnlBottom);
            Controls.Add(pnlSummary);
            Controls.Add(pnlToolbarBorder);
            Controls.Add(pnlToolbar);
            Name = "frmReports";
            Text = "Reports";

            pnlToolbar.ResumeLayout(false);
            pnlSummary.ResumeLayout(false);
            pnlCardRevenue.ResumeLayout(false);
            pnlCardTx.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
        }

        private Panel          pnlToolbar;
        private Panel          pnlToolbarBorder;
        private Label          lblPageTitle;
        private Label          lblDateLabel;
        private DateTimePicker dtpDate;
        private Button         btnLoad;
        private Panel          pnlSummary;
        private Panel          pnlSummaryBorder;
        private Panel          pnlCardRevenue;
        private Label          lblRevCaption;
        private Label          lblRevenue;
        private Panel          pnlCardTx;
        private Label          lblTxCaption;
        private Label          lblTransactions;
        private Panel          pnlGrid;
        private Label          lblNoData;
        private DataGridView   dgvSales;
        private Panel          pnlBottom;
        private Panel          pnlBottomBorder;
        private Button         btnViewDetails;
    }
}
