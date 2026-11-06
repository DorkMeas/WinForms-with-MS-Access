namespace WinForms_with_MSAccess.Forms;

partial class UserProfile
{
    private System.ComponentModel.IContainer components = null;
    private Label lblFullName;
    private Label lblGender;
    private Label lblPhone;
    private Label lblEmail;
    private Label lblAddress;
    private TextBox txtFullName;
    private ComboBox cboGender;
    private TextBox txtPhone;
    private TextBox txtEmail;
    private TextBox txtAddress;
    private GroupBox grpTool;
    private Button btnNew;
    private Button btnSave;
    private Button btnEdit;
    private Button btnDelete;
    private DataGridView dgvUsers;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblFullName = new Label();
        lblGender = new Label();
        lblPhone = new Label();
        lblEmail = new Label();
        lblAddress = new Label();
        txtFullName = new TextBox();
        cboGender = new ComboBox();
        txtPhone = new TextBox();
        txtEmail = new TextBox();
        txtAddress = new TextBox();
        grpTool = new GroupBox();
        btnNew = new Button();
        btnSave = new Button();
        btnEdit = new Button();
        btnDelete = new Button();
        dgvUsers = new DataGridView();
        grpTool.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
        SuspendLayout();

        // lblFullName
        lblFullName.AutoSize = true;
        lblFullName.Font = new Font("Segoe UI", 10F);
        lblFullName.Location = new Point(30, 30);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new Size(70, 19);
        lblFullName.TabIndex = 0;
        lblFullName.Text = "Full Name";

        // txtFullName
        txtFullName.Font = new Font("Segoe UI", 10F);
        txtFullName.Location = new Point(120, 27);
        txtFullName.Name = "txtFullName";
        txtFullName.Size = new Size(200, 25);
        txtFullName.TabIndex = 1;

        // lblGender
        lblGender.AutoSize = true;
        lblGender.Font = new Font("Segoe UI", 10F);
        lblGender.Location = new Point(30, 70);
        lblGender.Name = "lblGender";
        lblGender.Size = new Size(52, 19);
        lblGender.TabIndex = 2;
        lblGender.Text = "Gender";

        // cboGender
        cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
        cboGender.Font = new Font("Segoe UI", 10F);
        cboGender.FormattingEnabled = true;
        cboGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
        cboGender.Location = new Point(120, 67);
        cboGender.Name = "cboGender";
        cboGender.Size = new Size(200, 25);
        cboGender.TabIndex = 3;

        // lblPhone
        lblPhone.AutoSize = true;
        lblPhone.Font = new Font("Segoe UI", 10F);
        lblPhone.Location = new Point(30, 110);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new Size(45, 19);
        lblPhone.TabIndex = 4;
        lblPhone.Text = "Phone";

        // txtPhone
        txtPhone.Font = new Font("Segoe UI", 10F);
        txtPhone.Location = new Point(120, 107);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(200, 25);
        txtPhone.TabIndex = 5;

        // lblEmail
        lblEmail.AutoSize = true;
        lblEmail.Font = new Font("Segoe UI", 10F);
        lblEmail.Location = new Point(360, 30);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(50, 19);
        lblEmail.TabIndex = 6;
        lblEmail.Text = "E-mail";

        // txtEmail
        txtEmail.Font = new Font("Segoe UI", 10F);
        txtEmail.Location = new Point(430, 27);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(200, 25);
        txtEmail.TabIndex = 7;

        // lblAddress
        lblAddress.AutoSize = true;
        lblAddress.Font = new Font("Segoe UI", 10F);
        lblAddress.Location = new Point(360, 70);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new Size(56, 19);
        lblAddress.TabIndex = 8;
        lblAddress.Text = "Address";

        // txtAddress
        txtAddress.Font = new Font("Segoe UI", 10F);
        txtAddress.Location = new Point(430, 67);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(200, 25);
        txtAddress.TabIndex = 9;

        // grpTool
        grpTool.BackColor = Color.White;
        grpTool.Controls.Add(btnNew);
        grpTool.Controls.Add(btnSave);
        grpTool.Controls.Add(btnEdit);
        grpTool.Controls.Add(btnDelete);
        grpTool.Font = new Font("Segoe UI", 9F);
        grpTool.Location = new Point(670, 15);
        grpTool.Name = "grpTool";
        grpTool.Size = new Size(160, 130);
        grpTool.TabIndex = 10;
        grpTool.TabStop = false;
        grpTool.Text = "Tool";

        // btnNew
        btnNew.BackColor = Color.FromArgb(0, 0, 128);
        btnNew.Cursor = Cursors.Hand;
        btnNew.FlatAppearance.BorderSize = 0;
        btnNew.FlatStyle = FlatStyle.Flat;
        btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnNew.ForeColor = Color.White;
        btnNew.Location = new Point(15, 25);
        btnNew.Name = "btnNew";
        btnNew.Size = new Size(60, 32);
        btnNew.TabIndex = 0;
        btnNew.Text = "New";
        btnNew.UseVisualStyleBackColor = false;
        btnNew.Click += btnNew_Click;

        // btnSave
        btnSave.BackColor = Color.FromArgb(0, 0, 128);
        btnSave.Cursor = Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(85, 25);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(60, 32);
        btnSave.TabIndex = 1;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;

        // btnEdit
        btnEdit.BackColor = Color.FromArgb(0, 0, 128);
        btnEdit.Cursor = Cursors.Hand;
        btnEdit.FlatAppearance.BorderSize = 0;
        btnEdit.FlatStyle = FlatStyle.Flat;
        btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnEdit.ForeColor = Color.White;
        btnEdit.Location = new Point(15, 70);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(60, 32);
        btnEdit.TabIndex = 2;
        btnEdit.Text = "Edit";
        btnEdit.UseVisualStyleBackColor = false;
        btnEdit.Click += btnEdit_Click;

        // btnDelete
        btnDelete.BackColor = Color.Red;
        btnDelete.Cursor = Cursors.Hand;
        btnDelete.FlatAppearance.BorderSize = 0;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(85, 70);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(60, 32);
        btnDelete.TabIndex = 3;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;

        // dgvUsers
        dgvUsers.AllowUserToAddRows = false;
        dgvUsers.AllowUserToDeleteRows = false;
        dgvUsers.BackgroundColor = Color.White;
        dgvUsers.BorderStyle = BorderStyle.FixedSingle;
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvUsers.Location = new Point(30, 160);
        dgvUsers.MultiSelect = false;
        dgvUsers.Name = "dgvUsers";
        dgvUsers.ReadOnly = true;
        dgvUsers.RowHeadersVisible = false;
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvUsers.Size = new Size(800, 280);
        dgvUsers.TabIndex = 11;

        // UserProfile
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(135, 206, 250);
        ClientSize = new Size(860, 470);
        Controls.Add(lblFullName);
        Controls.Add(txtFullName);
        Controls.Add(lblGender);
        Controls.Add(cboGender);
        Controls.Add(lblPhone);
        Controls.Add(txtPhone);
        Controls.Add(lblEmail);
        Controls.Add(txtEmail);
        Controls.Add(lblAddress);
        Controls.Add(txtAddress);
        Controls.Add(grpTool);
        Controls.Add(dgvUsers);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "UserProfile";
        StartPosition = FormStartPosition.CenterParent;
        Text = "User Profile";
        Load += UserProfile_Load;
        grpTool.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
