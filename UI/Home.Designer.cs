namespace Blood_Banks
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            menuStripTop = new MenuStrip();
            usersNav = new ToolStripMenuItem();
            donorsNav = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pbClose = new PictureBox();
            panelBottom = new Panel();
            lblFooterTitle = new Label();
            lbldesigned = new Label();
            panelOPos = new Panel();
            lblOposDonor = new Label();
            lblOPosCount = new Label();
            lblOpos = new Label();
            panelONeg = new Panel();
            lblONegDonor = new Label();
            lblOnegCount = new Label();
            lblOneg = new Label();
            panelANeg = new Panel();
            lblAnegDonor = new Label();
            lblAnegCount = new Label();
            lblANeg = new Label();
            panelApos = new Panel();
            lblAposDonor = new Label();
            lblAposCount = new Label();
            lblApos = new Label();
            panelBNeg = new Panel();
            lblBNegDonor = new Label();
            lblBNegCount = new Label();
            lblBNeg = new Label();
            panelBPos = new Panel();
            lblBPosDonor = new Label();
            lblBPosCount = new Label();
            lblBPos = new Label();
            panelABNeg = new Panel();
            lblABNegDonor = new Label();
            lblABNegCount = new Label();
            lblABNeg = new Label();
            panelABpos = new Panel();
            lblABposDonor = new Label();
            lblABposCount = new Label();
            lblABpos = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvDonors = new DataGridView();
            menuStripTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            panelBottom.SuspendLayout();
            panelOPos.SuspendLayout();
            panelONeg.SuspendLayout();
            panelANeg.SuspendLayout();
            panelApos.SuspendLayout();
            panelBNeg.SuspendLayout();
            panelBPos.SuspendLayout();
            panelABNeg.SuspendLayout();
            panelABpos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).BeginInit();
            SuspendLayout();
            // 
            // menuStripTop
            // 
            menuStripTop.ImageScalingSize = new Size(20, 20);
            menuStripTop.Items.AddRange(new ToolStripItem[] { usersNav, donorsNav });
            menuStripTop.Location = new Point(0, 0);
            menuStripTop.Name = "menuStripTop";
            menuStripTop.Padding = new Padding(8, 10, 0, 10);
            menuStripTop.Size = new Size(1103, 51);
            menuStripTop.TabIndex = 0;
            menuStripTop.Text = "menuStrip1";
            menuStripTop.ItemClicked += menuStripTop_ItemClicked;
            // 
            // usersNav
            // 
            usersNav.Font = new Font("Harrington", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersNav.Name = "usersNav";
            usersNav.Size = new Size(88, 31);
            usersNav.Text = "Users";
            usersNav.Click += this.usersNav_Click;
            // 
            // donorsNav
            // 
            donorsNav.Font = new Font("Harrington", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donorsNav.Name = "donorsNav";
            donorsNav.Size = new Size(107, 31);
            donorsNav.Text = "Donors";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1190, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 33);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pbClose
            // 
            pbClose.BackColor = SystemColors.Control;
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(1022, 12);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(23, 26);
            pbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClose.TabIndex = 2;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(lblFooterTitle);
            panelBottom.Controls.Add(lbldesigned);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 611);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1103, 69);
            panelBottom.TabIndex = 3;
            // 
            // lblFooterTitle
            // 
            lblFooterTitle.AutoSize = true;
            lblFooterTitle.Font = new Font("Harrington", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFooterTitle.Location = new Point(40, 21);
            lblFooterTitle.Name = "lblFooterTitle";
            lblFooterTitle.Size = new Size(376, 27);
            lblFooterTitle.TabIndex = 1;
            lblFooterTitle.Text = "Blood Bank Management System ";
            // 
            // lbldesigned
            // 
            lbldesigned.AutoSize = true;
            lbldesigned.Font = new Font("Harrington", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldesigned.Location = new Point(692, 21);
            lbldesigned.Name = "lbldesigned";
            lbldesigned.Size = new Size(297, 27);
            lbldesigned.TabIndex = 0;
            lbldesigned.Text = "Designed By Wanjie Ryan";
            // 
            // panelOPos
            // 
            panelOPos.BackColor = SystemColors.Control;
            panelOPos.Controls.Add(lblOposDonor);
            panelOPos.Controls.Add(lblOPosCount);
            panelOPos.Controls.Add(lblOpos);
            panelOPos.Location = new Point(12, 73);
            panelOPos.Name = "panelOPos";
            panelOPos.Size = new Size(200, 100);
            panelOPos.TabIndex = 4;
            // 
            // lblOposDonor
            // 
            lblOposDonor.AutoSize = true;
            lblOposDonor.Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOposDonor.ForeColor = Color.FromArgb(226, 76, 58);
            lblOposDonor.Location = new Point(98, 64);
            lblOposDonor.Name = "lblOposDonor";
            lblOposDonor.Size = new Size(87, 27);
            lblOposDonor.TabIndex = 5;
            lblOposDonor.Text = "Donors";
            // 
            // lblOPosCount
            // 
            lblOPosCount.AutoSize = true;
            lblOPosCount.Font = new Font("Harrington", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOPosCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblOPosCount.Location = new Point(115, 12);
            lblOPosCount.Name = "lblOPosCount";
            lblOPosCount.Size = new Size(56, 32);
            lblOPosCount.TabIndex = 5;
            lblOPosCount.Text = "100";
            // 
            // lblOpos
            // 
            lblOpos.AutoSize = true;
            lblOpos.Font = new Font("Harrington", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpos.ForeColor = Color.FromArgb(226, 76, 58);
            lblOpos.Location = new Point(16, 33);
            lblOpos.Name = "lblOpos";
            lblOpos.Size = new Size(60, 44);
            lblOpos.TabIndex = 5;
            lblOpos.Text = "O+";
            // 
            // panelONeg
            // 
            panelONeg.BackColor = SystemColors.Control;
            panelONeg.Controls.Add(lblONegDonor);
            panelONeg.Controls.Add(lblOnegCount);
            panelONeg.Controls.Add(lblOneg);
            panelONeg.Location = new Point(234, 73);
            panelONeg.Name = "panelONeg";
            panelONeg.Size = new Size(200, 100);
            panelONeg.TabIndex = 6;
            // 
            // lblONegDonor
            // 
            lblONegDonor.AutoSize = true;
            lblONegDonor.Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblONegDonor.ForeColor = Color.FromArgb(226, 76, 58);
            lblONegDonor.Location = new Point(98, 64);
            lblONegDonor.Name = "lblONegDonor";
            lblONegDonor.Size = new Size(87, 27);
            lblONegDonor.TabIndex = 5;
            lblONegDonor.Text = "Donors";
            // 
            // lblOnegCount
            // 
            lblOnegCount.AutoSize = true;
            lblOnegCount.Font = new Font("Harrington", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOnegCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblOnegCount.Location = new Point(115, 12);
            lblOnegCount.Name = "lblOnegCount";
            lblOnegCount.Size = new Size(56, 32);
            lblOnegCount.TabIndex = 5;
            lblOnegCount.Text = "100";
            // 
            // lblOneg
            // 
            lblOneg.AutoSize = true;
            lblOneg.Font = new Font("Harrington", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOneg.ForeColor = Color.FromArgb(226, 76, 58);
            lblOneg.Location = new Point(16, 33);
            lblOneg.Name = "lblOneg";
            lblOneg.Size = new Size(59, 44);
            lblOneg.TabIndex = 5;
            lblOneg.Text = "O-";
            // 
            // panelANeg
            // 
            panelANeg.BackColor = SystemColors.Control;
            panelANeg.Controls.Add(lblAnegDonor);
            panelANeg.Controls.Add(lblAnegCount);
            panelANeg.Controls.Add(lblANeg);
            panelANeg.Location = new Point(234, 202);
            panelANeg.Name = "panelANeg";
            panelANeg.Size = new Size(200, 100);
            panelANeg.TabIndex = 8;
            // 
            // lblAnegDonor
            // 
            lblAnegDonor.AutoSize = true;
            lblAnegDonor.Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAnegDonor.ForeColor = Color.FromArgb(226, 76, 58);
            lblAnegDonor.Location = new Point(98, 64);
            lblAnegDonor.Name = "lblAnegDonor";
            lblAnegDonor.Size = new Size(87, 27);
            lblAnegDonor.TabIndex = 5;
            lblAnegDonor.Text = "Donors";
            // 
            // lblAnegCount
            // 
            lblAnegCount.AutoSize = true;
            lblAnegCount.Font = new Font("Harrington", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnegCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblAnegCount.Location = new Point(115, 12);
            lblAnegCount.Name = "lblAnegCount";
            lblAnegCount.Size = new Size(56, 32);
            lblAnegCount.TabIndex = 5;
            lblAnegCount.Text = "100";
            // 
            // lblANeg
            // 
            lblANeg.AutoSize = true;
            lblANeg.Font = new Font("Harrington", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblANeg.ForeColor = Color.FromArgb(226, 76, 58);
            lblANeg.Location = new Point(16, 33);
            lblANeg.Name = "lblANeg";
            lblANeg.Size = new Size(62, 44);
            lblANeg.TabIndex = 5;
            lblANeg.Text = "A-";
            // 
            // panelApos
            // 
            panelApos.BackColor = SystemColors.Control;
            panelApos.Controls.Add(lblAposDonor);
            panelApos.Controls.Add(lblAposCount);
            panelApos.Controls.Add(lblApos);
            panelApos.Location = new Point(12, 202);
            panelApos.Name = "panelApos";
            panelApos.Size = new Size(200, 100);
            panelApos.TabIndex = 7;
            // 
            // lblAposDonor
            // 
            lblAposDonor.AutoSize = true;
            lblAposDonor.Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAposDonor.ForeColor = Color.FromArgb(226, 76, 58);
            lblAposDonor.Location = new Point(98, 64);
            lblAposDonor.Name = "lblAposDonor";
            lblAposDonor.Size = new Size(87, 27);
            lblAposDonor.TabIndex = 5;
            lblAposDonor.Text = "Donors";
            // 
            // lblAposCount
            // 
            lblAposCount.AutoSize = true;
            lblAposCount.Font = new Font("Harrington", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAposCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblAposCount.Location = new Point(115, 12);
            lblAposCount.Name = "lblAposCount";
            lblAposCount.Size = new Size(56, 32);
            lblAposCount.TabIndex = 5;
            lblAposCount.Text = "100";
            // 
            // lblApos
            // 
            lblApos.AutoSize = true;
            lblApos.Font = new Font("Harrington", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApos.ForeColor = Color.FromArgb(226, 76, 58);
            lblApos.Location = new Point(16, 33);
            lblApos.Name = "lblApos";
            lblApos.Size = new Size(63, 44);
            lblApos.TabIndex = 5;
            lblApos.Text = "A+";
            // 
            // panelBNeg
            // 
            panelBNeg.BackColor = SystemColors.Control;
            panelBNeg.Controls.Add(lblBNegDonor);
            panelBNeg.Controls.Add(lblBNegCount);
            panelBNeg.Controls.Add(lblBNeg);
            panelBNeg.Location = new Point(234, 325);
            panelBNeg.Name = "panelBNeg";
            panelBNeg.Size = new Size(200, 100);
            panelBNeg.TabIndex = 8;
            // 
            // lblBNegDonor
            // 
            lblBNegDonor.AutoSize = true;
            lblBNegDonor.Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBNegDonor.ForeColor = Color.FromArgb(226, 76, 58);
            lblBNegDonor.Location = new Point(98, 64);
            lblBNegDonor.Name = "lblBNegDonor";
            lblBNegDonor.Size = new Size(87, 27);
            lblBNegDonor.TabIndex = 5;
            lblBNegDonor.Text = "Donors";
            // 
            // lblBNegCount
            // 
            lblBNegCount.AutoSize = true;
            lblBNegCount.Font = new Font("Harrington", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBNegCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblBNegCount.Location = new Point(115, 12);
            lblBNegCount.Name = "lblBNegCount";
            lblBNegCount.Size = new Size(56, 32);
            lblBNegCount.TabIndex = 5;
            lblBNegCount.Text = "100";
            // 
            // lblBNeg
            // 
            lblBNeg.AutoSize = true;
            lblBNeg.Font = new Font("Harrington", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBNeg.ForeColor = Color.FromArgb(226, 76, 58);
            lblBNeg.Location = new Point(16, 33);
            lblBNeg.Name = "lblBNeg";
            lblBNeg.Size = new Size(60, 44);
            lblBNeg.TabIndex = 5;
            lblBNeg.Text = "B-";
            // 
            // panelBPos
            // 
            panelBPos.BackColor = SystemColors.Control;
            panelBPos.Controls.Add(lblBPosDonor);
            panelBPos.Controls.Add(lblBPosCount);
            panelBPos.Controls.Add(lblBPos);
            panelBPos.Location = new Point(12, 325);
            panelBPos.Name = "panelBPos";
            panelBPos.Size = new Size(200, 100);
            panelBPos.TabIndex = 7;
            // 
            // lblBPosDonor
            // 
            lblBPosDonor.AutoSize = true;
            lblBPosDonor.Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBPosDonor.ForeColor = Color.FromArgb(226, 76, 58);
            lblBPosDonor.Location = new Point(98, 64);
            lblBPosDonor.Name = "lblBPosDonor";
            lblBPosDonor.Size = new Size(87, 27);
            lblBPosDonor.TabIndex = 5;
            lblBPosDonor.Text = "Donors";
            // 
            // lblBPosCount
            // 
            lblBPosCount.AutoSize = true;
            lblBPosCount.Font = new Font("Harrington", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBPosCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblBPosCount.Location = new Point(115, 12);
            lblBPosCount.Name = "lblBPosCount";
            lblBPosCount.Size = new Size(56, 32);
            lblBPosCount.TabIndex = 5;
            lblBPosCount.Text = "100";
            // 
            // lblBPos
            // 
            lblBPos.AutoSize = true;
            lblBPos.Font = new Font("Harrington", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBPos.ForeColor = Color.FromArgb(226, 76, 58);
            lblBPos.Location = new Point(16, 33);
            lblBPos.Name = "lblBPos";
            lblBPos.Size = new Size(61, 44);
            lblBPos.TabIndex = 5;
            lblBPos.Text = "B+";
            // 
            // panelABNeg
            // 
            panelABNeg.BackColor = SystemColors.Control;
            panelABNeg.Controls.Add(lblABNegDonor);
            panelABNeg.Controls.Add(lblABNegCount);
            panelABNeg.Controls.Add(lblABNeg);
            panelABNeg.Location = new Point(234, 455);
            panelABNeg.Name = "panelABNeg";
            panelABNeg.Size = new Size(200, 100);
            panelABNeg.TabIndex = 10;
            // 
            // lblABNegDonor
            // 
            lblABNegDonor.AutoSize = true;
            lblABNegDonor.Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblABNegDonor.ForeColor = Color.FromArgb(226, 76, 58);
            lblABNegDonor.Location = new Point(98, 64);
            lblABNegDonor.Name = "lblABNegDonor";
            lblABNegDonor.Size = new Size(87, 27);
            lblABNegDonor.TabIndex = 5;
            lblABNegDonor.Text = "Donors";
            // 
            // lblABNegCount
            // 
            lblABNegCount.AutoSize = true;
            lblABNegCount.Font = new Font("Harrington", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblABNegCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblABNegCount.Location = new Point(115, 12);
            lblABNegCount.Name = "lblABNegCount";
            lblABNegCount.Size = new Size(56, 32);
            lblABNegCount.TabIndex = 5;
            lblABNegCount.Text = "100";
            // 
            // lblABNeg
            // 
            lblABNeg.AutoSize = true;
            lblABNeg.Font = new Font("Harrington", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblABNeg.ForeColor = Color.FromArgb(226, 76, 58);
            lblABNeg.Location = new Point(16, 33);
            lblABNeg.Name = "lblABNeg";
            lblABNeg.Size = new Size(89, 44);
            lblABNeg.TabIndex = 5;
            lblABNeg.Text = "AB-";
            // 
            // panelABpos
            // 
            panelABpos.BackColor = SystemColors.Control;
            panelABpos.Controls.Add(lblABposDonor);
            panelABpos.Controls.Add(lblABposCount);
            panelABpos.Controls.Add(lblABpos);
            panelABpos.Location = new Point(12, 455);
            panelABpos.Name = "panelABpos";
            panelABpos.Size = new Size(200, 100);
            panelABpos.TabIndex = 9;
            // 
            // lblABposDonor
            // 
            lblABposDonor.AutoSize = true;
            lblABposDonor.Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblABposDonor.ForeColor = Color.FromArgb(226, 76, 58);
            lblABposDonor.Location = new Point(98, 64);
            lblABposDonor.Name = "lblABposDonor";
            lblABposDonor.Size = new Size(87, 27);
            lblABposDonor.TabIndex = 5;
            lblABposDonor.Text = "Donors";
            // 
            // lblABposCount
            // 
            lblABposCount.AutoSize = true;
            lblABposCount.Font = new Font("Harrington", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblABposCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblABposCount.Location = new Point(115, 12);
            lblABposCount.Name = "lblABposCount";
            lblABposCount.Size = new Size(56, 32);
            lblABposCount.TabIndex = 5;
            lblABposCount.Text = "100";
            // 
            // lblABpos
            // 
            lblABpos.AutoSize = true;
            lblABpos.Font = new Font("Harrington", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblABpos.ForeColor = Color.FromArgb(226, 76, 58);
            lblABpos.Location = new Point(16, 33);
            lblABpos.Name = "lblABpos";
            lblABpos.Size = new Size(90, 44);
            lblABpos.TabIndex = 5;
            lblABpos.Text = "AB+";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(599, 122);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(150, 27);
            lblSearch.TabIndex = 11;
            lblSearch.Text = "Search Donor";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Harrington", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(755, 122);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(298, 28);
            txtSearch.TabIndex = 12;
            // 
            // dgvDonors
            // 
            dgvDonors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonors.Location = new Point(599, 168);
            dgvDonors.Name = "dgvDonors";
            dgvDonors.RowHeadersWidth = 51;
            dgvDonors.Size = new Size(454, 387);
            dgvDonors.TabIndex = 13;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1103, 680);
            Controls.Add(dgvDonors);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(panelABNeg);
            Controls.Add(panelABpos);
            Controls.Add(panelBNeg);
            Controls.Add(panelBPos);
            Controls.Add(panelANeg);
            Controls.Add(panelONeg);
            Controls.Add(panelApos);
            Controls.Add(panelOPos);
            Controls.Add(panelBottom);
            Controls.Add(pbClose);
            Controls.Add(pictureBox1);
            Controls.Add(menuStripTop);
            Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripTop;
            Margin = new Padding(4);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            menuStripTop.ResumeLayout(false);
            menuStripTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelOPos.ResumeLayout(false);
            panelOPos.PerformLayout();
            panelONeg.ResumeLayout(false);
            panelONeg.PerformLayout();
            panelANeg.ResumeLayout(false);
            panelANeg.PerformLayout();
            panelApos.ResumeLayout(false);
            panelApos.PerformLayout();
            panelBNeg.ResumeLayout(false);
            panelBNeg.PerformLayout();
            panelBPos.ResumeLayout(false);
            panelBPos.PerformLayout();
            panelABNeg.ResumeLayout(false);
            panelABNeg.PerformLayout();
            panelABpos.ResumeLayout(false);
            panelABpos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripTop;
        private ToolStripMenuItem usersNav;
        private ToolStripMenuItem donorsNav;
        private PictureBox pictureBox1;
        private PictureBox pbClose;
        private Panel panelBottom;
        private Label lblFooterTitle;
        private Label lbldesigned;
        private Panel panelOPos;
        private Label lblOpos;
        private Label lblOposDonor;
        private Label lblOPosCount;
        private Panel panelONeg;
        private Label lblONegDonor;
        private Label lblOnegCount;
        private Label lblOneg;
        private Panel panelANeg;
        private Label lblAnegDonor;
        private Label lblAnegCount;
        private Label lblANeg;
        private Panel panelApos;
        private Label lblAposDonor;
        private Label lblAposCount;
        private Label lblApos;
        private Panel panelBNeg;
        private Label lblBNegDonor;
        private Label lblBNegCount;
        private Label lblBNeg;
        private Panel panelBPos;
        private Label lblBPosDonor;
        private Label lblBPosCount;
        private Label lblBPos;
        private Panel panelABNeg;
        private Label lblABNegDonor;
        private Label lblABNegCount;
        private Label lblABNeg;
        private Panel panelABpos;
        private Label lblABposDonor;
        private Label lblABposCount;
        private Label lblABpos;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvDonors;
    }
}
