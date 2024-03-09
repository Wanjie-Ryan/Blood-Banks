namespace Blood_Banks.UI
{
    partial class Donors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donors));
            panelTop = new Panel();
            pbdonorsClose = new PictureBox();
            lbldonorsForm = new Label();
            btnupdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            dgvUsers = new DataGridView();
            txtUserSearch = new TextBox();
            txtSearch = new Label();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtmail = new TextBox();
            txtFullname = new TextBox();
            btnSI = new Button();
            pbSelectImage = new PictureBox();
            lblUserID = new Label();
            lblFullname = new Label();
            lblmail = new Label();
            lblUsername = new Label();
            lblPwd = new Label();
            lblContact = new Label();
            lbladdress = new Label();
            lblProfPic = new Label();
            txtUserID = new TextBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbdonorsClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSelectImage).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.Control;
            panelTop.Controls.Add(pbdonorsClose);
            panelTop.Controls.Add(lbldonorsForm);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5, 4, 5, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1150, 70);
            panelTop.TabIndex = 1;
            // 
            // pbdonorsClose
            // 
            pbdonorsClose.Cursor = Cursors.Hand;
            pbdonorsClose.Image = (Image)resources.GetObject("pbdonorsClose.Image");
            pbdonorsClose.Location = new Point(1031, 32);
            pbdonorsClose.Name = "pbdonorsClose";
            pbdonorsClose.Size = new Size(35, 35);
            pbdonorsClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbdonorsClose.TabIndex = 1;
            pbdonorsClose.TabStop = false;
            pbdonorsClose.Click += pbdonorsClose_Click;
            // 
            // lbldonorsForm
            // 
            lbldonorsForm.AutoSize = true;
            lbldonorsForm.Cursor = Cursors.Hand;
            lbldonorsForm.Font = new Font("Harrington", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldonorsForm.ForeColor = SystemColors.ControlText;
            lbldonorsForm.Location = new Point(481, 31);
            lbldonorsForm.Name = "lbldonorsForm";
            lbldonorsForm.Size = new Size(236, 35);
            lbldonorsForm.TabIndex = 0;
            lbldonorsForm.Text = "Manage Donors";
            // 
            // btnupdate
            // 
            btnupdate.Cursor = Cursors.Hand;
            btnupdate.ForeColor = SystemColors.Desktop;
            btnupdate.Location = new Point(699, 556);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 38);
            btnupdate.TabIndex = 33;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = SystemColors.Desktop;
            btnDelete.Location = new Point(820, 556);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.ForeColor = SystemColors.Desktop;
            btnClear.Location = new Point(940, 556);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 38);
            btnClear.TabIndex = 31;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.ForeColor = SystemColors.Desktop;
            btnAdd.Location = new Point(578, 556);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 38);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.ActiveBorder;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.GridColor = Color.Black;
            dgvUsers.Location = new Point(603, 214);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(463, 269);
            dgvUsers.TabIndex = 29;
            // 
            // txtUserSearch
            // 
            txtUserSearch.Cursor = Cursors.Hand;
            txtUserSearch.Location = new Point(699, 140);
            txtUserSearch.Name = "txtUserSearch";
            txtUserSearch.Size = new Size(342, 27);
            txtUserSearch.TabIndex = 28;
            // 
            // txtSearch
            // 
            txtSearch.AutoSize = true;
            txtSearch.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.Desktop;
            txtSearch.Location = new Point(593, 140);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(72, 24);
            txtSearch.TabIndex = 27;
            txtSearch.Text = "Search";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(180, 601);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(312, 91);
            txtAddress.TabIndex = 50;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(180, 533);
            txtContact.MaxLength = 10;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(312, 27);
            txtContact.TabIndex = 49;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(180, 470);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(312, 27);
            txtPassword.TabIndex = 48;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(180, 403);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(312, 27);
            txtUsername.TabIndex = 47;
            // 
            // txtmail
            // 
            txtmail.Location = new Point(180, 339);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(312, 27);
            txtmail.TabIndex = 46;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(180, 276);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(312, 27);
            txtFullname.TabIndex = 45;
            // 
            // btnSI
            // 
            btnSI.Cursor = Cursors.Hand;
            btnSI.ForeColor = SystemColors.Desktop;
            btnSI.Location = new Point(331, 151);
            btnSI.Name = "btnSI";
            btnSI.Size = new Size(161, 41);
            btnSI.TabIndex = 43;
            btnSI.Text = "Select image";
            btnSI.UseVisualStyleBackColor = true;
            // 
            // pbSelectImage
            // 
            pbSelectImage.Location = new Point(183, 98);
            pbSelectImage.Name = "pbSelectImage";
            pbSelectImage.Size = new Size(122, 82);
            pbSelectImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSelectImage.TabIndex = 42;
            pbSelectImage.TabStop = false;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = SystemColors.Desktop;
            lblUserID.Location = new Point(26, 214);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(75, 24);
            lblUserID.TabIndex = 41;
            lblUserID.Text = "User ID";
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFullname.ForeColor = SystemColors.Desktop;
            lblFullname.Location = new Point(26, 276);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(97, 24);
            lblFullname.TabIndex = 40;
            lblFullname.Text = "Full Name";
            // 
            // lblmail
            // 
            lblmail.AutoSize = true;
            lblmail.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblmail.ForeColor = SystemColors.Desktop;
            lblmail.Location = new Point(26, 339);
            lblmail.Name = "lblmail";
            lblmail.Size = new Size(59, 24);
            lblmail.TabIndex = 39;
            lblmail.Text = "Email";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.Desktop;
            lblUsername.Location = new Point(25, 403);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(98, 24);
            lblUsername.TabIndex = 38;
            lblUsername.Text = "Username";
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPwd.ForeColor = SystemColors.Desktop;
            lblPwd.Location = new Point(25, 470);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(97, 24);
            lblPwd.TabIndex = 37;
            lblPwd.Text = "Password";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblContact.ForeColor = SystemColors.Desktop;
            lblContact.Location = new Point(26, 533);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(77, 24);
            lblContact.TabIndex = 36;
            lblContact.Text = "Contact";
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbladdress.ForeColor = SystemColors.Desktop;
            lbladdress.Location = new Point(26, 601);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(85, 24);
            lbladdress.TabIndex = 35;
            lbladdress.Text = "Address";
            // 
            // lblProfPic
            // 
            lblProfPic.AutoSize = true;
            lblProfPic.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProfPic.ForeColor = SystemColors.Desktop;
            lblProfPic.Location = new Point(18, 87);
            lblProfPic.Name = "lblProfPic";
            lblProfPic.Size = new Size(136, 24);
            lblProfPic.TabIndex = 34;
            lblProfPic.Text = "Profile Picture";
            // 
            // txtUserID
            // 
            txtUserID.Cursor = Cursors.No;
            txtUserID.Location = new Point(183, 214);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(312, 27);
            txtUserID.TabIndex = 51;
            // 
            // Donors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1150, 700);
            Controls.Add(txtUserID);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtmail);
            Controls.Add(txtFullname);
            Controls.Add(btnSI);
            Controls.Add(pbSelectImage);
            Controls.Add(lblUserID);
            Controls.Add(lblFullname);
            Controls.Add(lblmail);
            Controls.Add(lblUsername);
            Controls.Add(lblPwd);
            Controls.Add(lblContact);
            Controls.Add(lbladdress);
            Controls.Add(lblProfPic);
            Controls.Add(btnupdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(dgvUsers);
            Controls.Add(txtUserSearch);
            Controls.Add(txtSearch);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Donors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Donors";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbdonorsClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSelectImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private PictureBox pbdonorsClose;
        private Label lbldonorsForm;
        private Button btnupdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnAdd;
        private DataGridView dgvUsers;
        private TextBox txtUserSearch;
        private Label txtSearch;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtmail;
        private TextBox txtFullname;
        private Button btnSI;
        private PictureBox pbSelectImage;
        private Label lblUserID;
        private Label lblFullname;
        private Label lblmail;
        private Label lblUsername;
        private Label lblPwd;
        private Label lblContact;
        private Label lbladdress;
        private Label lblProfPic;
        private TextBox txtUserID;
    }
}