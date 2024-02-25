namespace Blood_Banks.UI
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            panelTop = new Panel();
            lblusersForm = new Label();
            lblProfPic = new Label();
            txtSearch = new Label();
            lbladdress = new Label();
            lblContact = new Label();
            lblPwd = new Label();
            lblUsername = new Label();
            lblmail = new Label();
            lblFullname = new Label();
            lblUserID = new Label();
            pictureBox1 = new PictureBox();
            btnSI = new Button();
            txtUserID = new TextBox();
            txtFullname = new TextBox();
            txtmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            txtUserSearch = new TextBox();
            dgvUsers = new DataGridView();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnupdate = new Button();
            pbusersClose = new PictureBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbusersClose).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.Control;
            panelTop.Controls.Add(pbusersClose);
            panelTop.Controls.Add(lblusersForm);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5, 4, 5, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1200, 70);
            panelTop.TabIndex = 0;
            // 
            // lblusersForm
            // 
            lblusersForm.AutoSize = true;
            lblusersForm.Cursor = Cursors.Hand;
            lblusersForm.Font = new Font("Harrington", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusersForm.ForeColor = SystemColors.ControlText;
            lblusersForm.Location = new Point(544, 31);
            lblusersForm.Name = "lblusersForm";
            lblusersForm.Size = new Size(214, 35);
            lblusersForm.TabIndex = 0;
            lblusersForm.Text = "Manage Users";
            // 
            // lblProfPic
            // 
            lblProfPic.AutoSize = true;
            lblProfPic.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProfPic.ForeColor = SystemColors.Desktop;
            lblProfPic.Location = new Point(12, 92);
            lblProfPic.Name = "lblProfPic";
            lblProfPic.Size = new Size(136, 24);
            lblProfPic.TabIndex = 1;
            lblProfPic.Text = "Profile Picture";
            // 
            // txtSearch
            // 
            txtSearch.AutoSize = true;
            txtSearch.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.Desktop;
            txtSearch.Location = new Point(676, 142);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(72, 24);
            txtSearch.TabIndex = 3;
            txtSearch.Text = "Search";
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbladdress.ForeColor = SystemColors.Desktop;
            lbladdress.Location = new Point(20, 606);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(85, 24);
            lbladdress.TabIndex = 4;
            lbladdress.Text = "Address";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblContact.ForeColor = SystemColors.Desktop;
            lblContact.Location = new Point(20, 538);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(77, 24);
            lblContact.TabIndex = 5;
            lblContact.Text = "Contact";
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPwd.ForeColor = SystemColors.Desktop;
            lblPwd.Location = new Point(19, 475);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(97, 24);
            lblPwd.TabIndex = 6;
            lblPwd.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.Desktop;
            lblUsername.Location = new Point(19, 408);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(98, 24);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            // 
            // lblmail
            // 
            lblmail.AutoSize = true;
            lblmail.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblmail.ForeColor = SystemColors.Desktop;
            lblmail.Location = new Point(20, 344);
            lblmail.Name = "lblmail";
            lblmail.Size = new Size(59, 24);
            lblmail.TabIndex = 8;
            lblmail.Text = "Email";
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFullname.ForeColor = SystemColors.Desktop;
            lblFullname.Location = new Point(20, 281);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(97, 24);
            lblFullname.TabIndex = 9;
            lblFullname.Text = "Full Name";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = SystemColors.Desktop;
            lblUserID.Location = new Point(20, 219);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(75, 24);
            lblUserID.TabIndex = 10;
            lblUserID.Text = "User ID";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(177, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 82);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnSI
            // 
            btnSI.Cursor = Cursors.Hand;
            btnSI.ForeColor = SystemColors.Desktop;
            btnSI.Location = new Point(325, 156);
            btnSI.Name = "btnSI";
            btnSI.Size = new Size(161, 41);
            btnSI.TabIndex = 12;
            btnSI.Text = "Select image";
            btnSI.UseVisualStyleBackColor = true;
            // 
            // txtUserID
            // 
            txtUserID.BorderStyle = BorderStyle.None;
            txtUserID.Cursor = Cursors.No;
            txtUserID.Location = new Point(174, 213);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(312, 28);
            txtUserID.TabIndex = 13;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(174, 281);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(312, 35);
            txtFullname.TabIndex = 14;
            // 
            // txtmail
            // 
            txtmail.Location = new Point(174, 344);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(312, 35);
            txtmail.TabIndex = 15;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(174, 408);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(312, 35);
            txtUsername.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(174, 475);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(312, 35);
            txtPassword.TabIndex = 17;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(174, 538);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(312, 35);
            txtContact.TabIndex = 18;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(174, 606);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(312, 91);
            txtAddress.TabIndex = 19;
            // 
            // txtUserSearch
            // 
            txtUserSearch.Cursor = Cursors.Hand;
            txtUserSearch.Location = new Point(775, 136);
            txtUserSearch.Name = "txtUserSearch";
            txtUserSearch.Size = new Size(342, 35);
            txtUserSearch.TabIndex = 20;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(664, 213);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(463, 269);
            dgvUsers.TabIndex = 21;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.ForeColor = SystemColors.Desktop;
            btnAdd.Location = new Point(533, 544);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 38);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.ForeColor = SystemColors.Desktop;
            btnClear.Location = new Point(895, 544);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 38);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = SystemColors.Desktop;
            btnDelete.Location = new Point(775, 544);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            btnupdate.Cursor = Cursors.Hand;
            btnupdate.ForeColor = SystemColors.Desktop;
            btnupdate.Location = new Point(654, 544);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 38);
            btnupdate.TabIndex = 26;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // pbusersClose
            // 
            pbusersClose.Cursor = Cursors.Hand;
            pbusersClose.Image = (Image)resources.GetObject("pbusersClose.Image");
            pbusersClose.Location = new Point(1153, 31);
            pbusersClose.Name = "pbusersClose";
            pbusersClose.Size = new Size(35, 35);
            pbusersClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbusersClose.TabIndex = 1;
            pbusersClose.TabStop = false;
            pbusersClose.Click += pbusersClose_Click;
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1200, 700);
            Controls.Add(btnupdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(dgvUsers);
            Controls.Add(txtUserSearch);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtmail);
            Controls.Add(txtFullname);
            Controls.Add(txtUserID);
            Controls.Add(btnSI);
            Controls.Add(pictureBox1);
            Controls.Add(lblUserID);
            Controls.Add(lblFullname);
            Controls.Add(lblmail);
            Controls.Add(lblUsername);
            Controls.Add(lblPwd);
            Controls.Add(lblContact);
            Controls.Add(lbladdress);
            Controls.Add(txtSearch);
            Controls.Add(lblProfPic);
            Controls.Add(panelTop);
            Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "users";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbusersClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label lblusersForm;
        private Label lblProfPic;
        private Label txtSearch;
        private Label lbladdress;
        private Label lblContact;
        private Label lblPwd;
        private Label lblUsername;
        private Label lblmail;
        private Label lblFullname;
        private Label lblUserID;
        private PictureBox pictureBox1;
        private Button btnSI;
        private TextBox txtUserID;
        private TextBox txtFullname;
        private TextBox txtmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtContact;
        private TextBox txtAddress;
        private TextBox txtUserSearch;
        private DataGridView dgvUsers;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private Button btnupdate;
        private PictureBox pbusersClose;
    }
}