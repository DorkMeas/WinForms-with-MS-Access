namespace WinForms_with_MSAccess.Forms;

partial class Dashboard
{
    private System.ComponentModel.IContainer components = null;
    private Button btnOpenConnection;
    private Button btnOpenUser;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        btnOpenConnection = new Button();
        btnOpenUser = new Button();
        SuspendLayout();

        // btnOpenConnection
        btnOpenConnection.BackColor = Color.FromArgb(220, 240, 255);
        btnOpenConnection.Cursor = Cursors.Hand;
        btnOpenConnection.FlatAppearance.BorderColor = Color.FromArgb(100, 149, 237);
        btnOpenConnection.FlatStyle = FlatStyle.Flat;
        btnOpenConnection.Font = new Font("Segoe UI", 11F);
        btnOpenConnection.Location = new Point(120, 320);
        btnOpenConnection.Name = "btnOpenConnection";
        btnOpenConnection.Size = new Size(160, 45);
        btnOpenConnection.TabIndex = 0;
        btnOpenConnection.Text = "Open Connection";
        btnOpenConnection.UseVisualStyleBackColor = false;
        btnOpenConnection.Click += btnOpenConnection_Click;

        // btnOpenUser
        btnOpenUser.BackColor = Color.FromArgb(220, 240, 255);
        btnOpenUser.Cursor = Cursors.Hand;
        btnOpenUser.FlatAppearance.BorderColor = Color.FromArgb(100, 149, 237);
        btnOpenUser.FlatStyle = FlatStyle.Flat;
        btnOpenUser.Font = new Font("Segoe UI", 11F);
        btnOpenUser.Location = new Point(320, 320);
        btnOpenUser.Name = "btnOpenUser";
        btnOpenUser.Size = new Size(160, 45);
        btnOpenUser.TabIndex = 1;
        btnOpenUser.Text = "Open User";
        btnOpenUser.UseVisualStyleBackColor = false;
        btnOpenUser.Click += btnOpenUser_Click;

        // Dashboard
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(135, 206, 250);
        ClientSize = new Size(600, 400);
        Controls.Add(btnOpenConnection);
        Controls.Add(btnOpenUser);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Dashboard";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dashboard";
        ResumeLayout(false);
    }
}
