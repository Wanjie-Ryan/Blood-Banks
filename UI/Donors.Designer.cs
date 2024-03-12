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
            dgvDonors = new DataGridView();
            txtDonorSearch = new TextBox();
            txtSearch = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            btnSI = new Button();
            pbSelectImage = new PictureBox();
            lblUserID = new Label();
            lblFirstname = new Label();
            lbllastname = new Label();
            lblmail = new Label();
            lblgender = new Label();
            lblBloodgroup = new Label();
            lbladdress = new Label();
            lblProfPic = new Label();
            txtUserID = new TextBox();
            cmbGender = new ComboBox();
            cmbBloodGroup = new ComboBox();
            lblDonorContact = new Label();
            txtDonorContact = new TextBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbdonorsClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).BeginInit();
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
            btnupdate.Click += btnupdate_Click;
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
            btnDelete.Click += btnDelete_Click;
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
            btnClear.Click += btnClear_Click;
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
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvDonors
            // 
            dgvDonors.BackgroundColor = SystemColors.ActiveBorder;
            dgvDonors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonors.GridColor = Color.Black;
            dgvDonors.Location = new Point(603, 214);
            dgvDonors.Name = "dgvDonors";
            dgvDonors.RowHeadersWidth = 51;
            dgvDonors.Size = new Size(463, 269);
            dgvDonors.TabIndex = 29;
            dgvDonors.RowHeaderMouseClick += dgvDonors_RowHeaderMouseClick;
            // 
            // txtDonorSearch
            // 
            txtDonorSearch.Cursor = Cursors.Hand;
            txtDonorSearch.Location = new Point(699, 140);
            txtDonorSearch.Name = "txtDonorSearch";
            txtDonorSearch.Size = new Size(342, 27);
            txtDonorSearch.TabIndex = 28;
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
            txtAddress.Location = new Point(180, 678);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(312, 91);
            txtAddress.TabIndex = 50;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Harrington", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(180, 403);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(312, 27);
            txtEmail.TabIndex = 47;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Harrington", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(180, 339);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(312, 27);
            txtLastname.TabIndex = 46;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Harrington", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(180, 276);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(312, 27);
            txtFirstname.TabIndex = 45;
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
            lblUserID.Size = new Size(89, 24);
            lblUserID.TabIndex = 41;
            lblUserID.Text = "Donor ID";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFirstname.ForeColor = SystemColors.Desktop;
            lblFirstname.Location = new Point(26, 276);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(105, 24);
            lblFirstname.TabIndex = 40;
            lblFirstname.Text = "First Name";
            // 
            // lbllastname
            // 
            lbllastname.AutoSize = true;
            lbllastname.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbllastname.ForeColor = SystemColors.Desktop;
            lbllastname.Location = new Point(26, 339);
            lbllastname.Name = "lbllastname";
            lbllastname.Size = new Size(103, 24);
            lbllastname.TabIndex = 39;
            lbllastname.Text = "Last Name";
            // 
            // lblmail
            // 
            lblmail.AutoSize = true;
            lblmail.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblmail.ForeColor = SystemColors.Desktop;
            lblmail.Location = new Point(25, 403);
            lblmail.Name = "lblmail";
            lblmail.Size = new Size(59, 24);
            lblmail.TabIndex = 38;
            lblmail.Text = "Email";
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblgender.ForeColor = SystemColors.Desktop;
            lblgender.Location = new Point(25, 470);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(74, 24);
            lblgender.TabIndex = 37;
            lblgender.Text = "Gender";
            // 
            // lblBloodgroup
            // 
            lblBloodgroup.AutoSize = true;
            lblBloodgroup.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBloodgroup.ForeColor = SystemColors.Desktop;
            lblBloodgroup.Location = new Point(26, 533);
            lblBloodgroup.Name = "lblBloodgroup";
            lblBloodgroup.Size = new Size(122, 24);
            lblBloodgroup.TabIndex = 36;
            lblBloodgroup.Text = "Blood Group";
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbladdress.ForeColor = SystemColors.Desktop;
            lbladdress.Location = new Point(30, 678);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(85, 24);
            lbladdress.TabIndex = 35;
            lbladdress.Text = "Address";
            lbladdress.Click += lbladdress_Click;
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
            txtUserID.Font = new Font("Harrington", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserID.Location = new Point(183, 214);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(312, 27);
            txtUserID.TabIndex = 51;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Harrington", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male ", "Female" });
            cmbGender.Location = new Point(180, 470);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(315, 28);
            cmbGender.TabIndex = 52;
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.Font = new Font("Harrington", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Items.AddRange(new object[] { "O+", "O-", "A+", "A-", "B+", "AB+", "AB-" });
            cmbBloodGroup.Location = new Point(180, 533);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(315, 28);
            cmbBloodGroup.TabIndex = 53;
            // 
            // lblDonorContact
            // 
            lblDonorContact.AutoSize = true;
            lblDonorContact.Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDonorContact.ForeColor = SystemColors.Desktop;
            lblDonorContact.Location = new Point(26, 610);
            lblDonorContact.Name = "lblDonorContact";
            lblDonorContact.Size = new Size(77, 24);
            lblDonorContact.TabIndex = 54;
            lblDonorContact.Text = "Contact";
            // 
            // txtDonorContact
            // 
            txtDonorContact.Font = new Font("Harrington", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDonorContact.Location = new Point(183, 610);
            txtDonorContact.MaxLength = 10;
            txtDonorContact.Name = "txtDonorContact";
            txtDonorContact.Size = new Size(312, 27);
            txtDonorContact.TabIndex = 55;
            // 
            // Donors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1150, 800);
            Controls.Add(txtDonorContact);
            Controls.Add(lblDonorContact);
            Controls.Add(cmbBloodGroup);
            Controls.Add(cmbGender);
            Controls.Add(txtUserID);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(btnSI);
            Controls.Add(pbSelectImage);
            Controls.Add(lblUserID);
            Controls.Add(lblFirstname);
            Controls.Add(lbllastname);
            Controls.Add(lblmail);
            Controls.Add(lblgender);
            Controls.Add(lblBloodgroup);
            Controls.Add(lbladdress);
            Controls.Add(lblProfPic);
            Controls.Add(btnupdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(dgvDonors);
            Controls.Add(txtDonorSearch);
            Controls.Add(txtSearch);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Donors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Donors";
            Load += Donors_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbdonorsClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).EndInit();
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
        private DataGridView dgvDonors;
        private TextBox txtDonorSearch;
        private Label txtSearch;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private Button btnSI;
        private PictureBox pbSelectImage;
        private Label lblUserID;
        private Label lblFirstname;
        private Label lbllastname;
        private Label lblmail;
        private Label lblgender;
        private Label lblBloodgroup;
        private Label lbladdress;
        private Label lblProfPic;
        private TextBox txtUserID;
        private ComboBox cmbGender;
        private ComboBox cmbBloodGroup;
        private Label lblDonorContact;
        private TextBox txtDonorContact;
    }
}