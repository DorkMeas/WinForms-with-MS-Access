using System.Data;
using System.Data.OleDb;

namespace WinForms_with_MSAccess.Forms;

public partial class UserProfile : Form
{
    private string ConnStr =>
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
        Path.Combine(Application.StartupPath, "dbStore.mdb");

    public UserProfile()
    {
        InitializeComponent();
    }

    private void UserProfile_Load(object sender, EventArgs e)
    {
        ClearForm();
        LoadData();
    }

    private void LoadData()
    {
        try
        {
            using var conn = new OleDbConnection(ConnStr);
            conn.Open();
            using var adapter = new OleDbDataAdapter(
                "SELECT ID, fullname, gender, phone, email, address, ustatus, utrash FROM tbUserInfo ORDER BY ID", conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            dgvUsers.DataSource = dt;

            if (dgvUsers.Columns.Count > 0)
            {
                dgvUsers.Columns["ID"].Width = 50;
                dgvUsers.Columns["fullname"].HeaderText = "Full Name";
                dgvUsers.Columns["fullname"].Width = 120;
                dgvUsers.Columns["gender"].HeaderText = "Gender";
                dgvUsers.Columns["gender"].Width = 70;
                dgvUsers.Columns["phone"].HeaderText = "Phone";
                dgvUsers.Columns["phone"].Width = 100;
                dgvUsers.Columns["email"].HeaderText = "E-mail";
                dgvUsers.Columns["email"].Width = 140;
                dgvUsers.Columns["address"].HeaderText = "Address";
                dgvUsers.Columns["address"].Width = 150;
                if (dgvUsers.Columns.Contains("ustatus"))
                    dgvUsers.Columns["ustatus"].Visible = false;
                if (dgvUsers.Columns.Contains("utrash"))
                    dgvUsers.Columns["utrash"].Visible = false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Load Error: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClearForm()
    {
        txtFullName.Clear();
        cboGender.SelectedIndex = -1;
        txtPhone.Clear();
        txtEmail.Clear();
        txtAddress.Clear();
        txtFullName.Focus();
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtFullName.Text))
        {
            MessageBox.Show("Please enter Full Name.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtFullName.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(cboGender.Text))
        {
            MessageBox.Show("Please select Gender.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboGender.Focus();
            return;
        }

        try
        {
            using var conn = new OleDbConnection(ConnStr);
            conn.Open();

            string sql = "INSERT INTO tbUserInfo (fullname, gender, phone, email, address, ustatus, utrash) " +
                         "VALUES (?, ?, ?, ?, ?, ?, ?)";

            using var cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("?", txtFullName.Text.Trim());
            cmd.Parameters.AddWithValue("?", cboGender.Text.Trim());
            cmd.Parameters.AddWithValue("?", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("?", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("?", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("?", "Active");
            cmd.Parameters.AddWithValue("?", "0");

            cmd.ExecuteNonQuery();

            MessageBox.Show("User Account Successfully Created",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            LoadData();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Insert Error: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Edit function is not available yet.\n(Only Insert is implemented)",
            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Delete function is not available yet.\n(Only Insert is implemented)",
            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
