namespace _20240305307_QuickSale
{
    partial class frmUsers
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
            lblReadOnly      = new Label();
            btnAdd           = new Button();
            btnEdit          = new Button();
            btnDelete        = new Button();
            pnlStatus        = new Panel();
            pnlStatusBorder  = new Panel();
            lblStatus        = new Label();
            pnlGrid          = new Panel();
            dgvUsers         = new DataGridView();

            pnlToolbar.SuspendLayout();
            pnlStatus.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();

            // ── pnlToolbar ───────────────────────────────────────────────────
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(lblPageTitle);
            pnlToolbar.Controls.Add(lblReadOnly);
            pnlToolbar.Controls.Add(btnAdd);
            pnlToolbar.Controls.Add(btnEdit);
            pnlToolbar.Controls.Add(btnDelete);
            pnlToolbar.Dock     = DockStyle.Top;
            pnlToolbar.Name     = "pnlToolbar";
            pnlToolbar.Size     = new Size(1060, 64);
            pnlToolbar.TabIndex = 0;

            lblPageTitle.AutoSize  = false;
            lblPageTitle.Font      = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblPageTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblPageTitle.Location  = new Point(20, 0);
            lblPageTitle.Name      = "lblPageTitle";
            lblPageTitle.Size      = new Size(220, 64);
            lblPageTitle.TabIndex  = 0;
            lblPageTitle.Text      = "User Management";
            lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;

            lblReadOnly.AutoSize  = false;
            lblReadOnly.Font      = new Font("Segoe UI", 8.5F, FontStyle.Italic, GraphicsUnit.Point);
            lblReadOnly.ForeColor = Color.FromArgb(185, 28, 28);
            lblReadOnly.Location  = new Point(248, 24);
            lblReadOnly.Name      = "lblReadOnly";
            lblReadOnly.Size      = new Size(110, 18);
            lblReadOnly.TabIndex  = 1;
            lblReadOnly.Text      = "(Read Only)";
            lblReadOnly.Visible   = false;

            btnAdd.Anchor                       = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor                    = Color.FromArgb(37, 99, 235);
            btnAdd.FlatStyle                    = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize    = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnAdd.Font                         = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor                    = Color.White;
            btnAdd.Location                     = new Point(792, 14);
            btnAdd.Name                         = "btnAdd";
            btnAdd.Size                         = new Size(76, 36);
            btnAdd.TabIndex                     = 2;
            btnAdd.Text                         = "+ Add";
            btnAdd.UseVisualStyleBackColor      = false;
            btnAdd.Cursor                       = Cursors.Hand;
            btnAdd.Click                       += new EventHandler(btnAdd_Click);

