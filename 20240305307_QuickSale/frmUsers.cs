using QuickSale.BLL.Managers;
using QuickSale.DAL;
using QuickSale.DAL.Models;
using QuickSale.DAL.Repositories;

namespace _20240305307_QuickSale;

public partial class frmUsers : Form
{
    private readonly UserManager _userManager;
    private List<User> _allUsers = new();

    public frmUsers()
    {
        InitializeComponent();
        var ctx      = new AppDbContext();
        _userManager = new UserManager(new UserRepository(ctx));
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        SetupGrid();
        ApplyRolePermissions();
        LoadUsers();
    }

    // ── Grid setup ────────────────────────────────────────────────────────────

    private void SetupGrid()
    {
        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colId", HeaderText = "ID", Width = 58,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colUsername", HeaderText = "Username",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 60
        });
        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colRole", HeaderText = "Role", Width = 120,
            DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
    }

    // ── Data ─────────────────────────────────────────────────────────────────

    private void LoadUsers()
    {
        try
        {
            _allUsers = _userManager.GetAllUsers();
            PopulateGrid(_allUsers);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load users:\n{ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void PopulateGrid(List<User> users)
    {
        dgvUsers.SuspendLayout();
        dgvUsers.Rows.Clear();

        foreach (var u in users)
        {
            int idx = dgvUsers.Rows.Add(u.UserId, u.Username, u.Role);
            if (u.Role == "Admin")
            {
                dgvUsers.Rows[idx].DefaultCellStyle.ForeColor          = Color.FromArgb(37, 99, 235);
                dgvUsers.Rows[idx].DefaultCellStyle.SelectionForeColor = Color.FromArgb(29, 78, 216);
            }
        }

        dgvUsers.ResumeLayout();
        lblStatus.Text = $"{users.Count} user{(users.Count == 1 ? "" : "s")}";
    }

    // ── Role permissions ──────────────────────────────────────────────────────

    private void ApplyRolePermissions()
    {
        bool admin        = Session.IsAdmin;
        btnAdd.Visible    = admin;
        btnEdit.Visible   = admin;
        btnDelete.Visible = admin;
        lblReadOnly.Visible = !admin;
    }

    // ── Selection ────────────────────────────────────────────────────────────

    private User? GetSelectedUser()
    {
        if (dgvUsers.SelectedRows.Count == 0) return null;
        var id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["colId"].Value);
        return _allUsers.FirstOrDefault(u => u.UserId == id);
    }

    // ── Events ───────────────────────────────────────────────────────────────

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using var dlg = new frmUserEdit();
        if (dlg.ShowDialog(this) != DialogResult.OK) return;

        try
        {
            _userManager.AddUser(dlg.UserName, dlg.Password!, dlg.Role);
            LoadUsers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        var user = GetSelectedUser();
        if (user is null)
        {
            MessageBox.Show("Please select a user to edit.",
                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var dlg = new frmUserEdit(user);
        if (dlg.ShowDialog(this) != DialogResult.OK) return;

        try
        {
            _userManager.UpdateUser(user.UserId, dlg.UserName, dlg.Password, dlg.Role);
            LoadUsers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var user = GetSelectedUser();
        if (user is null)
        {
            MessageBox.Show("Please select a user to delete.",
                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (user.UserId == Session.CurrentUser?.UserId)
        {
            MessageBox.Show("You cannot delete your own account.",
                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirm = MessageBox.Show(
            $"Delete user \"{user.Username}\"?\nThis cannot be undone.",
            "Confirm Delete", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

        if (confirm != DialogResult.Yes) return;

        try
        {
            _userManager.DeleteUser(user.UserId);
            LoadUsers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && Session.IsAdmin)
            btnEdit_Click(sender, e);
    }
}
