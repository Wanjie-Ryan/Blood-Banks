namespace Blood_Banks.UI
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            pbLogo = new PictureBox();
            lblLogo = new Label();
            lblLogo2 = new Label();
            panelBG = new Panel();
            panelMovable = new Panel();
            timerSplash = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panelBG.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(254, 131);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(176, 122);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Harrington", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(479, 131);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(364, 71);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Blood Bank ";
            // 
            // lblLogo2
            // 
            lblLogo2.AutoSize = true;
            lblLogo2.Font = new Font("Harrington", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogo2.ForeColor = Color.Brown;
            lblLogo2.Location = new Point(526, 212);
            lblLogo2.Name = "lblLogo2";
            lblLogo2.Size = new Size(280, 32);
            lblLogo2.TabIndex = 2;
            lblLogo2.Text = "Management System";
            // 
            // panelBG
            // 
            panelBG.BackColor = Color.WhiteSmoke;
            panelBG.Controls.Add(panelMovable);
            panelBG.Location = new Point(0, 313);
            panelBG.Name = "panelBG";
            panelBG.Size = new Size(967, 57);
            panelBG.TabIndex = 3;
            // 
            // panelMovable
            // 
            panelMovable.BackColor = Color.Green;
            panelMovable.Location = new Point(0, 16);
            panelMovable.Name = "panelMovable";
            panelMovable.Size = new Size(26, 28);
            panelMovable.TabIndex = 0;
            // 
            // timerSplash
            // 
            timerSplash.Tick += timerSplash_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(965, 390);
            Controls.Add(panelBG);
            Controls.Add(lblLogo2);
            Controls.Add(lblLogo);
            Controls.Add(pbLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panelBG.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblLogo;
        private Label lblLogo2;
        private Panel panelBG;
        private Panel panelMovable;
        private System.Windows.Forms.Timer timerSplash;
    }
}