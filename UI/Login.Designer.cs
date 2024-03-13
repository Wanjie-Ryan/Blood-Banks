namespace Blood_Banks.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pbLogin = new PictureBox();
            lblLoginTitle = new Label();
            lblTitleLogin = new Label();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogin).BeginInit();
            SuspendLayout();
            // 
            // pbLogin
            // 
            pbLogin.Image = (Image)resources.GetObject("pbLogin.Image");
            pbLogin.Location = new Point(180, 102);
            pbLogin.Name = "pbLogin";
            pbLogin.Size = new Size(258, 208);
            pbLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogin.TabIndex = 0;
            pbLogin.TabStop = false;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Harrington", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLoginTitle.Location = new Point(159, 326);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(301, 55);
            lblLoginTitle.TabIndex = 1;
            lblLoginTitle.Text = "Blood Banks";
            // 
            // lblTitleLogin
            // 
            lblTitleLogin.AutoSize = true;
            lblTitleLogin.Location = new Point(180, 392);
            lblTitleLogin.Name = "lblTitleLogin";
            lblTitleLogin.Size = new Size(251, 21);
            lblTitleLogin.TabIndex = 2;
            lblTitleLogin.Text = "Management System -Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(620, 102);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 21);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(900, 600);
            Controls.Add(lblUsername);
            Controls.Add(lblTitleLogin);
            Controls.Add(lblLoginTitle);
            Controls.Add(pbLogin);
            Font = new Font("Harrington", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pbLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogin;
        private Label lblLoginTitle;
        private Label lblTitleLogin;
        private Label lblUsername;
    }
}