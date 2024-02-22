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
            menuStripTop = new MenuStrip();
            usersNav = new ToolStripMenuItem();
            menuStripTop.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTop
            // 
            menuStripTop.ImageScalingSize = new Size(20, 20);
            menuStripTop.Items.AddRange(new ToolStripItem[] { usersNav });
            menuStripTop.Location = new Point(0, 0);
            menuStripTop.Name = "menuStripTop";
            menuStripTop.Size = new Size(1182, 35);
            menuStripTop.TabIndex = 0;
            menuStripTop.Text = "menuStrip1";
            // 
            // usersNav
            // 
            usersNav.Font = new Font("Harrington", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersNav.Name = "usersNav";
            usersNav.Size = new Size(88, 31);
            usersNav.Text = "Users";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1182, 753);
            Controls.Add(menuStripTop);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripTop;
            Name = "HomeForm";
            Text = "Home";
            menuStripTop.ResumeLayout(false);
            menuStripTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripTop;
        private ToolStripMenuItem usersNav;
    }
}
