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
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pbCloseLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCloseLogin).BeginInit();
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
            // txtUsername
            // 
            txtUsername.Location = new Point(620, 139);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(217, 29);
            txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(620, 193);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 21);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(620, 232);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(217, 29);
            txtPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkGreen;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Harrington", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(638, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(174, 66);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pbCloseLogin
            // 
            pbCloseLogin.Cursor = Cursors.Hand;
            pbCloseLogin.Image = (Image)resources.GetObject("pbCloseLogin.Image");
            pbCloseLogin.Location = new Point(858, 12);
            pbCloseLogin.Name = "pbCloseLogin";
            pbCloseLogin.Size = new Size(30, 34);
            pbCloseLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCloseLogin.TabIndex = 8;
            pbCloseLogin.TabStop = false;
            pbCloseLogin.Click += pbCloseLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(900, 500);
            Controls.Add(pbCloseLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
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
            ((System.ComponentModel.ISupportInitialize)pbCloseLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogin;
        private Label lblLoginTitle;
        private Label lblTitleLogin;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pbCloseLogin;
    }
}