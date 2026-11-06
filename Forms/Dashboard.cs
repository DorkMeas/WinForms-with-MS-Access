using System.Data;
using System.Data.OleDb;

namespace WinForms_with_MSAccess.Forms;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private void btnOpenConnection_Click(object sender, EventArgs e)
    {
        string dbPath = Path.Combine(Application.StartupPath, "dbStore.mdb");
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath;

        try
        {
            using var conn = new OleDbConnection(connStr);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection is successfully! Database is Opening!",
                    "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Connection Error: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnOpenUser_Click(object sender, EventArgs e)
    {
        var frm = new UserProfile();
        frm.ShowDialog();
    }
}
