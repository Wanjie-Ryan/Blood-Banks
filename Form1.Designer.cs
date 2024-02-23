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
            lbldesigned = new Label();
            lblFooterTitle = new Label();
            menuStripTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            panelBottom.SuspendLayout();
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
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(1022, 12);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(23, 39);
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
            panelBottom.Location = new Point(0, 431);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1103, 69);
            panelBottom.TabIndex = 3;
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
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1103, 500);
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
    }
}