            btnEdit.Anchor                          = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor                       = Color.White;
            btnEdit.FlatStyle                       = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderColor      = Color.FromArgb(37, 99, 235);
            btnEdit.FlatAppearance.BorderSize       = 1;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 246, 255);
            btnEdit.Font                            = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor                       = Color.FromArgb(37, 99, 235);
            btnEdit.Location                        = new Point(876, 14);
            btnEdit.Name                            = "btnEdit";
            btnEdit.Size                            = new Size(76, 36);
            btnEdit.TabIndex                        = 3;
            btnEdit.Text                            = "Edit";
            btnEdit.UseVisualStyleBackColor         = false;
            btnEdit.Cursor                          = Cursors.Hand;
            btnEdit.Click                          += new EventHandler(btnEdit_Click);

            btnDelete.Anchor                          = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor                       = Color.White;
            btnDelete.FlatStyle                       = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderColor      = Color.FromArgb(220, 38, 38);
            btnDelete.FlatAppearance.BorderSize       = 1;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
            btnDelete.Font                            = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor                       = Color.FromArgb(220, 38, 38);
            btnDelete.Location                        = new Point(960, 14);
            btnDelete.Name                            = "btnDelete";
            btnDelete.Size                            = new Size(84, 36);
            btnDelete.TabIndex                        = 4;
            btnDelete.Text                            = "Delete";
            btnDelete.UseVisualStyleBackColor         = false;
            btnDelete.Cursor                          = Cursors.Hand;
            btnDelete.Click                          += new EventHandler(btnDelete_Click);

            // ── pnlToolbarBorder ─────────────────────────────────────────────
            pnlToolbarBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlToolbarBorder.Dock      = DockStyle.Top;
            pnlToolbarBorder.Name      = "pnlToolbarBorder";
            pnlToolbarBorder.Size      = new Size(1060, 1);
            pnlToolbarBorder.TabIndex  = 1;

            // ── pnlStatus ────────────────────────────────────────────────────
            pnlStatus.BackColor = Color.White;
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.Controls.Add(pnlStatusBorder);
            pnlStatus.Dock      = DockStyle.Bottom;
            pnlStatus.Name      = "pnlStatus";
            pnlStatus.Size      = new Size(1060, 36);
            pnlStatus.TabIndex  = 2;

            pnlStatusBorder.BackColor = Color.FromArgb(226, 232, 240);
            pnlStatusBorder.Dock      = DockStyle.Top;
            pnlStatusBorder.Name      = "pnlStatusBorder";
            pnlStatusBorder.Size      = new Size(1060, 1);
            pnlStatusBorder.TabIndex  = 0;

            lblStatus.Dock      = DockStyle.Fill;
            lblStatus.Font      = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatus.Name      = "lblStatus";
            lblStatus.Padding   = new Padding(12, 0, 0, 0);
            lblStatus.TabIndex  = 1;
            lblStatus.Text      = "Loading…";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            // ── pnlGrid ──────────────────────────────────────────────────────
            pnlGrid.BackColor = Color.FromArgb(241, 245, 249);
            pnlGrid.Controls.Add(dgvUsers);
            pnlGrid.Dock      = DockStyle.Fill;
            pnlGrid.Name      = "pnlGrid";
            pnlGrid.Padding   = new Padding(12, 8, 12, 12);
            pnlGrid.TabIndex  = 3;

            // ── dgvUsers ─────────────────────────────────────────────────────
            dgvUsers.AllowUserToAddRows            = false;
            dgvUsers.AllowUserToDeleteRows         = false;
            dgvUsers.AllowUserToResizeRows         = false;
            dgvUsers.BackgroundColor               = Color.White;
            dgvUsers.BorderStyle                   = BorderStyle.None;
            dgvUsers.CellBorderStyle               = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ColumnHeadersBorderStyle      = DataGridViewHeaderBorderStyle.None;
            dgvUsers.ColumnHeadersHeight           = 40;
            dgvUsers.ColumnHeadersHeightSizeMode   = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Dock                          = DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles     = false;
            dgvUsers.GridColor                     = Color.FromArgb(226, 232, 240);
            dgvUsers.MultiSelect                   = false;
            dgvUsers.Name                          = "dgvUsers";
            dgvUsers.ReadOnly                      = true;
            dgvUsers.RowHeadersVisible             = false;
            dgvUsers.RowTemplate.Height            = 38;
            dgvUsers.SelectionMode                 = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.TabIndex                      = 0;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor          = Color.FromArgb(241, 245, 249);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor          = Color.FromArgb(100, 116, 139);
            dgvUsers.ColumnHeadersDefaultCellStyle.Font               = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dgvUsers.ColumnHeadersDefaultCellStyle.Padding            = new Padding(6, 0, 0, 0);
            dgvUsers.DefaultCellStyle.Font                            = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dgvUsers.DefaultCellStyle.Padding                         = new Padding(6, 0, 6, 0);
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor        = Color.FromArgb(248, 250, 252);
            dgvUsers.CellDoubleClick += new DataGridViewCellEventHandler(dgvUsers_CellDoubleClick);

            // ── frmUsers ─────────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.FromArgb(241, 245, 249);
            ClientSize          = new Size(1060, 703);
            Controls.Add(pnlGrid);
            Controls.Add(pnlStatus);
            Controls.Add(pnlToolbarBorder);
            Controls.Add(pnlToolbar);
            Name = "frmUsers";
            Text = "Users";

            pnlToolbar.ResumeLayout(false);
            pnlStatus.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        private Panel        pnlToolbar;
        private Panel        pnlToolbarBorder;
        private Label        lblPageTitle;
        private Label        lblReadOnly;
        private Button       btnAdd;
        private Button       btnEdit;
        private Button       btnDelete;
        private Panel        pnlStatus;
        private Panel        pnlStatusBorder;
        private Label        lblStatus;
        private Panel        pnlGrid;
        private DataGridView dgvUsers;
    }
}
